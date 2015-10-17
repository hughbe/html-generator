namespace HtmlGenerator
{
    public class HtmlAudioElement : HtmlElement 
    {
        public HtmlAudioElement() : base("audio", false) 
        {    
        }

		public HtmlAudioElement WithAutoPlay(string value) => (HtmlAudioElement)WithAttribute(Attribute.AutoPlay(value));

		public HtmlAudioElement WithControls() => (HtmlAudioElement)WithAttribute(Attribute.Controls);

		public HtmlAudioElement WithLoop(string value) => (HtmlAudioElement)WithAttribute(Attribute.Loop(value));

		public HtmlAudioElement WithMuted(string value) => (HtmlAudioElement)WithAttribute(Attribute.Muted(value));

		public HtmlAudioElement WithPreload(string value) => (HtmlAudioElement)WithAttribute(Attribute.Preload(value));

		public HtmlAudioElement WithSrc(string value) => (HtmlAudioElement)WithAttribute(Attribute.Src(value));

		public HtmlAudioElement WithVolume(string value) => (HtmlAudioElement)WithAttribute(Attribute.Volume(value));

		public HtmlAudioElement WithAccessKey(string value) => (HtmlAudioElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlAudioElement WithClass(string value) => (HtmlAudioElement)WithAttribute(Attribute.Class(value));

		public HtmlAudioElement WithContentEditable(string value) => (HtmlAudioElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlAudioElement WithContextMenu(string value) => (HtmlAudioElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlAudioElement WithDir(string value) => (HtmlAudioElement)WithAttribute(Attribute.Dir(value));

		public HtmlAudioElement WithHidden(string value) => (HtmlAudioElement)WithAttribute(Attribute.Hidden(value));

		public HtmlAudioElement WithId(string value) => (HtmlAudioElement)WithAttribute(Attribute.Id(value));

		public HtmlAudioElement WithLang(string value) => (HtmlAudioElement)WithAttribute(Attribute.Lang(value));

		public HtmlAudioElement WithSpellCheck(string value) => (HtmlAudioElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlAudioElement WithStyle(string value) => (HtmlAudioElement)WithAttribute(Attribute.Style(value));

		public HtmlAudioElement WithTabIndex(string value) => (HtmlAudioElement)WithAttribute(Attribute.TabIndex(value));
    }
}
