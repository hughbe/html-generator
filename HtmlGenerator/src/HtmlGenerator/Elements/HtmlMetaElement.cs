namespace HtmlGenerator
{
    public class HtmlMetaElement : HtmlElement 
    {
        internal HtmlMetaElement() : base("meta", true) 
        {    
        }

		public HtmlMetaElement WithCharsetAttribute(string value) => (HtmlMetaElement)WithAttribute(Attribute.Charset(value));

		public HtmlMetaElement WithContentAttribute(string value) => (HtmlMetaElement)WithAttribute(Attribute.Content(value));

		public HtmlMetaElement WithHttpEquivAttribute(string value) => (HtmlMetaElement)WithAttribute(Attribute.HttpEquiv(value));

		public HtmlMetaElement WithDefaultStyleAttribute(string value) => (HtmlMetaElement)WithAttribute(Attribute.DefaultStyle(value));

		public HtmlMetaElement WithRefreshAttribute(string value) => (HtmlMetaElement)WithAttribute(Attribute.Refresh(value));

		public HtmlMetaElement WithNameAttribute(string value) => (HtmlMetaElement)WithAttribute(Attribute.Name(value));
    }
}
