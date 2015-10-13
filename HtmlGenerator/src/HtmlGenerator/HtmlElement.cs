using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace HtmlGenerator
{
    public class HtmlElement
    {
        public HtmlElement(string elementTag, bool isVoidElement)
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
            IsVoidElement = isVoidElement;
        }

        public HtmlElement(string elementTag) : this(elementTag, false)
        {
        }

        public string ElementTag { get; }
        public bool IsVoidElement { get; }

        public string Content { get; private set; }

        public HtmlElement Parent { get; internal set; }
        public Collection<HtmlElement> Children { get; private set; } = new Collection<HtmlElement>();

        public Dictionary<Attribute, string> Attributes { get; private set; } = new Dictionary<Attribute, string>();

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

        public void AddChild(HtmlElement child)
        {
            if (child == null)
            {
                throw new ArgumentNullException(nameof(child));
            }
            Children.Add(child);
        }

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

        public HtmlElement WithAttribute(Attribute attribute, string value)
        {
            SetAttribute(attribute, value);
            return this;
        }

        public HtmlElement WithAttributes(Dictionary<Attribute, string> attributes)
        {
            SetAttributes(attributes);
            return this;
        }

        public void SetClass(string className)
        {
            SetAttribute(Attribute.Class, className);
        }

        public void SetId(string idName)
        {
            SetAttribute(Attribute.Id, idName);
        }

        public void SetAttribute(string key, string value)
        {
            SetAttribute(new Attribute(key), value);
        }

        public void SetAttribute(Attribute attribute, string value)
        {
            Attributes.Add(attribute, value ?? "");
        }

        public HtmlElement SetAttributes(Dictionary<Attribute, string> attributes)
        {
            Attributes = attributes ?? new Dictionary<Attribute, string>();
            return this;
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

        public T Add<T>(T element) where T : HtmlElement
        {
            if (element == null)
            {
                throw new ArgumentNullException(nameof(element));
            }

            Children.Add(element);
            element.Parent = this;
            return element;
        }

        public virtual string Serialize()
        {
            var openingTag = SerializeOpenTag();
            if (!IsVoidElement)
            {
                return openingTag;
            }
            var closingTag = "</" + ElementTag + ">";

            var content = Content ?? "";
            foreach (var child in Children)
            {
                content += child.Serialize();
            }

            return openingTag + content + closingTag;
        }

        private string SerializeOpenTag()
        {
            var tagOpener = "<" + ElementTag;
            var tagCloser = ">";

            if (IsVoidElement)
            {
                tagCloser = "/>";
            }

            if (Attributes == null || Attributes.Count == 0)
            {
                return tagOpener + tagCloser;
            }

            var attributes = " ";
            foreach (var attribute in Attributes)
            {
                if (string.IsNullOrEmpty(attribute.Value)) //No attribute content
                {
                    attributes += attribute.Key.Key;
                }
                else
                {
                    attributes += attribute.Key.Key + "=" + "\"" + attribute.Value + "\" ";
                }
            }

            return tagOpener + attributes + tagCloser;
        }

        public override string ToString() => SerializeOpenTag();
    }
}
