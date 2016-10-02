using System;
using System.Collections.ObjectModel;

namespace HtmlGenerator
{
    public class HtmlElement
    {
        private int _maximumIndentDepth = 9;
        private int _minimumIndentDepth = 1;

        protected HtmlElement(HtmlElement element) : this(element.ElementTag, element.IsVoid)
        {
        }

        internal HtmlElement(string elementTag, bool isVoid)
        {
            if (elementTag == null)
            {
                throw new ArgumentNullException(nameof(elementTag));
            }
            if (elementTag.Length == 0)
            {
                throw new ArgumentException("The element's tag cannot be empty", nameof(elementTag));
            }

            ElementTag = elementTag;
            IsVoid = isVoid;
        }

        public string ElementTag { get; }
        public bool IsVoid { get; }

        public string InnerText { get; private set; }

        public HtmlElement Parent { get; private set; }
        public Collection<HtmlElement> Children { get; private set; } = new Collection<HtmlElement>();

        public Collection<HtmlAttribute> Attributes { get; private set; } = new Collection<HtmlAttribute>();

        public int MinimumIndentDepth
        {
            get { return _minimumIndentDepth; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The minimum indent depth cannot be negative", nameof(value));
                }
                if (value > _maximumIndentDepth)
                {
                    throw new ArgumentException("The minimum indent depth cannot be larger than the maximum indent depth", nameof(value));
                }

                _minimumIndentDepth = value;
            }
        }

