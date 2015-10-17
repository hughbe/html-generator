namespace HtmlGenerator
{
    public class HtmlAudioElement : HtmlElement 
    {
        internal HtmlAudioElement() : base("audio", false) 
        {    
        }

		public HtmlAudioElement WithAutoPlayAttribute(string value) => (HtmlAudioElement)WithAttribute(Attribute.AutoPlay(value));

		public HtmlAudioElement WithControlsAttribute() => (HtmlAudioElement)WithAttribute(Attribute.Controls);

		public HtmlAudioElement WithLoopAttribute(string value) => (HtmlAudioElement)WithAttribute(Attribute.Loop(value));

		public HtmlAudioElement WithMutedAttribute(string value) => (HtmlAudioElement)WithAttribute(Attribute.Muted(value));

		public HtmlAudioElement WithPreloadAttribute(string value) => (HtmlAudioElement)WithAttribute(Attribute.Preload(value));

		public HtmlAudioElement WithSrcAttribute(string value) => (HtmlAudioElement)WithAttribute(Attribute.Src(value));

		public HtmlAudioElement WithVolumeAttribute(string value) => (HtmlAudioElement)WithAttribute(Attribute.Volume(value));

		public HtmlAudioElement WithAccessKey(string value) => (HtmlAudioElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlAudioElement WithClass(string value) => (HtmlAudioElement)WithAttribute(Attribute.Class(value));

		public HtmlAudioElement WithContentEditable(string value) => (HtmlAudioElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlAudioElement WithContextMenuAttribute(string value) => (HtmlAudioElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlAudioElement WithDir(string value) => (HtmlAudioElement)WithAttribute(Attribute.Dir(value));

		public HtmlAudioElement WithHidden(string value) => (HtmlAudioElement)WithAttribute(Attribute.Hidden(value));

		public HtmlAudioElement WithId(string value) => (HtmlAudioElement)WithAttribute(Attribute.Id(value));

		public HtmlAudioElement WithLang(string value) => (HtmlAudioElement)WithAttribute(Attribute.Lang(value));

		public HtmlAudioElement WithSpellCheck(string value) => (HtmlAudioElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlAudioElement WithStyleAttribute(string value) => (HtmlAudioElement)WithAttribute(Attribute.Style(value));

		public HtmlAudioElement WithTabIndex(string value) => (HtmlAudioElement)WithAttribute(Attribute.TabIndex(value));
    }
}
