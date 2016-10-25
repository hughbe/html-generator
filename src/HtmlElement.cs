using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HtmlGenerator.Extensions;

namespace HtmlGenerator
{
    public class HtmlElement : HtmlNode, IEquatable<HtmlElement>
    {
        internal readonly HtmlObjectLinkedList<HtmlNode> _nodes = new HtmlObjectLinkedList<HtmlNode>();
        private HtmlObjectLinkedList<HtmlAttribute> _attributes = new HtmlObjectLinkedList<HtmlAttribute>();

        public HtmlElement(string tag)
        {
            Requires.NotNullOrWhitespace(tag, nameof(tag));
            Tag = tag.ToAsciiLower();
        }

        public HtmlElement(string tag, bool isVoid) : this(tag)
        {
            IsVoid = isVoid;
        }

        public HtmlElement(string tag, params HtmlObject[] content) : this(tag)
        {
            Add(content);
        }

        public override HtmlObjectType ObjectType => HtmlObjectType.Element;

        public string Tag { get; }
        public bool IsVoid { get; }

        public HtmlAttribute FirstAttribute => _attributes._first;
        public HtmlElement FirstElement => Elements().FirstOrDefault();
        public HtmlNode FirstNode => _nodes._first;

        public bool HasElements => Elements().Any();
        public bool HasNodes => _nodes._count != 0;
        public bool HasAttributes => _attributes._count != 0;

        public string InnerText
        {
            get
            {
                string text = "";
                foreach (HtmlNode node in Nodes())
                {
                    var htmlText = node as HtmlText;
                    if (htmlText != null)
                    {
                        text += htmlText.Text;
                    }
                }

                return text;
            }
        }
        public bool IsEmpty => !HasNodes && !HasAttributes;

        public HtmlAttribute LastAttribute => _attributes._last;

        public HtmlElement LastElement
        {
            get
            {
                HtmlObject node = _nodes._last;
                while (node != null)
                {
                    HtmlElement element = node as HtmlElement;
                    if (element != null)
                    {
                        return element;
                    }

                    node = node._previous;
                }

                return null;
            }
        }

        public HtmlNode LastNode => _nodes._last;

        public HtmlElement NextElement => NextElements().FirstOrDefault();
        public HtmlElement PreviousElement => PreviousElements().FirstOrDefault();

