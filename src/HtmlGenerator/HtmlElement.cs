using System;
using System.Collections.Generic;
using System.Text;
using HtmlGenerator.Extensions;

namespace HtmlGenerator
{
    public class HtmlElement : SerializableHtmlObject, IEquatable<HtmlElement>
    {
        private readonly HtmlObjectLinkedList<HtmlElement> _elements = new HtmlObjectLinkedList<HtmlElement>();
        private HtmlObjectLinkedList<HtmlAttribute> _attributes = new HtmlObjectLinkedList<HtmlAttribute>();

        private HtmlElement() { }

        public HtmlElement(string tag)
        {
            Requires.NotNullOrWhitespace(tag, nameof(tag));
            Tag = tag.ToAsciiLower();
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

        public override HtmlObjectType ObjectType => HtmlObjectType.Element;

        public void Add(HtmlObject content)
        {
            Requires.NotNull(content, nameof(content));
            if (ReferenceEquals(this, content.Parent))
            {
                throw new InvalidOperationException("Cannot have a duplicate element or attribute");
            }

            if (content.ObjectType == HtmlObjectType.Attribute)
            {
                HtmlAttribute attribute = (HtmlAttribute)content;
                if (HasAttribute(attribute.Name))
                {
                    throw new InvalidOperationException("Cannot have a duplicate element or attribute.");
                }
                AddAttribute(attribute);
            }
            else
            {
                if (ReferenceEquals(this, content))
                {
                    throw new InvalidOperationException("Cannot add an object as a child to itself.");
                }
                ThrowIfVoid();
                AddElementAfter(this, _elements._last, (HtmlElement)content);
            }
        }

        public void Add(params HtmlObject[] content) => Add((IEnumerable<HtmlObject>)content);

        public void Add(IEnumerable<HtmlObject> content)
        {
            Requires.NotNull(content, nameof(content));
            foreach (HtmlObject obj in content)
            {
                Add(obj);
            }
        }

        private void AddAttribute(HtmlAttribute attribute)
        {
            attribute.RemoveFromParent();
            attribute.Parent = this;
            _attributes.AddAfter(_attributes._last, attribute);
        }

        public void AddFirst(HtmlObject content)
        {
            Requires.NotNull(content, nameof(content));
            if (ReferenceEquals(this, content.Parent))
            {
                throw new InvalidOperationException("Cannot have a duplicate element or attribute.");
            }

            if (content.ObjectType == HtmlObjectType.Element)
            {
                if (ReferenceEquals(this, content))
                {
                    throw new InvalidOperationException("Cannot add an object as a child to itself.");
                }
                ThrowIfVoid();
                AddElementBefore(this, _elements._first, (HtmlElement)content);
            }
            else
            {
                HtmlAttribute attribute = (HtmlAttribute)content;
                if (HasAttribute(attribute.Name))
                {
                    throw new InvalidOperationException("Cannot have a duplicate element or attribute.");
                }
                AddAttributeFirst(attribute);
            }
        }

        public void AddFirst(params HtmlObject[] content) => AddFirst((IEnumerable<HtmlObject>)content);

        public void AddFirst(IEnumerable<HtmlObject> content)
        {
            Requires.NotNull(content, nameof(content));
            foreach (HtmlObject obj in content)
            {
                AddFirst(obj);
            }
        }

        private void AddAttributeFirst(HtmlAttribute attribute)
        {
            attribute.RemoveFromParent();
            attribute.Parent = this;
            _attributes.AddBefore(_attributes._first, attribute);
        }

        public void AddAfterSelf(HtmlElement content)
        {
            Requires.NotNull(content, nameof(content));

            if (ReferenceEquals(this, content))
            {
                throw new InvalidOperationException("Cannot add an object as a child to itself.");
            }
            if (ReferenceEquals(this, content.Parent))
            {
                throw new InvalidOperationException("Element has already been added to this element.");
            }
            if (Parent == null)
            {
                throw new InvalidOperationException("This element does not have a parent.");
            }
            AddElementAfter(Parent, this, content);
        }

        public void AddAfterSelf(params HtmlElement[] content) => AddAfterSelf((IEnumerable<HtmlElement>)content);

        public void AddAfterSelf(IEnumerable<HtmlElement> content)
        {
            Requires.NotNull(content, nameof(content));

            HtmlElement current = this;
            foreach (HtmlElement element in content)
            {
                current.AddAfterSelf(element);
                current = element;
            }
        }

        public void AddBeforeSelf(HtmlElement content)
        {
            Requires.NotNull(content, nameof(content));

            if (ReferenceEquals(this, content))
            {
                throw new InvalidOperationException("Cannot add an object as a child to itself.");
            }
            if (ReferenceEquals(this, content.Parent))
            {
                throw new InvalidOperationException("Element has already been added to this element.");
            }
            if (Parent == null)
            {
                throw new InvalidOperationException("This element does not have a parent.");
            }
            AddElementBefore(Parent, this, content);
        }

        public void AddBeforeSelf(params HtmlElement[] content) => AddBeforeSelf((IEnumerable<HtmlElement>)content);

        public void AddBeforeSelf(IEnumerable<HtmlElement> content)
        {
            Requires.NotNull(content, nameof(content));

            HtmlElement current = this;
            foreach (HtmlElement element in content)
            {
                current.AddBeforeSelf(element);
                current = element;
            }
        }

        private static void AddElementAfter(HtmlElement parent, HtmlElement previousNode, HtmlElement element)
        {
            element.RemoveFromParent();
            element.Parent = parent;
            parent._elements.AddAfter(previousNode, element);
        }

        private static void AddElementBefore(HtmlElement parent, HtmlElement nextNode, HtmlElement element)
        {
            element.RemoveFromParent();
            element.Parent = parent;
            parent._elements.AddBefore(nextNode, element);
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

        public void RemoveFromParent()
        {
            if (Parent == null)
            {
                return;
            }
            Parent._elements.Remove(this);
            Parent = null;
        }

        internal void RemoveAttribute(HtmlAttribute attribute)
        {
            _attributes.Remove(attribute);
            attribute.Parent = null;
        }
        public string Tag { get; private set; }
        public bool IsVoid { get; private set; }

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
                if (isDefaultTag || StringExtensions.EqualsAsciiOrdinalIgnoreCase(element.Tag, tag))
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

        public bool HasElement(string tag)
        {
            Requires.NotNullOrWhitespace(tag, nameof(tag));

            HtmlElement current = _elements._first;
            while (current != null)
            {
                if (StringExtensions.EqualsAsciiOrdinalIgnoreCase(current.Tag, tag))
                {
                    return true;
                }
                current = (HtmlElement)current._next;
            }
            return false;
        }

        public bool HasAttribute(string name)
        {
            Requires.NotNullOrWhitespace(name, nameof(name));

            HtmlAttribute current = _attributes._first;
            while (current != null)
            {
                if (StringExtensions.EqualsAsciiOrdinalIgnoreCase(current.Name, name))
                {
                    return true;
                }
                current = (HtmlAttribute)current._next;
            }
            return false;
        }

        public bool TryGetElement(string tag, out HtmlElement element)
        {
            Requires.NotNullOrWhitespace(tag, nameof(tag));

            HtmlElement current = _elements._first;
            while (current != null)
            {
                if (StringExtensions.EqualsAsciiOrdinalIgnoreCase(current.Tag, tag))
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
                if (StringExtensions.EqualsAsciiOrdinalIgnoreCase(current.Name, name))
                {
                    attribute = current;
                    return true;
                }
                current = (HtmlAttribute)current._next;
            }

            attribute = null;
            return false;
        }

        public HtmlElement NextElement => (HtmlElement)_next;
        public HtmlElement PreviousElement => (HtmlElement)_previous;

        public IEnumerable<HtmlElement> NextElements() => NextElements(null);

        public IEnumerable<HtmlElement> NextElements(string tag)
        {
            bool isDefaultTag = string.IsNullOrEmpty(tag);

            HtmlElement nextElement = (HtmlElement)_next;
            while (nextElement != null)
            {
                if (isDefaultTag || StringExtensions.EqualsAsciiOrdinalIgnoreCase(nextElement.Tag, tag))
                {
                    yield return nextElement;
                }
                nextElement = (HtmlElement)nextElement._next;
            }
        }

        public IEnumerable<HtmlElement> PreviousElements() => PreviousElements(null);

        public IEnumerable<HtmlElement> PreviousElements(string tag)
        {
            bool isDefaultTag = string.IsNullOrEmpty(tag);

            HtmlElement previousElement = (HtmlElement)_previous;
            while (previousElement != null)
            {
                if (isDefaultTag || StringExtensions.EqualsAsciiOrdinalIgnoreCase(previousElement.Tag, tag))
                {
                    yield return previousElement;
                }
                previousElement = (HtmlElement)previousElement._previous;
            }
        }

        public IEnumerable<HtmlElement> Descendants() => Descendants(null);

        public IEnumerable<HtmlElement> Descendants(string tag)
        {
            bool isDefaultTag = string.IsNullOrEmpty(tag);

            HtmlElement element = _elements._first;
            while (element != null)
            {
                if (isDefaultTag || StringExtensions.EqualsAsciiOrdinalIgnoreCase(element.Tag, tag))
                {
                    yield return element;
                }
                foreach (HtmlElement child in element.Descendants(tag))
                {
                    yield return child;
                }
                element = (HtmlElement)element._next;
            }
        }

        public IEnumerable<HtmlElement> DescendantsAndSelf() => DescendantsAndSelf(null);

        public IEnumerable<HtmlElement> DescendantsAndSelf(string tag)
        {
            bool isDefaultTag = string.IsNullOrEmpty(tag);

            if (isDefaultTag || StringExtensions.EqualsAsciiOrdinalIgnoreCase(Tag, tag))
            {
                yield return this;
            }
            foreach (HtmlElement element in Descendants(tag))
            {
                yield return element;
            }
        }

        public IEnumerable<HtmlElement> Ancestors() => Ancestors(null);

        public IEnumerable<HtmlElement> Ancestors(string tag)
        {
            bool isDefaultTag = string.IsNullOrEmpty(tag);

            HtmlElement parent = Parent;
            while (parent != null)
            {
                if (isDefaultTag || StringExtensions.EqualsAsciiOrdinalIgnoreCase(parent.Tag, tag))
                {
                    yield return parent;
                }
                parent = parent.Parent;
            }
        }

        public IEnumerable<HtmlElement> AncestorsAndSelf() => AncestorsAndSelf(null);

        public IEnumerable<HtmlElement> AncestorsAndSelf(string tag)
        {
            bool isDefaultTag = string.IsNullOrEmpty(tag);

            if (isDefaultTag || StringExtensions.EqualsAsciiOrdinalIgnoreCase(Tag, tag))
            {
                yield return this;
            }
            foreach (HtmlElement element in Ancestors(tag))
            {
                yield return element;
            }
        }

        public override int GetHashCode() => InnerText == null ? Tag.GetHashCode() : Tag.GetHashCode() ^ InnerText.GetHashCode();

        public override bool Equals(object obj) => Equals(obj as HtmlElement);

        public bool Equals(HtmlElement element)
        {
            if (element == null)
            {
                return false;
            }
            if (Tag != element.Tag || InnerText != element.InnerText || IsVoid != element.IsVoid)
            {
                return false;
            }
            if (_elements._count != element._elements._count || _attributes._count != element._attributes._count)
            {
                return false;
            }
            if (_elements._count > 0)
            {
                IEnumerator<HtmlElement> thisElements = Elements().GetEnumerator();
                IEnumerator<HtmlElement> otherElements = element.Elements().GetEnumerator();
                while (thisElements.MoveNext() && otherElements.MoveNext())
                {
                    if (!thisElements.Current.Equals(otherElements.Current))
                    {
                        return false;
                    }
                }
            }
            if (_attributes._count > 0)
            {
                IEnumerator<HtmlAttribute> thisAttributes = Attributes().GetEnumerator();
                IEnumerator<HtmlAttribute> otherAttributes = element.Attributes().GetEnumerator();
                while (thisAttributes.MoveNext() && otherAttributes.MoveNext())
                {
                    if (!thisAttributes.Current.Equals(otherAttributes.Current))
                    {
                        return false;
                    }
                }
            }

            return true;
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

        public static HtmlElement Parse(string text)
        {
            HtmlElement element;
            if (!TryParse(text, out element))
            {
                return null;
            }
            return element;
        }

        public static bool TryParse(string text, out HtmlElement element)
        {
            element = null;
            if (text == null || text.Length == 0)
            {
                return false;
            }

            Parser parser = new Parser(text, isDocument: false);
            if (parser.Parse())
            {
                element = parser.rootElement;
                return true;
            }
            return false;
        }

        protected internal struct Parser
        {
            public Parser(string text, bool isDocument)
            {
                this.text = text;
                currentIndex = -1;
                currentChar = char.MinValue;
                parsingDocument = isDocument;
                currentElement = null;
                rootElement = null;
                doctype = null;
            }

            private string text;
            private int currentIndex;
            private char currentChar;
            private bool parsingDocument;

            public HtmlElement rootElement;
            private HtmlElement currentElement;

            private HtmlDoctype doctype;

            public string Remaining => text.Substring(currentIndex);

            public bool TryParseOpeningTag()
            {
                if (currentChar != '<')
                {
                    // No opening tag, e.g. "abc"
                    return false;
                }
                ReadAndSkipWhitespace();
                if (currentChar == '/')
                {
                    if (!TryParseClosingTag())
                    {
                        return false;
                    }
                    if (currentIndex + 1 < text.Length)
                    {
                        // Got more to parse?
                        return TryParseOpeningTag();
                    }
                    // Finished parsing
                    return true;
                }
                else if (currentChar == '!')
                {
                    if (!TryParseComment())
                    {
                        // Couldn't parse the comment
                        return false;
                    }
                    if (currentIndex < text.Length)
                    {
                        // Got more to parse?
                        return TryParseOpeningTag();
                    }
                    else if (rootElement == null)
                    {
                        // Doctype on its own
                        rootElement = doctype;
                    }
                    // Finished parsing
                    return true;
                }
                if (!IsLetter(currentChar))
                {
                    // No valid tag, e.g. "<>", "<1"
                    return false;
                }

                int tagStartIndex = currentIndex;
                int tagEndIndex = -1;
                bool foundTagEnd = false;
                while (ReadNext())
                {
                    foundTagEnd = currentChar == '/' || currentChar == '>';
                    if (foundTagEnd || char.IsWhiteSpace(currentChar))
                    {
                        tagEndIndex = currentIndex - 1;
                        break;
                    }
                }
                if (tagEndIndex == -1)
                {
                    // No end of tag, e.g. "<abc", "<abc "
                    return false;
                }

                string tag = text.ToAsciiLower(tagStartIndex, tagEndIndex - tagStartIndex + 1);
                HtmlObjectLinkedList<HtmlAttribute> attributes = null;
                if (!foundTagEnd && !TryParseAttributes(out attributes))
                {
                    // Could not parse attributes
                    return false;
                }

                bool isVoid = false;
                if (currentChar == '/')
                {
                    // Void element?
                    ReadAndSkipWhitespace();
                    if (currentChar != '>')
                    {
                        // No end of void tag, e.g. "<abc/", "<abc/a>"
                        return false;
                    }
                    isVoid = true;
                    ReadAndSkipWhitespace();
                }

                HtmlElement element;
                if (rootElement == null)
                {
                    if (tag == "html" && !isVoid)
                    {
                        element = new HtmlDocument() { Doctype = doctype };
                    }
                    else if (parsingDocument)
                    {
                        // First tag of a document has to be an open html tag
                        return false;
                    }
                    else
                    {
                        element = new HtmlElement(tag, isVoid);
                    }
                }
                else
                {
                    element = new HtmlElement(tag, isVoid);
                }
                if (attributes != null)
                {
                    element._attributes = attributes;
                }
                SetParsing(element);

                if (!element.IsVoid && !TryParseInnerText())
                {
                    return false;
                }
                if (currentIndex + 1 < text.Length || !element.IsVoid)
                {
                    return TryParseOpeningTag();
                }

                return true;
            }

            private bool TryParseAttributes(out HtmlObjectLinkedList<HtmlAttribute> attributes)
            {
                attributes = new HtmlObjectLinkedList<HtmlAttribute>();
                ReadAndSkipWhitespace();

                while (currentChar != '/' && currentChar != '>')
                {
                    HtmlAttribute attribute;
                    if (!TryParseAttribute(out attribute))
                    {
                        // Could not parse an attribute
                        return false;
                    }
                    attributes.AddAfter(attributes._last, attribute);
                }
                return true;
            }

            private bool TryParseAttributeName(out string name, out bool isExtendedAttribute, out bool isFinalAttribute)
            {
                name = null;
                isExtendedAttribute = false;
                isFinalAttribute = false;

                int nameStartIndex = currentIndex;
                int nameEndIndex = -1;
                bool foundWhitespace = false;
                while (ReadNext())
                {
                    if (!foundWhitespace && char.IsWhiteSpace(currentChar))
                    {
                        if (nameEndIndex == -1)
                        {
                            nameEndIndex = currentIndex - 1;
                        }
                        ReadAndSkipWhitespace();
                        foundWhitespace = true;
                    }
                    if (currentChar == '/' || currentChar == '>')
                    {
                        if (nameEndIndex == -1)
                        {
                            nameEndIndex = currentIndex - 1;
                        }
                        isFinalAttribute = true;
                        break;
                    }
                    else if (currentChar == '=')
                    {
                        if (nameEndIndex == -1)
                        {
                            nameEndIndex = currentIndex - 1;
                        }
                        isExtendedAttribute = true;
                        ReadAndSkipWhitespace();
                        break;
                    }
                    else if (nameEndIndex != -1)
                    {
                        // Found another attribute
                        break;
                    }
                }
                if (nameEndIndex == -1)
                {
                    return false;
                }
                int nameLength = nameEndIndex - nameStartIndex + 1;
                name = text.ToAsciiLower(nameStartIndex, nameLength);
                return true;
            }

            private bool TryParseAttribute(out HtmlAttribute attribute)
            {
                attribute = null;
                string name;
                bool isExtendedAttribute;
                bool isFinalAttribute;

                if (!TryParseAttributeName(out name, out isExtendedAttribute, out isFinalAttribute))
                {
                    return false;
                }
                if (isFinalAttribute || !isExtendedAttribute)
                {
                    attribute = new HtmlAttribute(name);
                    return true;
                }
                bool singleDelimeted = currentChar == '\'';
                bool doubleDelimeted = currentChar == '"';
                bool notDelimited = IsLetter(currentChar);
                if (!singleDelimeted && !doubleDelimeted && !notDelimited)
                {
                    // Invalid character after equals, e.g. "<abc attribute=", "<abc attribute=!"
                    return false;
                }
                int valueStartIndex = notDelimited ? currentIndex : currentIndex + 1;
                int valueEndIndex = -1;
                while (ReadNext())
                {
                    if (singleDelimeted)
                    {
                        if (currentChar == '\'')
                        {
                            valueEndIndex = currentIndex - 1;
                            break;
                        }
                        continue;
                    }
                    else if (doubleDelimeted)
                    {
                        if (currentChar == '"')
                        {
                            valueEndIndex = currentIndex - 1;
                            break;
                        }
                        continue;
                    }
                    else
                    {
                        bool foundWhitespace = char.IsWhiteSpace(currentChar);
                        if (char.IsWhiteSpace(currentChar))
                        {
                            valueEndIndex = currentIndex - 1;
                            ReadAndSkipWhitespace();
                        }
                        if (currentChar == '/' || currentChar == '>')
                        {
                            if (valueEndIndex == -1)
                            {
                                valueEndIndex = currentIndex - 1;
                            }
                            break;
                        }
                        else if (foundWhitespace)
                        {
                            // Found another attribute
                            break;
                        }
                        continue;
                    }
                }
                if (valueEndIndex == -1)
                {
                    // No end of attribute value, e.g. "<abc attribute=", "<abc attribute=', "<abc attribute="a, "<abc attribute='a or , "<abc attribute=a
                    return false;
                }
                string value = text.Substring(valueStartIndex, valueEndIndex - valueStartIndex + 1);
                attribute = new HtmlAttribute(name, value);
                return notDelimited || ReadAndSkipWhitespace();
            }

            private bool TryParseInnerText()
            {
                ReadAndSkipWhitespace();
                int innerTextStartIndex = currentIndex;
                while (currentChar != '<' && ReadNext()) ;

                int innerTextLength = currentIndex - innerTextStartIndex;
                if (innerTextLength < 0)
                {
                    // No end of non-void tag, e.g. "<abc>", "<abc>  ", "<abc>InnerText"
                    return false;
                }
                if (innerTextLength != 0)
                {
                    currentElement.InnerText = text.Substring(innerTextStartIndex, innerTextLength);
                }
                return true;
            }

            private bool TryParseClosingTag()
            {
                ReadAndSkipWhitespace();
                int tagStartIndex = currentIndex;
                int tagEndIndex = -1;
                // Non-void closing tag, e.g. "<abc></abc>"
                while (ReadNext())
                {
                    if (currentChar == '>')
                    {
                        // Found terminating '>'
                        tagEndIndex = currentIndex - 1;
                        break;
                    }
                    else if (char.IsWhiteSpace(currentChar))
                    {
                        tagEndIndex = currentIndex - 1;
                        ReadAndSkipWhitespace();
                        if (currentChar == '>')
                        {
                            break;
                        }
                        else
                        {
                            // Can only have '>' after whitespace, e.g. <abc></abc "
                            return false;
                        }
                    }
                }
                if (tagEndIndex == -1)
                {
                    // Invalid closing tag, e.g. "<abc></", "<abc></abc", "<abc></abc  "
                    return false;
                }
                int tagLength = tagEndIndex - tagStartIndex + 1;
                if (!StringExtensions.EqualsAsciiOrdinalIgnoreCase(currentElement.Tag, 0, currentElement.Tag.Length, text, tagStartIndex, tagLength))
                {
                    // Non matching closing tag, e.g. "<abc></def>"
                    return false;
                }
                currentElement = currentElement.Parent;
                ReadAndSkipWhitespace();
                return true;
            }

            private bool TryParseComment()
            {
                if (!ReadNext())
                {
                    // Nothing after '!', e.g. "<!"
                    return false;
                }
                if (currentChar != '-')
                {
                    // Invalid char after '!', e.g "<!a", but maybe is a doctype if we haven't parsed anything yet
                    if (rootElement == null)
                    {
                        return TryParseDoctype();
                    }
                    return false;
                }
                if (!ReadNext() || currentChar != '-')
                {
                    // Invalid char after '-', e.g. "<!-", "<!-a"
                    return false;
                }
                int commentStartIndex = currentIndex + 1;
                int commentEndIndex = -1;
                while (ReadNext())
                {
                    if (currentChar == '-')
                    {
                        if (ReadNext() && currentChar == '-')
                        {
                            if (ReadNext() && currentChar == '>')
                            {
                                commentEndIndex = currentIndex - 3;
                                break;
                            }
                        }
                    }
                }
                if (commentEndIndex == -1)
                {
                    // No end of comment, e.g. "<!--", "<!--abc", "<!--abc-", "<!--abc-a", "<!--abc--", "<!--abc--a"
                    return false;
                }
                string comment = text.Substring(commentStartIndex, commentEndIndex - commentStartIndex + 1);
                SetParsing(new HtmlComment(comment));
                ReadAndSkipWhitespace();
                return true;
            }

            private bool TryParseDoctype()
            {
                int doctypeStartIndex = currentIndex;
                int doctypeEndIndex = -1;
                while (ReadNext())
                {
                    if (currentChar == '>')
                    {
                        doctypeEndIndex = currentIndex - 1;
                        break;
                    }
                }
                if (doctypeEndIndex == -1)
                {
                    // No end of doctype found, e.g. "<!DOCTYPE html"
                    return false;
                }
                string doctypeString = text.Substring(doctypeStartIndex, doctypeEndIndex - doctypeStartIndex + 1);
                doctype = new HtmlDoctype(doctypeString);
                ReadAndSkipWhitespace();
                return true;
            }

            private void SetParsing(HtmlElement element)
            {
                if (rootElement == null)
                {
                    currentElement = element;
                    rootElement = element;
                }
                else
                {
                    currentElement.Add(element);
                    if (!element.IsVoid)
                    {
                        currentElement = element;
                    }
                }
            }

            public bool Parse()
            {
                ReadAndSkipWhitespace();
                return TryParseOpeningTag();
            }

            private static bool IsLetter(char c)
            {
                return (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z');
            }

            private static bool IsNumber(char c)
            {
                return (c >= '0' && c <= '9');
            }

            private bool ReadNext()
            {
                currentChar = char.MinValue;
                if (currentIndex >= text.Length)
                {
                    return false;
                }
                currentIndex++;
                if (currentIndex < text.Length)
                {
                    currentChar = text[currentIndex];
                }
                return true;
            }

            private bool ReadAndSkipWhitespace()
            {
                while (ReadNext())
                {
                    if (!char.IsWhiteSpace(currentChar))
                    {
                        return true;
                    }
                }
                return false;
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
