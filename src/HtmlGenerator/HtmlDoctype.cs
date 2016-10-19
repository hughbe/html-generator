using System;
using System.Text;

namespace HtmlGenerator
{
    public class HtmlDoctype : HtmlElement, IEquatable<HtmlDoctype>
    {
        public HtmlDoctype(HtmlDoctypeType doctype) : base("doctype", isVoid: true)
        {
            if (doctype == HtmlDoctypeType.Html5)
            {
                Doctype = "DOCTYPE html";
            }
            else if (doctype == HtmlDoctypeType.Html401Strict)
            {
                Doctype = "DOCTYPE HTML PUBLIC \" -//W3C//DTD HTML 4.01//EN\" \"http://www.w3.org/TR/html4/strict.dtd\"";
            }
            else if (doctype == HtmlDoctypeType.Html401Transitional)
            {
                Doctype = "DOCTYPE HTML PUBLIC \" -//W3C//DTD HTML 4.01 Transitional//EN\" \"http://www.w3.org/TR/html4/loose.dtd\"";
            }
            else if (doctype == HtmlDoctypeType.Html401Frameset)
            {
                Doctype = "DOCTYPE HTML PUBLIC \" -//W3C//DTD HTML 4.01 Frameset//EN\" \"http://www.w3.org/TR/html4/frameset.dtd\"";
            }
            else if (doctype == HtmlDoctypeType.XHtml10Strict)
            {
                Doctype = "DOCTYPE html PUBLIC \" -//W3C//DTD XHTML 1.0 Strict//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd\"";
            }
            else if (doctype == HtmlDoctypeType.XHtml10Transitional)
            {
                Doctype = "DOCTYPE html PUBLIC \" -//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd\"";
            }
            else if (doctype == HtmlDoctypeType.XHtml10Frameset)
            {
                Doctype = "DOCTYPE html PUBLIC \" -//W3C//DTD XHTML 1.0 Frameset//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-frameset.dtd\"";
            }
            else if (doctype == HtmlDoctypeType.XHtml11)
            {
                Doctype = "DOCTYPE html PUBLIC \" -//W3C//DTD XHTML 1.1//EN\" \"http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd\"";
            }
            else
            {
                throw new ArgumentException("Can't infer the doctype from the HtmlDoctypeType provided.", nameof(doctype));
            }

            _doctypeType = doctype;
        }

        public HtmlDoctype(string doctype) : base("doctype", isVoid: true)
        {
            Requires.NotNullOrWhitespace(doctype, nameof(doctype));
            Doctype = doctype;
            _doctypeType = (HtmlDoctypeType)(-1);
        }

        public string Doctype { get; }

        private HtmlDoctypeType _doctypeType;
        public HtmlDoctypeType DoctypeType
        {
            get
            {
                if (_doctypeType == (HtmlDoctypeType)(-1))
                {
                    if (Doctype == "DOCTYPE html")
                    {
                        _doctypeType = HtmlDoctypeType.Html5;
                    }
                    else if (Doctype == "DOCTYPE HTML PUBLIC \" -//W3C//DTD HTML 4.01//EN\" \"http://www.w3.org/TR/html4/strict.dtd\"")
                    {
                        _doctypeType = HtmlDoctypeType.Html401Strict;
                    }
                    else if (Doctype == "DOCTYPE HTML PUBLIC \" -//W3C//DTD HTML 4.01 Transitional//EN\" \"http://www.w3.org/TR/html4/loose.dtd\"")
                    {
                        _doctypeType = HtmlDoctypeType.Html401Transitional;
                    }
                    else if (Doctype == "DOCTYPE HTML PUBLIC \" -//W3C//DTD HTML 4.01 Frameset//EN\" \"http://www.w3.org/TR/html4/frameset.dtd\"")
                    {
                        _doctypeType = HtmlDoctypeType.Html401Frameset;
                    }
                    else if (Doctype == "DOCTYPE html PUBLIC \" -//W3C//DTD XHTML 1.0 Strict//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd\"")
                    {
                        _doctypeType = HtmlDoctypeType.XHtml10Strict;
                    }
                    else if (Doctype == "DOCTYPE html PUBLIC \" -//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd\"")
                    {
                        _doctypeType = HtmlDoctypeType.XHtml10Transitional;
                    }
                    else if (Doctype == "DOCTYPE html PUBLIC \" -//W3C//DTD XHTML 1.0 Frameset//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-frameset.dtd\"")
                    {
                        _doctypeType = HtmlDoctypeType.XHtml10Frameset;
                    }
                    else if (Doctype == "DOCTYPE html PUBLIC \" -//W3C//DTD XHTML 1.1//EN\" \"http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd\"")
                    {
                        _doctypeType = HtmlDoctypeType.XHtml11;
                    }
                    else
                    {
                        _doctypeType = HtmlDoctypeType.Custom;
                    }
                }
                return _doctypeType;
            }
        }

        public override bool Equals(object obj) => Equals(obj as HtmlDoctype);

        public bool Equals(HtmlDoctype other) => other != null && Doctype == other.Doctype;

        public override int GetHashCode() => Doctype.GetHashCode();

        public override HtmlObjectType ObjectType => HtmlObjectType.Doctype;

        internal override void Serialize(StringBuilder builder, HtmlSerializeOptions serializeType)
        {
            builder.Append('<');
            builder.Append('!');
            builder.Append(Doctype);
            builder.Append('>');
        }
    }
}
