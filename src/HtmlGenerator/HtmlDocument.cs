using System;
using System.Text;

namespace HtmlGenerator
{
    public class HtmlDocument : HtmlElement, IEquatable<HtmlDocument>
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

        public override HtmlObjectType ObjectType => HtmlObjectType.Document;

        public override bool Equals(object obj) => Equals(obj as HtmlDocument);

        public bool Equals(HtmlDocument other)
        {
            if (!base.Equals(other))
            {
                return false;
            }
            if (Doctype == null)
            {
                return other.Doctype == null;
            }
            return Doctype.Equals(other.Doctype);
        }

        public override int GetHashCode() => Doctype == null ? base.GetHashCode() : (base.GetHashCode() ^ Doctype.GetHashCode());

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
