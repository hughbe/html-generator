using System;
using System.Text;

namespace HtmlGenerator
{
    public class HtmlDoctype : HtmlNode, IEquatable<HtmlDoctype>
    {
        public HtmlDoctype(HtmlDoctypeType doctype)
        {
            switch (doctype)
            {
                case HtmlDoctypeType.Html5:
                    Doctype = "DOCTYPE html";
                    break;
                case HtmlDoctypeType.Html401Strict:
                    Doctype = "DOCTYPE HTML PUBLIC \" -//W3C//DTD HTML 4.01//EN\" \"http://www.w3.org/TR/html4/strict.dtd\"";
                    break;
                case HtmlDoctypeType.Html401Transitional:
                    Doctype = "DOCTYPE HTML PUBLIC \" -//W3C//DTD HTML 4.01 Transitional//EN\" \"http://www.w3.org/TR/html4/loose.dtd\"";
                    break;
                case HtmlDoctypeType.Html401Frameset:
                    Doctype = "DOCTYPE HTML PUBLIC \" -//W3C//DTD HTML 4.01 Frameset//EN\" \"http://www.w3.org/TR/html4/frameset.dtd\"";
                    break;
                case HtmlDoctypeType.XHtml10Strict:
                    Doctype = "DOCTYPE html PUBLIC \" -//W3C//DTD XHTML 1.0 Strict//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd\"";
                    break;
                case HtmlDoctypeType.XHtml10Transitional:
                    Doctype = "DOCTYPE html PUBLIC \" -//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd\"";
                    break;
                case HtmlDoctypeType.XHtml10Frameset:
                    Doctype = "DOCTYPE html PUBLIC \" -//W3C//DTD XHTML 1.0 Frameset//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-frameset.dtd\"";
                    break;
                case HtmlDoctypeType.XHtml11:
                    Doctype = "DOCTYPE html PUBLIC \" -//W3C//DTD XHTML 1.1//EN\" \"http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd\"";
                    break;
                case HtmlDoctypeType.Custom:
                    throw new ArgumentException("A custom doctype must have a provided string.", nameof(doctype));
                default:
                    throw new ArgumentException("Can't infer the doctype from the HtmlDoctypeType provided.", nameof(doctype));
            }

            _doctypeType = doctype;
        }

        public HtmlDoctype(string doctype)
        {
            Requires.NotNullOrWhitespace(doctype, nameof(doctype));
            Doctype = doctype;
            _doctypeType = (HtmlDoctypeType)(-1);
        }

        public override HtmlObjectType ObjectType => HtmlObjectType.Doctype;

        public string Doctype { get; }

        private HtmlDoctypeType _doctypeType;
        public HtmlDoctypeType DoctypeType
        {
            get
            {
                if (_doctypeType == (HtmlDoctypeType)(-1))
                {
                    switch (Doctype)
                    {
                        case "DOCTYPE html":
                            _doctypeType = HtmlDoctypeType.Html5;
                            break;
                        case "DOCTYPE HTML PUBLIC \" -//W3C//DTD HTML 4.01//EN\" \"http://www.w3.org/TR/html4/strict.dtd\"":
                            _doctypeType = HtmlDoctypeType.Html401Strict;
                            break;
                        case "DOCTYPE HTML PUBLIC \" -//W3C//DTD HTML 4.01 Transitional//EN\" \"http://www.w3.org/TR/html4/loose.dtd\"":
                            _doctypeType = HtmlDoctypeType.Html401Transitional;
                            break;
                        case "DOCTYPE HTML PUBLIC \" -//W3C//DTD HTML 4.01 Frameset//EN\" \"http://www.w3.org/TR/html4/frameset.dtd\"":
                            _doctypeType = HtmlDoctypeType.Html401Frameset;
                            break;
                        case "DOCTYPE html PUBLIC \" -//W3C//DTD XHTML 1.0 Strict//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd\"":
                            _doctypeType = HtmlDoctypeType.XHtml10Strict;
                            break;
                        case "DOCTYPE html PUBLIC \" -//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd\"":
                            _doctypeType = HtmlDoctypeType.XHtml10Transitional;
                            break;
                        case "DOCTYPE html PUBLIC \" -//W3C//DTD XHTML 1.0 Frameset//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-frameset.dtd\"":
                            _doctypeType = HtmlDoctypeType.XHtml10Frameset;
                            break;
                        case "DOCTYPE html PUBLIC \" -//W3C//DTD XHTML 1.1//EN\" \"http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd\"":
                            _doctypeType = HtmlDoctypeType.XHtml11;
                            break;
                        default:
                            _doctypeType = HtmlDoctypeType.Custom;
                            break;
                    }
                }

                return _doctypeType;
            }
        }

        public override bool Equals(object obj) => Equals(obj as HtmlDoctype);

        public bool Equals(HtmlDoctype other) => (other != null) && (Doctype == other.Doctype);

        public override int GetHashCode() => Doctype.GetHashCode();

        public override void Serialize(StringBuilder builder, int depth, HtmlSerializeOptions serializeOptions)
        {
            AddDepth(builder, depth);
            builder.Append('<');
            builder.Append('!');
            builder.Append(Doctype);
            builder.Append('>');
        }
    }
}
