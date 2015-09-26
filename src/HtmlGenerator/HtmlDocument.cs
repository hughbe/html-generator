namespace HtmlGenerator
{
    public class HtmlDocument : HtmlElement
    {
        public HtmlDocument(HtmlElement head, HtmlElement body) : base(Tags.Html.ElementTag)
        {
            Head = Add(head ?? Tags.Head);
            Body = Add(body ?? Tags.Body);
        }

        public HtmlDocument() : this(null, null)
        {
        }

        public HtmlElement Head { get; }
        public HtmlElement Body { get; }
    }
}
