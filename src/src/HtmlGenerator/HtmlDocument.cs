namespace HtmlGenerator
{
    public class HtmlDocument : HtmlElement
    {
        public HtmlDocument(HtmlElement head, HtmlElement body) : base(Tag.Html)
        {
            Head = AddChild(head ?? Tag.Head);
            Body = AddChild(body ?? Tag.Body);
        }

        public HtmlDocument() : this(null, null)
        {
        }

        public HtmlElement Head { get; }
        public HtmlElement Body { get; }

        public string Doctype { get; set; } = "<!DOCTYPE html>";

        public override string Serialize(HtmlSerializeType serializeType, int depth)
        {
            var doctype = Doctype ?? "";
            if (serializeType == HtmlSerializeType.PrettyPrint)
            {
                doctype += "\r";
            }
            return doctype + base.Serialize(serializeType, depth);
        }
    }
}