        public int MaximumIndentDepth
        {
            get { return _maximumIndentDepth; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The maximum indent depth cannot be negative", nameof(value));
                }
                if (value < _minimumIndentDepth)
                {
                    throw new ArgumentException("The maximum indent depth cannot be less than the minimum indent depth", nameof(value));
                }

                _maximumIndentDepth = value;
            }
        }

        public T InsertChild<T>(int index, T element) where T : HtmlElement
        {
            if (element == null)
            {
                throw new ArgumentNullException(nameof(element));
            }

            if (element == this)
            {
                throw new ArgumentException("You cannot add yourself to the list of children", nameof(element));
            }

            Children.Insert(index, element);
            element.Parent = this;
            return element;
        }

        public T AddChild<T>(T element) where T : HtmlElement => InsertChild(Children.Count, element);

        public void AddChildren(Collection<HtmlElement> children)
        {
            if (children == null)
            {
                throw new ArgumentNullException(nameof(children));
            }

            foreach (var child in children)
            {
                AddChild(child);
            }
        }

        public void SetChildren(Collection<HtmlElement> children)
        {
            Children = children ?? new Collection<HtmlElement>();
        }
        
        public void AddAttribute(HtmlAttribute attribute)
        {
            Attributes.Add(attribute);
        }

        public void AddAttribute(int index, HtmlAttribute attribute)
        {
            Attributes.Insert(index, attribute);
        }

        public void AddAttributes(Collection<HtmlAttribute> attributes)
        {
            if (attributes == null)
            {
                throw new ArgumentNullException(nameof(attributes));
            }

            foreach (var attribute in attributes)
            {
                AddAttribute(attribute);
            }
        }

        public void SetAttributes(Collection<HtmlAttribute> attributes)
        {
            Attributes = attributes ?? new Collection<HtmlAttribute>();
        }

        public virtual HtmlElement WithInnerText(string innerText)
        {
            SetInnerText(innerText);
            return this;
        }

        public void SetInnerText(string innerText)
        {
            InnerText = innerText;
        }

        public string Serialize() => Serialize(HtmlSerializeType.PrettyPrint);

        public string Serialize(HtmlSerializeType serializeType) => Serialize(serializeType, 0);

        public virtual string Serialize(HtmlSerializeType serializeType, int depth)
        {
            var openingTag = SerializeOpenTag();
            if (serializeType == HtmlSerializeType.PrettyPrint)
            {
                if ((string.IsNullOrEmpty(InnerText) && Children.Count > 0) || IsVoid)
                {
                    openingTag += "\r";
                }
            }

            if (IsVoid)
            {
                return openingTag;
            }

            var closingTag = "</" + ElementTag + ">";
            if (depth > MaximumIndentDepth)
            {
                depth = MaximumIndentDepth;
                closingTag = "\t" + closingTag;
            }

            var shouldIndent = depth >= MinimumIndentDepth && depth <= MaximumIndentDepth;

            if (shouldIndent)
            {
                for (var counter = 0; counter < depth - 1; counter++)
                {
                    closingTag = "\t" + closingTag;
                }
            }

            var innerText = InnerText ?? "";
            foreach (var child in Children)
            {
                if (shouldIndent)
                {
                    for (var counter = 0; counter < depth; counter++)
                    {
                        innerText += "\t";
                    }
                }
                if (!string.IsNullOrWhiteSpace(child.InnerText) && child.Children.Count == 0)
                {
                    innerText += child.Serialize(serializeType, 0);
                }
                else
                {
                    innerText += child.Serialize(serializeType, depth + 1);
                }
            }

            var html = openingTag + innerText + closingTag;
            if (serializeType == HtmlSerializeType.PrettyPrint)
            {
                html += "\r";
            }
            return html;
        }

        private string SerializeOpenTag()
        {
            var tagOpener = "<" + ElementTag;
            var tagCloser = ">";

            if (IsVoid)
            {
                tagCloser = "/>";
            }

            if (Attributes == null || Attributes.Count == 0)
            {
                return tagOpener + tagCloser;
            }

            var attributes = "";
            foreach (var attribute in Attributes)
            {
                attributes += " " + attribute.Serialize();
            }

            return tagOpener + attributes + tagCloser;
        }

        public override string ToString() => SerializeOpenTag();
    }

    public static class HtmlElementExtensions
    {
        public static T WithElement<T>(this T self, HtmlElement element) where T : HtmlElement
        {
            self.Add(element);
            return self;
        }

        public static T WithElements<T>(this T self, IEnumerable<HtmlElement> elements) where T : HtmlElement
        {
            self.Add(elements);
            return self;
        }

        public static T WithAttribute<T>(this T self, HtmlAttribute attribute) where T : HtmlElement
        {
            self.Add(attribute);
            return self;
        }

        public static T WithAttributes<T>(this T self, IEnumerable<HtmlAttribute> attributes) where T : HtmlElement
        {
            self.Add(attributes);
            return self;
        }

        public static T WithInnerText<T>(this T self, string innerText) where T : HtmlElement
        {
            self.SetInnerText(innerText);
            return self;
        }

        public static T WithAccessKey<T>(this T self, string value) where T : HtmlElement => self.WithAttribute(Attribute.AccessKey(value));

        public static T WithClass<T>(this T self, string value) where T : HtmlElement => self.WithAttribute(Attribute.Class(value));

        public static T WithContentEditable<T>(this T self, string value) where T : HtmlElement => self.WithAttribute(Attribute.ContentEditable(value));

        public static T WithContextMenu<T>(this T self, string value) where T : HtmlElement => self.WithAttribute(Attribute.ContextMenu(value));

        public static T WithDir<T>(this T self, string value) where T : HtmlElement => self.WithAttribute(Attribute.Dir(value));

        public static T WithHidden<T>(this T self, string value) where T : HtmlElement => self.WithAttribute(Attribute.Hidden(value));

        public static T WithId<T>(this T self, string value) where T : HtmlElement => self.WithAttribute(Attribute.Id(value));

        public static T WithLang<T>(this T self, string value) where T : HtmlElement => self.WithAttribute(Attribute.Lang(value));

        public static T WithSpellCheck<T>(this T self, string value) where T : HtmlElement => self.WithAttribute(Attribute.SpellCheck(value));

        public static T WithStyle<T>(this T self, string value) where T : HtmlElement => self.WithAttribute(Attribute.Style(value));

        public static T WithTabIndex<T>(this T self, string value) where T : HtmlElement => self.WithAttribute(Attribute.TabIndex(value));
    }
}
