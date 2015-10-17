namespace HtmlGenerator
{
    public class HtmlScriptElement : HtmlElement 
    {
        internal HtmlScriptElement() : base("script", false) 
        {    
        }

		public HtmlScriptElement WithAsync(string value) => (HtmlScriptElement)WithAttribute(Attribute.Async(value));

		public HtmlScriptElement WithCrossOrigin(string value) => (HtmlScriptElement)WithAttribute(Attribute.CrossOrigin(value));

		public HtmlScriptElement WithDefer(string value) => (HtmlScriptElement)WithAttribute(Attribute.Defer(value));

		public HtmlScriptElement WithIntegrity(string value) => (HtmlScriptElement)WithAttribute(Attribute.Integrity(value));

		public HtmlScriptElement WithSrc(string value) => (HtmlScriptElement)WithAttribute(Attribute.Src(value));

		public HtmlScriptElement WithText(string value) => (HtmlScriptElement)WithAttribute(Attribute.Text(value));

		public HtmlScriptElement WithType(string value) => (HtmlScriptElement)WithAttribute(Attribute.Type(value));

		public HtmlScriptElement WithAccessKey(string value) => (HtmlScriptElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlScriptElement WithClass(string value) => (HtmlScriptElement)WithAttribute(Attribute.Class(value));

		public HtmlScriptElement WithContentEditable(string value) => (HtmlScriptElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlScriptElement WithContextMenu(string value) => (HtmlScriptElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlScriptElement WithDir(string value) => (HtmlScriptElement)WithAttribute(Attribute.Dir(value));

		public HtmlScriptElement WithHidden(string value) => (HtmlScriptElement)WithAttribute(Attribute.Hidden(value));

		public HtmlScriptElement WithId(string value) => (HtmlScriptElement)WithAttribute(Attribute.Id(value));

		public HtmlScriptElement WithLang(string value) => (HtmlScriptElement)WithAttribute(Attribute.Lang(value));

		public HtmlScriptElement WithSpellCheck(string value) => (HtmlScriptElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlScriptElement WithStyle(string value) => (HtmlScriptElement)WithAttribute(Attribute.Style(value));

		public HtmlScriptElement WithTabIndex(string value) => (HtmlScriptElement)WithAttribute(Attribute.TabIndex(value));
    }
}