        public void Add(HtmlObject content)
        {
            Requires.NotNull(content, nameof(content));
            if (ReferenceEquals(this, content.Parent))
            {
                throw new InvalidOperationException("Cannot have a duplicate element or attribute");
            }

            HtmlNode node = content as HtmlNode;
            if (node != null)
            {
                if (ReferenceEquals(this, node))
                {
                    throw new InvalidOperationException("Cannot add an object as a child to itself.");
                }

                ThrowIfVoid();
                AddNodeAfter(this, _nodes._last, node);
            }
            else if (content is HtmlAttribute)
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
                throw new ArgumentException("The object to add was not a node or attribute", nameof(content));
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

            HtmlNode node = content as HtmlNode;
            if (node != null)
            {
                if (ReferenceEquals(this, node))
                {
                    throw new InvalidOperationException("Cannot add an object as a child to itself.");
                }

                ThrowIfVoid();
                AddNodeBefore(this, _nodes._first, node);
            }
            else if (content is HtmlAttribute)
            {
                HtmlAttribute attribute = (HtmlAttribute)content;
                if (HasAttribute(attribute.Name))
                {
                    throw new InvalidOperationException("Cannot have a duplicate element or attribute.");
                }

                AddAttributeFirst(attribute);
            }
            else
            {
                throw new ArgumentException("The object to add was not a node or attribute", nameof(content));
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

        public IEnumerable<HtmlAttribute> Attributes()
        {
            HtmlAttribute attributeNode = _attributes._first;
            while (attributeNode != null)
            {
                yield return attributeNode;

                attributeNode = (HtmlAttribute)attributeNode._next;
            }
        }

        public IEnumerable<HtmlElement> Descendants() => Descendants(null);

        public IEnumerable<HtmlElement> Descendants(string tag)
        {
            bool isDefaultTag = string.IsNullOrEmpty(tag);

            HtmlObject node = _nodes._first;
            while (node != null)
            {
                HtmlElement element = node as HtmlElement;
                if (element != null)
                {
                    if (isDefaultTag || StringExtensions.EqualsAsciiOrdinalIgnoreCase(element.Tag, tag))
                    {
                        yield return element;
                    }

                    foreach (HtmlElement child in element.Descendants(tag))
                    {
                        yield return child;
                    }
                }

                node = node._next;
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

        public IEnumerable<HtmlElement> Elements() => Elements(null);

        public IEnumerable<HtmlElement> Elements(string tag)
        {
            bool isDefaultTag = string.IsNullOrEmpty(tag);

            HtmlObject node = _nodes._first;
            while (node != null)
            {
                HtmlElement element = node as HtmlElement;
                if ((element != null) && (isDefaultTag || StringExtensions.EqualsAsciiOrdinalIgnoreCase(element.Tag, tag)))
                {
                    yield return element;
                }

                node = node._next;
            }
        }

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
            return Elements(tag).Any();
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

        public IEnumerable<HtmlElement> NextElements() => NextElements(null);

        public IEnumerable<HtmlElement> NextElements(string tag)
        {
            bool isDefaultTag = string.IsNullOrEmpty(tag);

            HtmlObject nextNode = _next;
            while (nextNode != null)
            {
                HtmlElement nextElement = nextNode as HtmlElement;
                if ((nextElement != null) && (isDefaultTag || StringExtensions.EqualsAsciiOrdinalIgnoreCase(nextElement.Tag, tag)))
                {
                    yield return nextElement;
                }

                nextNode = nextNode._next;
            }
        }

        public IEnumerable<HtmlNode> Nodes()
        {
            HtmlObject node = _nodes._first;
            while (node != null)
            {
                yield return (HtmlNode)node;

                node = node._next;
            }
        }

        public IEnumerable<HtmlObject> NodesAndAttributes()
        {
            foreach (HtmlNode node in Nodes())
            {
                yield return node;
            }
            foreach (HtmlAttribute attribute in Attributes())
            {
                yield return attribute;
            }
        }

        public IEnumerable<HtmlElement> PreviousElements() => PreviousElements(null);

        public IEnumerable<HtmlElement> PreviousElements(string tag)
        {
            bool isDefaultTag = string.IsNullOrEmpty(tag);

            HtmlObject previousNode = _previous;
            while (previousNode != null)
            {
                HtmlElement previousElement = previousNode as HtmlElement;
                if ((previousElement != null) && (isDefaultTag || StringExtensions.EqualsAsciiOrdinalIgnoreCase(previousElement.Tag, tag)))
                {
                    yield return previousElement;
                }

                previousNode = previousNode._previous;
            }
        }

        public void ReplaceAll(params HtmlObject[] content) => ReplaceAll((IEnumerable<HtmlObject>)content);

        public void ReplaceAll(IEnumerable<HtmlObject> content)
        {
            Requires.NotNull(content, nameof(content));

            _nodes.Clear();
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

        public void ReplaceNodes(params HtmlNode[] nodes) => ReplaceNodes((IEnumerable<HtmlNode>)nodes);

        public void ReplaceNodes(IEnumerable<HtmlNode> nodes)
        {
            Requires.NotNull(nodes, nameof(nodes));
            ThrowIfVoid();

            _nodes.Clear();
            foreach (HtmlNode node in nodes)
            {
                Add(node);
            }
        }

        public void RemoveAll()
        {
            _nodes.Clear();
            _attributes.Clear();
        }

        public void RemoveAttributes()
        {
            ThrowIfVoid();
            _attributes.Clear();
        }

        public void RemoveNodes()
        {
            ThrowIfVoid();
            _nodes.Clear();
        }

        internal void RemoveAttribute(HtmlAttribute attribute)
        {
            _attributes.Remove(attribute);
            attribute.Parent = null;
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

        public bool TryGetElement(string tag, out HtmlElement element)
        {
            Requires.NotNullOrWhitespace(tag, nameof(tag));
            element = Elements(tag).FirstOrDefault();
            return element != null;
        }

        public override bool Equals(object obj) => Equals(obj as HtmlElement);

        public bool Equals(HtmlElement element)
        {
            if (element == null)
            {
                return false;
            }
            if ((Tag != element.Tag) || (IsVoid != element.IsVoid))
            {
                return false;
            }
            if ((_nodes._count != element._nodes._count) || (_attributes._count != element._attributes._count))
            {
                return false;
            }

            if (_nodes._count > 0)
            {
                using (IEnumerator<HtmlNode> thisNodes = Nodes().GetEnumerator())
                {
                    using (IEnumerator<HtmlNode> otherNodes = element.Nodes().GetEnumerator())
                    {
                        while (otherNodes.MoveNext())
                        {
                            if (!thisNodes.MoveNext())
                            {
                                // More other nodes than this nodes
                                return false;
                            }
                            if (!thisNodes.Current.Equals(otherNodes.Current))
                            {
                                return false;
                            }
                        }

                        if (thisNodes.MoveNext())
                        {
                            // More this nodes than other nodes
                            return false;
                        }
                    }
                }
            }

            if (_attributes._count > 0)
            {
                using (IEnumerator<HtmlAttribute> thisAttributes = Attributes().GetEnumerator())
                {
                    using (IEnumerator<HtmlAttribute> otherAttributes = element.Attributes().GetEnumerator())
                    {
                        while (otherAttributes.MoveNext())
                        {
                            if (!thisAttributes.MoveNext())
                            {
                                // More other attributes than this attributes
                                return false;
                            }
                            if (!thisAttributes.Current.Equals(otherAttributes.Current))
                            {
                                return false;
                            }
                        }

                        if (thisAttributes.MoveNext())
                        {
                            // More this attributes than other attributes
                            return false;
                        }
                    }
                }
            }

            return true;
        }

        public override int GetHashCode() => Tag.GetHashCode();

        public override void Serialize(StringBuilder builder, int depth, HtmlSerializeOptions serializeOptions)
        {
            AddDepth(builder, depth);
            SerializeOpenTag(builder, depth, serializeOptions);
            if (IsVoid)
            {
                return;
            }

            IEnumerable<HtmlNode> nodes = Nodes().ToArray();
            bool mixedMode = nodes.Any(node => node.ObjectType == HtmlObjectType.Text);
            //bool formattedSubNode = false;
            foreach (HtmlNode node in nodes)
            {
                HtmlElement element = node as HtmlElement;
                bool nodeHasElements = (element != null) && element.HasElements;
                if (mixedMode && !nodeHasElements)
                {
                   node.Serialize(builder, 0, serializeOptions);
                }
                else
                {
                    if (serializeOptions != HtmlSerializeOptions.NoFormatting)
                    {
                        builder.AppendLine();
                    }
                    node.Serialize(builder, depth + 1, serializeOptions);

                    // We don't want many grandchild/greatgrandchild nodes in mixed mode printed inline.
                    if (nodeHasElements && mixedMode && (serializeOptions != HtmlSerializeOptions.NoFormatting))
                    {
                        builder.AppendLine();
                    }
                }
            }

            if (!mixedMode && HasNodes)
            {
                if (serializeOptions != HtmlSerializeOptions.NoFormatting)
                {
                    builder.AppendLine();
                }
                AddDepth(builder, depth);
            }

            builder.Append("</");
            builder.Append(Tag);
            builder.Append('>');
        }

        private void SerializeOpenTag(StringBuilder builder, int depth, HtmlSerializeOptions serializeOptions)
        {
            builder.Append('<');
            builder.Append(Tag);

            if (_attributes._count != 0)
            {
                foreach (var attribute in Attributes())
                {
                    builder.Append(' ');
                    attribute.Serialize(builder, 0, serializeOptions);
                }
            }

            builder.Append(IsVoid ? " />" : ">");
        }

        public static HtmlElement Parse(string text)
        {
            Requires.NotNullOrEmpty(text, nameof(text));

            Parser parser = new Parser(text, isDocument: false);
            if (!parser.Parse())
            {
                throw parser.GetException();
            }

            return parser._rootElement;
        }

        public static bool TryParse(string text, out HtmlElement element)
        {
            element = null;
            if ((text == null) || (text.Length == 0))
            {
                return false;
            }

            Parser parser = new Parser(text, isDocument: false);
            if (parser.Parse())
            {
                element = parser._rootElement;
                return true;
            }

            return false;
        }

        private void ThrowIfVoid()
        {
            if (IsVoid)
            {
                throw new InvalidOperationException("Cannot set inner text for a void element");
            }
        }

        protected struct Parser
        {
            public Parser(string text, bool isDocument)
            {
                _text = text;
                _currentIndex = -1;
                _currentChar = char.MinValue;
                _parsingDocument = isDocument;
                _currentElement = null;
                _rootElement = null;
                _doctype = null;
                _parseError = (HtmlParseError)(-1);
            }

            private readonly string _text;
            private int _currentIndex;
            private char _currentChar;
            private readonly bool _parsingDocument;

            public HtmlElement _rootElement;
            private HtmlElement _currentElement;

            private HtmlDoctype _doctype;

            private HtmlParseError _parseError;

            public string Remaining => _text.Substring(_currentIndex);

            public bool TryParseOpeningTag()
            {
                if (_currentChar != '<')
                {
                    // No opening tag, e.g. "abc", "<abc>", "<abc>  " or "<abc>InnerText"
                    _parseError = HtmlParseError.NoOpeningTag;
                    return false;
                }

                ReadAndSkipWhitespace();
                switch (_currentChar)
                {
                    case '/':
                        if (!TryParseClosingTag())
                        {
                            return false;
                        }
                        if ((_currentElement != null) || (_currentIndex + 1 < _text.Length))
                        {
                            // If the element we just finished parsing has a parent, that parent needs to have a closing tag too, so keep parsing.
                            // If we have more text, then there may be more to parse.
                            return TryParseInnerText();
                        }
                        // Finished parsing
                        return true;
                    case '!':
                        if (!TryParseComment())
                        {
                            // Couldn't parse the comment
                            return false;
                        }

                        if (_currentIndex + 1 < _text.Length)
                        {
                            // Got more to parse?
                            return TryParseInnerText();
                        }
                        // Doctype or comment on its own, e.g. "<!--comment-->" or "<div><!--comment-->"
                        _parseError = HtmlParseError.LoneDoctype;
                        return false;
                    default:
                        if (!IsLetter(_currentChar))
                        {
                            // No valid tag, e.g. "<>", "<1"
                            _parseError = HtmlParseError.InvalidTag;
                            return false;
                        }

                        break;
                }


                int tagStartIndex = _currentIndex;
                int tagEndIndex = -1;
                bool foundTagEnd = false;
                while (ReadNext())
                {
                    foundTagEnd = (_currentChar == '/') || (_currentChar == '>');
                    if (foundTagEnd || char.IsWhiteSpace(_currentChar))
                    {
                        tagEndIndex = _currentIndex - 1;
                        break;
                    }
                }

                if (tagEndIndex == -1)
                {
                    // No end of tag, e.g. "<abc", "<abc "
                    _parseError = HtmlParseError.OpeningTagNotClosed;
                    return false;
                }

                string tag = _text.ToAsciiLower(tagStartIndex, tagEndIndex - tagStartIndex + 1);
                HtmlObjectLinkedList<HtmlAttribute> attributes = null;
                if (!foundTagEnd && !TryParseAttributes(out attributes))
                {
                    // Could not parse attributes
                    return false;
                }

                bool isVoid = false;
                if (_currentChar == '/')
                {
                    // Void element?
                    ReadAndSkipWhitespace();
                    if (_currentChar != '>')
                    {
                        // No end of void tag, e.g. "<abc/", "<abc/a>"
                        _parseError = HtmlParseError.NodeNotClosed;
                        return false;
                    }

                    isVoid = true;
                    if (_currentElement != null)
                    {
                        // Read on if this void element is a child
                        ReadAndSkipWhitespace();
                    }
                }
                else
                {
                    ReadAndSkipWhitespace();
                }

                HtmlElement element;
                if (_rootElement == null)
                {
                    if ((tag == "html") && !isVoid)
                    {
                        element = new HtmlDocument { Doctype = _doctype };
                    }
                    else if (_parsingDocument)
                    {
                        // First tag of a document has to be an open html tag
                        _parseError = HtmlParseError.FirstElementInDocumentNotHtml;
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

                if (element.IsVoid && (element.Parent == null))
                {
                    if (!ReadNext() || (char.IsWhiteSpace(_currentChar) && !ReadAndSkipWhitespace()))
                    {
                        // Valid void element without a parent, e.g. "<abc/>", "<abc/>  "
                        return true;
                    }

                    // Invalid text after a void element without a parent, e.g. "<abc/>a"
                    _parseError = HtmlParseError.InvalidTextAfterNode;
                    return false;
                }

                if ((element.Parent != null) || !element.IsVoid)
                {
                    // If the element has a parent, we need to make sure the parent has a closing tag.
                    // If the element has no parent, but is non-void, we also need to make sure the element has a closing tag.
                    if (!TryParseInnerText())
                    {
                        // Couldn't parse inner text, e.g. "<abc>Inner<def></def>"
                        return false;
                    }
                }

                return true;
            }

            private bool TryParseAttributes(out HtmlObjectLinkedList<HtmlAttribute> attributes)
            {
                attributes = new HtmlObjectLinkedList<HtmlAttribute>();
                ReadAndSkipWhitespace();

                while ((_currentChar != '/') && (_currentChar != '>'))
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

                int nameStartIndex = _currentIndex;
                int nameEndIndex = -1;
                bool foundWhitespace = false;
                while (ReadNext())
                {
                    if (!foundWhitespace && char.IsWhiteSpace(_currentChar))
                    {
                        nameEndIndex = _currentIndex - 1;
                        ReadAndSkipWhitespace();
                        foundWhitespace = true;
                    }
                    if ((_currentChar == '/') || (_currentChar == '>'))
                    {
                        if (nameEndIndex == -1)
                        {
                            nameEndIndex = _currentIndex - 1;
                        }
                        isFinalAttribute = true;
                        break;
                    }

                    if (_currentChar == '=')
                    {
                        if (nameEndIndex == -1)
                        {
                            nameEndIndex = _currentIndex - 1;
                        }
                        isExtendedAttribute = true;
                        ReadAndSkipWhitespace();
                        break;
                    }

                    if (nameEndIndex != -1)
                    {
                        // Found another attribute
                        break;
                    }
                }

                if (nameEndIndex == -1)
                {
                    _parseError = HtmlParseError.OpeningTagNotClosedAfterAttribute;
                    return false;
                }

                int nameLength = nameEndIndex - nameStartIndex + 1;
                name = _text.ToAsciiLower(nameStartIndex, nameLength);
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
                    // Invalid attribute, e.g. "<abc attribute"
                    return false;
                }

                if (isFinalAttribute || !isExtendedAttribute)
                {
                    attribute = new HtmlAttribute(name);
                    return true;
                }

                bool singleDelimeted = _currentChar == '\'';
                bool doubleDelimeted = _currentChar == '"';
                bool notDelimited = IsLetter(_currentChar);
                if (!singleDelimeted && !doubleDelimeted && !notDelimited)
                {
                    // Invalid character after equals, e.g. "<abc attribute=" or "<abc attribute=!"
                    _parseError = HtmlParseError.NoAttributeValue;
                    return false;
                }

                int valueStartIndex = notDelimited ? _currentIndex : _currentIndex + 1;
                int valueEndIndex = -1;
                while (ReadNext())
                {
                    if (singleDelimeted)
                    {
                        if (_currentChar == '\'')
                        {
                            valueEndIndex = _currentIndex - 1;
                            break;
                        }
                    }
                    else if (doubleDelimeted)
                    {
                        if (_currentChar == '"')
                        {
                            valueEndIndex = _currentIndex - 1;
                            break;
                        }
                    }
                    else
                    {
                        bool foundWhitespace = char.IsWhiteSpace(_currentChar);
                        if (char.IsWhiteSpace(_currentChar))
                        {
                            valueEndIndex = _currentIndex - 1;
                            ReadAndSkipWhitespace();
                        }
                        if ((_currentChar == '/') || (_currentChar == '>'))
                        {
                            if (valueEndIndex == -1)
                            {
                                valueEndIndex = _currentIndex - 1;
                            }
                            break;
                        }

                        if (foundWhitespace)
                        {
                            // Found another attribute
                            break;
                        }
                    }
                }

                if (valueEndIndex == -1)
                {
                    // No end of attribute value, e.g. "<abc attribute=", "<abc attribute=', "<abc attribute="a, "<abc attribute='a or , "<abc attribute=a
                    _parseError = HtmlParseError.OpeningTagNotClosedAfterAttribute;
                    return false;
                }

                string value = _text.Substring(valueStartIndex, valueEndIndex - valueStartIndex + 1);
                attribute = new HtmlAttribute(name, value);
                return notDelimited || ReadAndSkipWhitespace();
            }

            private bool TryParseInnerText()
            {
                int innerTextStartIndex = _currentIndex;
                while ((_currentChar != '<') && ReadNext())
                {
                }

                int innerTextLength = _currentIndex - innerTextStartIndex;
                if (innerTextLength != 0)
                {
                    if (_currentElement == null)
                    {
                        // Just text, e.g. "<!DOCTYPE>a"
                        _parseError = HtmlParseError.InvalidTextAfterNode;
                        return false;
                    }

                    string innerText = _text.Substring(innerTextStartIndex, innerTextLength);
                    _currentElement.Add(new HtmlText(innerText));
                }

                return TryParseOpeningTag();
            }

            private bool TryParseClosingTag()
            {
                ReadAndSkipWhitespace();
                int tagStartIndex = _currentIndex;
                int tagEndIndex = -1;
                // Non-void closing tag, e.g. "<abc></abc>"
                while (ReadNext())
                {
                    if (_currentChar == '>')
                    {
                        // Found terminating '>'
                        tagEndIndex = _currentIndex - 1;
                        break;
                    }

                    if (char.IsWhiteSpace(_currentChar))
                    {
                        tagEndIndex = _currentIndex - 1;
                        ReadAndSkipWhitespace();
                        if (_currentChar == '>')
                        {
                            break;
                        }
                        // Can only have '>' after whitespace, e.g. <abc></abc "
                        _parseError = HtmlParseError.ClosingTagNotClosed;
                        return false;
                    }
                }

                if (tagEndIndex == -1)
                {
                    // Invalid closing tag, e.g. "<abc></", "<abc></abc", "<abc></abc  "
                    _parseError = HtmlParseError.ClosingTagNotClosed;
                    return false;
                }

                int tagLength = tagEndIndex - tagStartIndex + 1;
                if (!StringExtensions.EqualsAsciiOrdinalIgnoreCase(_currentElement.Tag, 0, _currentElement.Tag.Length, _text, tagStartIndex, tagLength))
                {
                    // Non matching closing tag, e.g. "<abc></def>"
                    _parseError = HtmlParseError.ClosingTagDoesntMatchOpeningTag;
                    return false;
                }

                _currentElement = _currentElement.Parent;
                ReadAndSkipWhitespace();
                return true;
            }

            private bool TryParseComment()
            {
                ReadNext();
                if (_currentChar != '-')
                {
                    // Invalid char after '!', e.g "<!a", but maybe is a doctype if we haven't parsed anything yet
                    if (_rootElement == null)
                    {
                        return TryParseDoctype();
                    }

                    _parseError = HtmlParseError.InvalidCommentStart;
                    return false;
                }

                if (!ReadNext() || (_currentChar != '-'))
                {
                    // Invalid char after '-', e.g. "<!-", "<!-a"
                    _parseError = HtmlParseError.InvalidCommentStart;
                    return false;
                }

                int commentStartIndex = _currentIndex + 1;
                int commentEndIndex = -1;
                while (ReadNext())
                {
                    if (_currentChar == '-')
                    {
                        if (ReadNext() && (_currentChar == '-'))
                        {
                            if (ReadNext() && (_currentChar == '>'))
                            {
                                commentEndIndex = _currentIndex - 3;
                                break;
                            }
                        }
                    }
                }

                if (commentEndIndex == -1)
                {
                    // No end of comment, e.g. "<!--", "<!--abc", "<!--abc-", "<!--abc-a", "<!--abc--", "<!--abc--a"
                    _parseError = HtmlParseError.InvalidCommentEnd;
                    return false;
                }

                string comment = _text.Substring(commentStartIndex, commentEndIndex - commentStartIndex + 1);
                if (_currentElement == null)
                {
                    // Comment on its own, e.g. "<!--comment-->"
                    _parseError = HtmlParseError.LoneComment;
                    return false;
                }

                _currentElement.Add(new HtmlComment(comment));
                ReadAndSkipWhitespace();
                return true;
            }

            private bool TryParseDoctype()
            {
                int doctypeStartIndex = _currentIndex;
                int doctypeEndIndex = -1;
                while (ReadNext())
                {
                    if (_currentChar == '>')
                    {
                        doctypeEndIndex = _currentIndex - 1;
                        break;
                    }
                }

                if (doctypeEndIndex == -1)
                {
                    // No end of doctype found, e.g. "<!DOCTYPE html"
                    _parseError = HtmlParseError.NodeNotClosed;
                    return false;
                }

                string doctypeString = _text.Substring(doctypeStartIndex, doctypeEndIndex - doctypeStartIndex + 1);
                _doctype = new HtmlDoctype(doctypeString);
                ReadAndSkipWhitespace();
                return true;
            }

            private void SetParsing(HtmlElement element)
            {
                if (_rootElement == null)
                {
                    _currentElement = element;
                    _rootElement = element;
                }
                else
                {
                    _currentElement.Add(element);
                    if (!element.IsVoid)
                    {
                        _currentElement = element;
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
                return ((c >= 'a') && (c <= 'z')) || ((c >= 'A') && (c <= 'Z'));
            }

            private bool ReadNext()
            {
                _currentChar = char.MinValue;
                if (_currentIndex + 1 >= _text.Length)
                {
                    return false;
                }

                _currentIndex++;
                _currentChar = _text[_currentIndex];
                return true;
            }

            private bool ReadAndSkipWhitespace()
            {
                while (ReadNext())
                {
                    if (!char.IsWhiteSpace(_currentChar))
                    {
                        return true;
                    }
                }

                return false;
            }

            public HtmlException GetException()
            {
                int lineNumber = 0;
                int latestLineIndex = 0;
                for (int i = 0; i <= _currentIndex; i++)
                {
                    if (_text[i] == '\n')
                    {
                        lineNumber++;
                        latestLineIndex = i;
                    }
                }

                _currentIndex++;
                int position = _currentIndex - latestLineIndex;

                string prefix;
                switch (_parseError)
                {
                    case HtmlParseError.NoOpeningTag:
                        prefix = "Could not find an opening tag.";
                        break;
                    case HtmlParseError.InvalidTag:
                        prefix = "An opening tag was invalid.";
                        break;
                    case HtmlParseError.OpeningTagNotClosed:
                        prefix = "An opening tag was not closed.";
                        break;
                    case HtmlParseError.NodeNotClosed:
                        prefix = "A node or void element was not closed.";
                        break;
                    case HtmlParseError.FirstElementInDocumentNotHtml:
                        prefix = "The first element of a document was not an html element.";
                        break;
                    case HtmlParseError.LoneDoctype:
                        prefix = "A doctype cannot be parsed on its own.";
                        break;
                    case HtmlParseError.OpeningTagNotClosedAfterAttribute:
                        prefix = "Could not find the end of a tag after attributes.";
                        break;
                    case HtmlParseError.NoAttributeValue:
                        prefix = "Could not parse the value of an attribute.";
                        break;
                    case HtmlParseError.InvalidTextAfterNode:
                        prefix = "Found invalid text after a node or void element.";
                        break;
                    case HtmlParseError.ClosingTagNotClosed:
                        prefix = "A closing tag of an element was not closed.";
                        break;
                    case HtmlParseError.ClosingTagDoesntMatchOpeningTag:
                        prefix = "A closing tag of an element did not match its opening tag.";
                        break;
                    case HtmlParseError.InvalidCommentStart:
                        prefix = "The start of a comment was invalid.";
                        break;
                    case HtmlParseError.InvalidCommentEnd:
                        prefix = "The end of a comment was invalid.";
                        break;
                    case HtmlParseError.LoneComment:
                        prefix = "The end of a comment was invalid.";
                        break;
                    default:
                        prefix = "A comment cannot be parsed on its own.";
                        break;
                }

                throw new HtmlException($"{prefix} Reached position {position} on line {lineNumber}. Remaining text is \"{Remaining}\".");
            }

            private enum HtmlParseError
            {
                NoOpeningTag,
                InvalidTag,
                OpeningTagNotClosed,
                NodeNotClosed,
                FirstElementInDocumentNotHtml,
                LoneDoctype,
                OpeningTagNotClosedAfterAttribute,
                NoAttributeValue,
                InvalidTextAfterNode,
                ClosingTagNotClosed,
                ClosingTagDoesntMatchOpeningTag,
                InvalidCommentStart,
                InvalidCommentEnd,
                LoneComment
            }
        }
    }

    public static class HtmlElementExtensions
    {
        public static T WithChild<T>(this T self, HtmlObject element) where T : HtmlElement
        {
            self.Add(element);
            return self;
        }

        public static T WithChildren<T>(this T self, IEnumerable<HtmlObject> elements) where T : HtmlElement
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

        public static T WithInnerText<T>(this T self, HtmlText text) where T : HtmlElement
        {
            self.Add(text);
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
