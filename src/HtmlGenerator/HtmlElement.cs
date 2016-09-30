using System;
using System.Collections.Generic;
using System.Text;

namespace HtmlGenerator
{
    public class HtmlElement : SerializableHtmlObject
    {
        private LinkedList<HtmlAttribute> _attributes = new LinkedList<HtmlAttribute>();
        private LinkedList<HtmlElement> _elements = new LinkedList<HtmlElement>();
        
        public HtmlElement(string tag)
        {
            Requires.NotNullOrWhitespace(tag, nameof(tag));
            Tag = tag;
        }

        public HtmlElement(string tag, bool isVoid) : this(tag)
        {
            IsVoid = isVoid;
        }

        public HtmlElement(string tag, string innerText) : this(tag)
        {
            InnerText = innerText;
        }

        public HtmlElement(string tag, string innerText, params HtmlObject[] content) : this(tag, innerText)
        {
            Add(content);
        }

        public HtmlElement(string tag, params HtmlObject[] content) : this(tag)
        {
            Add(content);
        }

        public void Add(HtmlObject content)
        {
            Requires.NotNull(content, nameof(content));

            if (content is HtmlAttribute)
            {
                Add((HtmlAttribute)content);
            }
            else if (content is HtmlElement)
            {
                Add((HtmlElement)content);
            }
            else
            {
                throw new ArgumentException("Content must be an HtmlElement or HtmlAttribute", nameof(content));
            }
        }

        public void Add(HtmlElement element)
        {
            Requires.NotNull(element, nameof(element));
            if (element == this)
            {
                throw new InvalidOperationException("Cannot add an object as a child to itself.");
            }
            if (element.Parent == this)
            {
                throw new InvalidOperationException("Cannot have a duplicate element or attribute");
            }
            ThrowIfVoid();
            AddElement(element);
        }

<<<<<<< HEAD
        public T InsertChild<T>(int index, T element) where T : HtmlElement
=======
        public void Add(HtmlAttribute attribute)
        {
            Requires.NotNull(attribute, nameof(attribute));
            if (attribute.Parent == this)
            {
                throw new InvalidOperationException("Cannot have a duplicate element or attribute");
            }
            AddAttribute(attribute);
        }
        
        public void Add(params HtmlObject[] content) => Add((IEnumerable<HtmlObject>)content);

        public void Add(IEnumerable<HtmlObject> content)
        {
            Requires.NotNull(content, nameof(content));
            ThrowIfVoid();
            foreach (HtmlObject obj in content)
            {
                Add(obj);
            }
        }

        public void Add(params HtmlElement[] elements) => Add((IEnumerable<HtmlElement>)elements);

        public void Add(IEnumerable<HtmlElement> elements)
        {
            Requires.NotNull(elements, nameof(elements));
            ThrowIfVoid();

            foreach (HtmlElement obj in elements)
            {
                Add(obj);
            }
        }

        public void Add(params HtmlAttribute[] attributes) => Add((IEnumerable<HtmlAttribute>)attributes);

        public void Add(IEnumerable<HtmlAttribute> attributes)
        {
            Requires.NotNull(attributes, nameof(attributes));

            foreach (HtmlAttribute obj in attributes)
            {
                Add(obj);
            }
        }

        public void ReplaceAll(params HtmlObject[] content) => ReplaceAll((IEnumerable<HtmlObject>)content);

        public void ReplaceAll(IEnumerable<HtmlObject> content)
        {
            Requires.NotNull(content, nameof(content));

            _elements.Clear();
            _attributes.Clear();
            foreach (HtmlObject obj in content)
            {
                Add(obj);
            }
        }

        public void ReplaceAttributes(params HtmlAttribute[] attributes) => ReplaceAttributes((IEnumerable<HtmlAttribute>)attributes);

        public void ReplaceAttributes(IEnumerable<HtmlAttribute> attributes)
        {
            Requires.NotNull(attributes, nameof(attributes));
            ThrowIfVoid();

            _attributes.Clear();
            foreach (HtmlAttribute attribute in attributes)
            {
                Add(attribute);
            }
        }

        public void ReplaceElements(params HtmlElement[] elements) => ReplaceElements((IEnumerable<HtmlElement>)elements);

        public void ReplaceElements(IEnumerable<HtmlElement> elements)
        {
            Requires.NotNull(elements, nameof(elements));
            ThrowIfVoid();

            _elements.Clear();
            foreach (HtmlElement element in elements)
            {
                Add(element);
            }
        }
        
        private void AddElement(HtmlElement element)
        {
            element.Parent = this;
            _elements.AddLast(element);
        }

        private void AddAttribute(HtmlAttribute attribute)
        {
            attribute.Parent = this;
            _attributes.AddLast(attribute);
        }

        public void RemoveAll()
        {
            ThrowIfVoid();
            _elements.Clear();
            _attributes.Clear();
        }

        public void RemoveElements()
        {
            ThrowIfVoid();
            _elements.Clear();
        }

        public void RemoveAttributes()
        {
            ThrowIfVoid();
            _attributes.Clear();
        }

        public string Tag { get; }
        public bool IsVoid { get; }
        public string InnerText { get; private set; }

        public void SetInnerText(string value)
        {
            ThrowIfVoid();
            InnerText = value;
        }

        public HtmlElement FirstElement => _elements.First?.Value;
        public HtmlElement LastElement => _elements.Last?.Value;

