namespace HtmlGenerator
{
    public class HtmlDocument : HtmlElement
    {
        public HtmlDocument(HtmlElement head, HtmlElement body) : base(Tag.Html.ElementTag)
        {
            Head = Add(head ?? Tag.Head);
            Body = Add(body ?? Tag.Body);
        }

        public HtmlDocument() : this(null, null)
        {
        }

        public HtmlElement Head { get; }
        public HtmlElement Body { get; }
        
        public string Doctype { get; set; } = "<!DOCTYPE html>";

        public override string Serialize()
        {
            var doctype = Doctype ?? "";
            return doctype + base.Serialize();
        }
    }
}
