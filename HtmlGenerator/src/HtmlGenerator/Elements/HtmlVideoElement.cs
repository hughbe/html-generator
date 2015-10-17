namespace HtmlGenerator
{
    public class HtmlVideoElement : HtmlElement 
    {
        internal HtmlVideoElement() : base("video", false) 
        {    
        }

		public HtmlVideoElement WithAutoPlay(string value) => (HtmlVideoElement)WithAttribute(Attribute.AutoPlay(value));

		public HtmlVideoElement WithControls() => (HtmlVideoElement)WithAttribute(Attribute.Controls);

		public HtmlVideoElement WithCrossOrigin(string value) => (HtmlVideoElement)WithAttribute(Attribute.CrossOrigin(value));

		public HtmlVideoElement WithHeight(string value) => (HtmlVideoElement)WithAttribute(Attribute.Height(value));

		public HtmlVideoElement WithLoop(string value) => (HtmlVideoElement)WithAttribute(Attribute.Loop(value));

		public HtmlVideoElement WithMuted(string value) => (HtmlVideoElement)WithAttribute(Attribute.Muted(value));

		public HtmlVideoElement WithPreload(string value) => (HtmlVideoElement)WithAttribute(Attribute.Preload(value));

		public HtmlVideoElement WithSrc(string value) => (HtmlVideoElement)WithAttribute(Attribute.Src(value));

		public HtmlVideoElement WithWidth(string value) => (HtmlVideoElement)WithAttribute(Attribute.Width(value));

		public HtmlVideoElement WithAccessKey(string value) => (HtmlVideoElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlVideoElement WithClass(string value) => (HtmlVideoElement)WithAttribute(Attribute.Class(value));

		public HtmlVideoElement WithContentEditable(string value) => (HtmlVideoElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlVideoElement WithContextMenu(string value) => (HtmlVideoElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlVideoElement WithDir(string value) => (HtmlVideoElement)WithAttribute(Attribute.Dir(value));

		public HtmlVideoElement WithHidden(string value) => (HtmlVideoElement)WithAttribute(Attribute.Hidden(value));

		public HtmlVideoElement WithId(string value) => (HtmlVideoElement)WithAttribute(Attribute.Id(value));

		public HtmlVideoElement WithLang(string value) => (HtmlVideoElement)WithAttribute(Attribute.Lang(value));

		public HtmlVideoElement WithSpellCheck(string value) => (HtmlVideoElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlVideoElement WithStyle(string value) => (HtmlVideoElement)WithAttribute(Attribute.Style(value));

		public HtmlVideoElement WithTabIndex(string value) => (HtmlVideoElement)WithAttribute(Attribute.TabIndex(value));
    }
}
