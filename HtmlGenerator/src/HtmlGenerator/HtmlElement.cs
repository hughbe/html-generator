using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace HtmlGenerator
{
    public class HtmlElement
    {
        public string ElementTag { get; }

        public Dictionary<Attribute, string> Attributes { get; private set; } = new Dictionary<Attribute, string>();

        public string Content { get; private set; }

        public HtmlElement Parent { get; internal set; }
        public Collection<HtmlElement> Children { get; private set; } = new Collection<HtmlElement>();

        public HtmlElement(string elementTag)
        {
            ElementTag = elementTag;
        }

        public HtmlElement WithChildren(params HtmlElement[] children)
        {
            Children = new Collection<HtmlElement>(children);
            return this;
        }

        public HtmlElement WithClass(string className) => WithAttribute("class", className);
        public HtmlElement WithId(string idName) => WithAttribute("id", idName);

        public HtmlElement WithAttribute(string key, string value)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            return WithAttribute(new Attribute(key), value);
        }

        public HtmlElement WithAttribute(Attribute attribute, string value)
        {
            Attributes.Add(attribute, value ?? "");
            return this;
        }

        public HtmlElement WithAttributes(Dictionary<Attribute, string> attributes)
        {
            if (attributes == null)
            {
                throw new ArgumentNullException(nameof(attributes));
            }

            Attributes = attributes;
            return this;
        }

        public HtmlElement WithContent(string content)
        {
            if (content == null)
            {
                throw new ArgumentNullException(nameof(content));
            }

            Content = content;
            return this;
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
            var closingTag = "</" + ElementTag + ">";

            var content = Content ?? "";
            foreach (var child in Children)
            {
                content += child.Serialize();
            }

            if (string.IsNullOrEmpty(ElementTag))
            {
                return content;
            }
            return openingTag + content + closingTag;
        }

        private string SerializeOpenTag()
        {
            var tagOpener = "<" + ElementTag;
            var tagCloser = ">";

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
