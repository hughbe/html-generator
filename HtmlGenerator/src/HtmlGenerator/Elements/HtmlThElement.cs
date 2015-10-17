namespace HtmlGenerator
{
    public class HtmlThElement : HtmlElement 
    {
        internal HtmlThElement() : base("th", false) 
        {    
        }

		public HtmlThElement WithColSpanAttribute(string value) => (HtmlThElement)WithAttribute(Attribute.ColSpan(value));

		public HtmlThElement WithHeadersAttribute(string value) => (HtmlThElement)WithAttribute(Attribute.Headers(value));

		public HtmlThElement WithRowSpanAttribute(string value) => (HtmlThElement)WithAttribute(Attribute.RowSpan(value));

		public HtmlThElement WithScopeAttribute(string value) => (HtmlThElement)WithAttribute(Attribute.Scope(value));
    }
}
