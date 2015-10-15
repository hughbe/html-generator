using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace HtmlGenerator
{
    public class HtmlElement
    {
        protected HtmlElement(string elementTag) : this(elementTag, false)
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

        public string Content { get; private set; }

        public HtmlElement Parent { get; internal set; }
        public Collection<HtmlElement> Children { get; private set; } = new Collection<HtmlElement>();

        public Collection<HtmlAttribute> Attributes { get; private set; } = new Collection<HtmlAttribute>();

        public HtmlElement WithChild(HtmlElement child)
        {
            AddChild(child);
            return this;
        }

        public HtmlElement WithChildren(Collection<HtmlElement> children)
        {
            AddChildren(children);
            return this;
        }

        public T InsertChild<T>(int index, T element) where T : HtmlElement
        {
            if (element == null)
            {
                throw new ArgumentNullException(nameof(element));
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

        public HtmlElement WithClass(string className)
        {
            SetClass(className);
            return this;
        }

        public HtmlElement WithId(string idName)
        {
            SetId(idName);
            return this;
        }

        public HtmlElement WithAttribute(HtmlAttribute attribute)
        {
            AddAttribute(attribute);
            return this;
        }

        public HtmlElement WithAttributes(Collection<HtmlAttribute> attributes)
        {
            SetAttributes(attributes);
            return this;
        }

        public void SetClass(string className)
        {
            AddAttribute(Attribute.Class(className));
        }

        public void SetId(string idName)
        {
            AddAttribute(Attribute.Id(idName));
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

        public HtmlElement WithContent(string content)
        {
            SetContent(content);
            return this;
        }

        public void SetContent(string content)
        {
            Content = content;
        }

        private int minimumIndentDepth = 1;
        private int maximumIndentDepth = 7;

        public int MinimumIndentDepth
        {
            get { return minimumIndentDepth; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The minimum indent depth cannot be negative", nameof(value));
                }
                if (value > maximumIndentDepth)
                {
                    throw new ArgumentException("The minimum indent depth cannot be larger than the maximum indent depth", nameof(value));
                }
                minimumIndentDepth = value;
            }
        }

        public int MaximumIndentDepth
        {
            get { return maximumIndentDepth; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The maximum indent depth cannot be negative", nameof(value));
                }
                if (value < minimumIndentDepth)
                {
                    throw new ArgumentException("The maximum indent depth cannot be less than the minimum indent depth", nameof(value));
                }
                maximumIndentDepth = value;
            }
        }

        public string Serialize() => Serialize(HtmlSerializeType.PrettyPrint);

        public virtual string Serialize(HtmlSerializeType serializeType) => Serialize(serializeType, 0);

        private string Serialize(HtmlSerializeType serializeType, int depth)
        {
            var openingTag = SerializeOpenTag();
            if (serializeType == HtmlSerializeType.PrettyPrint)
            {
                if ((string.IsNullOrEmpty(Content) && Children.Count > 0) || IsVoid)
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
                for (int counter = 0; counter < depth - 1; counter++)
                {
                    closingTag = "\t" + closingTag;
                }
            }

            var content = Content ?? "";
            foreach (var child in Children)
            {
                if (shouldIndent)
                {
                    for (int counter = 0; counter < depth; counter++)
                    {
                        content += "\t";
                    }
                }
                if (!string.IsNullOrWhiteSpace(child.Content) || child.Children.Count == 0)
                {
                    content += child.Serialize(serializeType, 0);
                }
                else
                {
                    content += child.Serialize(serializeType, depth + 1);
                }
            }

            var html = openingTag + content + closingTag;
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
}
