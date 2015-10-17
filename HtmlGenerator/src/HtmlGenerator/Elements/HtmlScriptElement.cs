namespace HtmlGenerator
{
    public class HtmlScriptElement : HtmlElement 
    {
        internal HtmlScriptElement() : base("script", false) 
        {    
        }

		public HtmlScriptElement WithAsyncAttribute(string value) => (HtmlScriptElement)WithAttribute(Attribute.Async(value));

		public HtmlScriptElement WithIntegrityAttribute(string value) => (HtmlScriptElement)WithAttribute(Attribute.Integrity(value));

		public HtmlScriptElement WithSrcAttribute(string value) => (HtmlScriptElement)WithAttribute(Attribute.Src(value));

		public HtmlScriptElement WithTypeAttribute(string value) => (HtmlScriptElement)WithAttribute(Attribute.Type(value));

		public HtmlScriptElement WithTextAttribute(string value) => (HtmlScriptElement)WithAttribute(Attribute.Text(value));

		public HtmlScriptElement WithDeferAttribute(string value) => (HtmlScriptElement)WithAttribute(Attribute.Defer(value));

		public HtmlScriptElement WithCrossOriginAttribute(string value) => (HtmlScriptElement)WithAttribute(Attribute.CrossOrigin(value));
    }
}
