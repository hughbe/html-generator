using System.Collections.Generic;

namespace HtmlGenerator
{
    public class HtmlAudioElement : HtmlElement
    {
        public HtmlAudioElement() : base("audio", false) 
        {    
        }

        public new HtmlAudioElement WithElement(HtmlElement element) => (HtmlAudioElement)base.WithElement(element);
        public new HtmlAudioElement WithElements(IEnumerable<HtmlElement> elements) => (HtmlAudioElement)base.WithElements(elements);

        public new HtmlAudioElement WithInnerText(string innerText) => (HtmlAudioElement)base.WithInnerText(innerText);

        public new HtmlAudioElement WithAttribute(HtmlAttribute attribute) => (HtmlAudioElement)base.WithAttribute(attribute);
        public new HtmlAudioElement WithAttributes(IEnumerable<HtmlAttribute> attributes) => (HtmlAudioElement)base.WithAttributes(attributes);

		public HtmlAudioElement WithAutoPlay(string value) => WithAttribute(Attribute.AutoPlay(value));

		public HtmlAudioElement WithControls() => WithAttribute(Attribute.Controls);

		public HtmlAudioElement WithLoop(string value) => WithAttribute(Attribute.Loop(value));

		public HtmlAudioElement WithMuted(string value) => WithAttribute(Attribute.Muted(value));

		public HtmlAudioElement WithPreload(string value) => WithAttribute(Attribute.Preload(value));

		public HtmlAudioElement WithSrc(string value) => WithAttribute(Attribute.Src(value));

		public HtmlAudioElement WithVolume(string value) => WithAttribute(Attribute.Volume(value));

		public HtmlAudioElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlAudioElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlAudioElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlAudioElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlAudioElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlAudioElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlAudioElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlAudioElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlAudioElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlAudioElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlAudioElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
