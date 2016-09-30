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

        public string Doctype { get; set; } = "<!DOCTYPE html>";

        internal override void Serialize(StringBuilder builder, HtmlSerializeOptions serializeType)
        {
            if (!string.IsNullOrEmpty(Doctype))
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
