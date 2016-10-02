using System;
using System.Collections.Generic;
using System.Text;

namespace HtmlGenerator
{
    public class HtmlElement : SerializableHtmlObject
    {
        private HtmlObjectLinkedList<HtmlAttribute> _attributes = new HtmlObjectLinkedList<HtmlAttribute>();
        private HtmlObjectLinkedList<HtmlElement> _elements = new HtmlObjectLinkedList<HtmlElement>();
        
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

        public HtmlElement FirstElement => _elements._first;
        public HtmlElement LastElement => _elements._last;

        public bool HasElements => _elements._count != 0;

        public IEnumerable<HtmlElement> Elements() => Elements(null);

        public IEnumerable<HtmlElement> Elements(string tag)
        {
            bool isDefaultTag = string.IsNullOrEmpty(tag);

            HtmlElement element = _elements._first;
            while (element != null)
            {
                if (isDefaultTag || element.Tag == tag)
                {
                    yield return element;
                }
                element = (HtmlElement)element._next;
            }
        }

        public HtmlAttribute FirstAttribute => _attributes._first;
        public HtmlAttribute LastAttribute => _attributes._last;

        public bool HasAttributes => _attributes._count != 0;

        public IEnumerable<HtmlAttribute> Attributes()
        {
            HtmlAttribute attributeNode = _attributes._first;
            while (attributeNode != null)
            {
                yield return attributeNode;
                attributeNode = (HtmlAttribute)attributeNode._next;
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

            HtmlElement current = _elements._first;
            while (current != null)
            {
                if (current.Tag == tag)
                {
                    element = current;
                    return true;
                }
                current = (HtmlElement)current._next;
            }

            element = null;
            return false;
        }

        public bool TryGetAttribute(string name, out HtmlAttribute attribute)
        {
            Requires.NotNullOrWhitespace(name, nameof(name));

            HtmlAttribute current = _attributes._first;
            while (current != null)
            {
                if (current.Name == name)
                {
                    attribute = current;
                    return true;
                }
                current = (HtmlAttribute)current._next;
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
                if (!string.IsNullOrWhiteSpace(child.InnerText) && child._elements._count == 0)
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

            if (_attributes._count != 0)
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

        public virtual HtmlElement WithElement(HtmlElement element)
        {
            Add(element);
            return this;
        }

        public virtual HtmlElement WithElements(IEnumerable<HtmlElement> elements)
        {
            Add(elements);
            return this;
        }

        public virtual HtmlElement WithAttribute(HtmlAttribute attribute)
        {
            Add(attribute);
            return this;
        }

        public virtual HtmlElement WithAttributes(IEnumerable<HtmlAttribute> attributes)
        {
            Add(attributes);
            return this;
        }

        public virtual HtmlElement WithInnerText(string innerText)
        {
            SetInnerText(innerText);
            return this;
        }
    }
}
