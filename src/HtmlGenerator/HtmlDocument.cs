using System;
using System.Text;

namespace HtmlGenerator
{
    public class HtmlDocument : HtmlElement, IEquatable<HtmlDocument>
    {
        public HtmlDocument() : base("html")
        {
            Doctype = new HtmlDoctype(HtmlDoctypeType.Html5);
        }

        public override HtmlObjectType ObjectType => HtmlObjectType.Document;

        private HtmlElement _head = null;
        public HtmlElement Head
        {
            get { return _head; }
            set
            {
                _head?.RemoveFromParent();
                if (value != null)
                {
                    Add(value);
                }
                _head = value;
            }
        }

        private HtmlElement _body = null;
        public HtmlElement Body
        {
            get { return _body; }
            set
            {
                _body?.RemoveFromParent();
                if (value != null)
                {
                    Add(value);
                }
                _body = value;
            }
        }

        public HtmlDoctype Doctype { get; set; }

        public HtmlDocument AddHead()
        {
            if (Head != null)
            {
                throw new InvalidOperationException("Document already has a head element.");
            }
            Head = HtmlGenerator.Tag.Head;
            return this;
        }

        public HtmlDocument AddBody()
        {
            if (Body != null)
            {
                throw new InvalidOperationException("Document already has a body element.");
            }
            Body = HtmlGenerator.Tag.Body;
            return this;
        }

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

        public override void Serialize(StringBuilder builder, HtmlSerializeOptions serializeOptions)
        {
            if (Doctype != null)
            {
                Doctype.Serialize(builder, serializeOptions);
                if (serializeOptions != HtmlSerializeOptions.NoFormatting)
                {
                    builder.AppendLine();
                }
            }
            base.Serialize(builder, serializeOptions);
        }

        public static new HtmlDocument Parse(string text)
        {
            HtmlDocument document;
            if (!TryParse(text, out document))
            {
                return null;
            }
            return document;
        }

        public static bool TryParse(string text, out HtmlDocument document)
        {
            document = null;
            if (text == null || text.Length == 0)
            {
                return false;
            }

            Parser parser = new Parser(text, isDocument: true);
            if (parser.Parse())
            {
                document = (HtmlDocument)parser.rootElement;
                return true;
            }
            return false;
        }
    }
}
