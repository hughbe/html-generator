namespace HtmlGenerator
{
    public class HtmlDocument : HtmlElement
    {
        public HtmlDocument(HtmlHead head, HtmlElement body) : base("html")
        {
            Head = Add(head ?? new HtmlHead());
            Body = Add(body ?? new HtmlElement("body"));
        }

        public HtmlDocument() : this(null, null)
        {
        }

        public HtmlDocument(string title) : this(new HtmlHead(title), null)
        {
        }

        public HtmlHead Head { get; }
        public HtmlElement Body { get; }
    }
}
