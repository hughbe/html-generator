using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace HtmlGenerator
{
    public class HtmlElement
    {
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
            Attributes.Add(key, value);
            return this;
        }

        public HtmlElement WithAttributes(Dictionary<string, string> attributes)
        {
            Attributes = attributes;
            return this;
        }

        public HtmlElement WithContent(string content)
        {
            Content = content;
            return this;
        }
        
        public string ElementTag { get; }

        public Dictionary<string, string> Attributes { get; private set; } = new Dictionary<string, string>();
        
        public string Content { get; private set; }

        public HtmlElement Parent { get; internal set; }
        public Collection<HtmlElement> Children { get; private set; } = new Collection<HtmlElement>();

        public T Add<T>(T element) where T : HtmlElement
        {
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
                attributes += attribute.Key + "=" + "\"" + attribute.Value + "\" ";
            }

            return tagOpener + attributes + tagCloser;
        }

        public override string ToString() => SerializeOpenTag();
    }
}