        public bool HasElements => _elements.Count != 0;

        public IEnumerable<HtmlElement> Elements() => Elements(null);

        public IEnumerable<HtmlElement> Elements(string tag)
        {
            bool isDefaultTag = string.IsNullOrEmpty(tag);

            LinkedListNode<HtmlElement> elementNode = _elements.First;
            while (elementNode != null)
            {
                HtmlElement element = elementNode.Value;
                if (isDefaultTag || element.Tag == tag)
                {
                    yield return element;
                }
                elementNode = elementNode.Next;
            }
        }

        public HtmlAttribute FirstAttribute => _attributes.First?.Value;
        public HtmlAttribute LastAttribute => _attributes.Last?.Value;

        public bool HasAttributes => _attributes.Count != 0;

        public IEnumerable<HtmlAttribute> Attributes()
        {
            LinkedListNode<HtmlAttribute> attributeNode = _attributes.First;
            while (attributeNode != null)
            {
                yield return attributeNode.Value;
                attributeNode = attributeNode.Next;
            }
        }

        public bool IsEmpty => !HasElements && !HasAttributes;

        public IEnumerable<HtmlObject> ElementsAndAttributes()
        {
            foreach (HtmlElement element in Elements())
            {
                yield return element;
            }
            foreach (HtmlAttribute attribute in Attributes())
            {
                yield return attribute;
            }
        }

        public bool TryGetElement(string tag, out HtmlElement element)
        {
            Requires.NotNullOrWhitespace(tag, nameof(tag));

            LinkedListNode<HtmlElement> elementNode = _elements.First;
            while (elementNode != null)
            {
                HtmlElement nodeElement = elementNode.Value;
                if (nodeElement.Tag == tag)
                {
                    element = nodeElement;
                    return true;
                }
                elementNode = elementNode.Next;
            }

            element = null;
            return false;
        }

        public bool TryGetAttribute(string name, out HtmlAttribute attribute)
        {
            Requires.NotNullOrWhitespace(name, nameof(name));

            LinkedListNode<HtmlAttribute> attributeNode = _attributes.First;
            while (attributeNode != null)
            {
                HtmlAttribute nodeAttribute = attributeNode.Value;
                if (nodeAttribute.Name == name)
                {
                    attribute = nodeAttribute;
                    return true;
                }
                attributeNode = attributeNode.Next;
            }

            attribute = null;
            return false;
        }

        private int _minimumIndentDepth = 1;
        public int MinimumIndentDepth
        {
            get { return _minimumIndentDepth; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "The minimum indent depth cannot be negative");
                }
                if (value > _maximumIndentDepth)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "The minimum indent depth cannot be larger than the maximum indent depth");
                }

                _minimumIndentDepth = value;
            }
        }

        private int _maximumIndentDepth = 9;
        public int MaximumIndentDepth
        {
            get { return _maximumIndentDepth; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "The maximum indent depth cannot be negative");
                }
                if (value < _minimumIndentDepth)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "The maximum indent depth cannot be less than the minimum indent depth");
                }

                _maximumIndentDepth = value;
            }
        }

        internal override void Serialize(StringBuilder builder, HtmlSerializeOptions serializeType)
        {
            Serialize(builder, serializeType, 0);
        }

        private void Serialize(StringBuilder stringBuilder, HtmlSerializeOptions serializeType, int depth)
        {
            SerializeOpenTag(stringBuilder, serializeType);
            if (IsVoid)
            {
                return;
            }
            
            if (InnerText != null)
            {
                stringBuilder.Append(InnerText);
            }
            var shouldIndent = depth >= MinimumIndentDepth && depth <= MaximumIndentDepth;
            foreach (var child in _elements)
            {
                if (serializeType != HtmlSerializeOptions.NoFormatting)
                {
                    stringBuilder.AppendLine();
                }
                if (shouldIndent)
                {
                    stringBuilder.Append(' ', depth * 2);
                }
                if (!string.IsNullOrWhiteSpace(child.InnerText) && child._elements.Count == 0)
                {
                    child.Serialize(stringBuilder, serializeType, depth);
                }
                else
                {
                    child.Serialize(stringBuilder, serializeType, depth + 1);
                }
            }
            if (_elements._count > 0 && serializeType != HtmlSerializeOptions.NoFormatting)
            {
                stringBuilder.AppendLine();
            }

            if (depth > MaximumIndentDepth)
            {
                depth = MaximumIndentDepth;
                stringBuilder.Append(' ', 2);
            }

            if (shouldIndent && depth - 2 >= 0)
            {
                stringBuilder.Append(' ', (depth - 2) * 2);
            }
            stringBuilder.Append("</");
            stringBuilder.Append(Tag);
            stringBuilder.Append('>');
        }

        private void SerializeOpenTag(StringBuilder stringBuilder, HtmlSerializeOptions serializeType)
        {
            stringBuilder.Append('<');
            stringBuilder.Append(Tag);

            if (_attributes.Count != 0)
            {
                foreach (var attribute in Attributes())
                {
                    stringBuilder.Append(' ');
                    attribute.Serialize(stringBuilder, serializeType);
                }
            }
            stringBuilder.Append(IsVoid ? " />" : ">");
        }

        private void ThrowIfVoid()
        {
            if (IsVoid)
            {
                throw new InvalidOperationException("Cannot set inner text for a void element");
            }
        }
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
