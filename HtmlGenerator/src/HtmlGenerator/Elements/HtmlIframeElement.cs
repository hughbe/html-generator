namespace HtmlGenerator
{
    public class HtmlIframeElement : HtmlElement 
    {
        internal HtmlIframeElement() : base("iframe", false) 
        {    
        }

		public HtmlIframeElement WithAllowFullScreenAttribute() => (HtmlIframeElement)WithAttribute(Attribute.AllowFullScreen);

		public HtmlIframeElement WithHeightAttribute(string value) => (HtmlIframeElement)WithAttribute(Attribute.Height(value));

		public HtmlIframeElement WithNameAttribute(string value) => (HtmlIframeElement)WithAttribute(Attribute.Name(value));

		public HtmlIframeElement WithSandboxAttribute() => (HtmlIframeElement)WithAttribute(Attribute.Sandbox);

		public HtmlIframeElement WithSeamlessAttribute() => (HtmlIframeElement)WithAttribute(Attribute.Seamless);

		public HtmlIframeElement WithSrcAttribute(string value) => (HtmlIframeElement)WithAttribute(Attribute.Src(value));

		public HtmlIframeElement WithSrcDocAttribute(string value) => (HtmlIframeElement)WithAttribute(Attribute.SrcDoc(value));

		public HtmlIframeElement WithWidthAttribute(string value) => (HtmlIframeElement)WithAttribute(Attribute.Width(value));
    }
}
