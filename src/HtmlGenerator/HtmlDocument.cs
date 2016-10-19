using System.Text;

namespace HtmlGenerator
{
    public class HtmlDocument : HtmlElement
    {
        public HtmlDocument() : base("html")
        {
            Head = new HtmlElement("head");
            Body = new HtmlElement("body");

            Add(Head);
            Add(Body);
        }
        
        public HtmlElement Head { get; set; }
        public HtmlElement Body { get; set; }

        public HtmlDoctype Doctype { get; set; } = new HtmlDoctype(HtmlDoctypeType.Html5);

        internal override void Serialize(StringBuilder builder, HtmlSerializeOptions serializeType)
        {
            if (Doctype != null)
            {
                builder.Append(Doctype);
                if (serializeType != HtmlSerializeOptions.NoFormatting)
                {
                    builder.AppendLine();
                }
            }
            base.Serialize(builder, serializeType);
        }
    }
}
