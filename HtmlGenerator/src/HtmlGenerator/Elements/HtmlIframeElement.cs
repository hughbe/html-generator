namespace HtmlGenerator
{
    public class HtmlIframeElement : HtmlElement 
    {
        public HtmlIframeElement() : base("iframe", false) 
        {    
        }

		public HtmlIframeElement WithAllowFullScreen() => (HtmlIframeElement)WithAttribute(Attribute.AllowFullScreen);

		public HtmlIframeElement WithHeight(string value) => (HtmlIframeElement)WithAttribute(Attribute.Height(value));

		public HtmlIframeElement WithName(string value) => (HtmlIframeElement)WithAttribute(Attribute.Name(value));

		public HtmlIframeElement WithSandbox() => (HtmlIframeElement)WithAttribute(Attribute.Sandbox);

		public HtmlIframeElement WithSeamless() => (HtmlIframeElement)WithAttribute(Attribute.Seamless);

		public HtmlIframeElement WithSrc(string value) => (HtmlIframeElement)WithAttribute(Attribute.Src(value));

		public HtmlIframeElement WithSrcDoc(string value) => (HtmlIframeElement)WithAttribute(Attribute.SrcDoc(value));

		public HtmlIframeElement WithWidth(string value) => (HtmlIframeElement)WithAttribute(Attribute.Width(value));

		public HtmlIframeElement WithAccessKey(string value) => (HtmlIframeElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlIframeElement WithClass(string value) => (HtmlIframeElement)WithAttribute(Attribute.Class(value));

		public HtmlIframeElement WithContentEditable(string value) => (HtmlIframeElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlIframeElement WithContextMenu(string value) => (HtmlIframeElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlIframeElement WithDir(string value) => (HtmlIframeElement)WithAttribute(Attribute.Dir(value));

		public HtmlIframeElement WithHidden(string value) => (HtmlIframeElement)WithAttribute(Attribute.Hidden(value));

		public HtmlIframeElement WithId(string value) => (HtmlIframeElement)WithAttribute(Attribute.Id(value));

		public HtmlIframeElement WithLang(string value) => (HtmlIframeElement)WithAttribute(Attribute.Lang(value));

		public HtmlIframeElement WithSpellCheck(string value) => (HtmlIframeElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlIframeElement WithStyle(string value) => (HtmlIframeElement)WithAttribute(Attribute.Style(value));

		public HtmlIframeElement WithTabIndex(string value) => (HtmlIframeElement)WithAttribute(Attribute.TabIndex(value));
    }
}
