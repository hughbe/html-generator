using System.Collections.ObjectModel;

namespace HtmlGenerator
{
    public class HtmlVideoElement : HtmlElement 
    {
        public HtmlVideoElement() : base("video", false) 
        {    
        }

        public new HtmlVideoElement WithChild(HtmlElement child) => (HtmlVideoElement)base.WithChild(child);
        public new HtmlVideoElement WithChildren(Collection<HtmlElement> children) => (HtmlVideoElement)base.WithChildren(children);

        public new HtmlVideoElement WithInnerText(string innerText) => (HtmlVideoElement)base.WithInnerText(innerText);

        public new HtmlVideoElement WithAttribute(HtmlAttribute attribute) => (HtmlVideoElement)base.WithAttribute(attribute);
        public new HtmlVideoElement WithAttributes(Collection<HtmlAttribute> attributes) => (HtmlVideoElement)base.WithAttributes(attributes);

		public HtmlVideoElement WithAutoPlay(string value) => WithAttribute(Attribute.AutoPlay(value));

		public HtmlVideoElement WithControls() => WithAttribute(Attribute.Controls);

		public HtmlVideoElement WithCrossOrigin(string value) => WithAttribute(Attribute.CrossOrigin(value));

		public HtmlVideoElement WithHeight(string value) => WithAttribute(Attribute.Height(value));

		public HtmlVideoElement WithLoop(string value) => WithAttribute(Attribute.Loop(value));

		public HtmlVideoElement WithMuted(string value) => WithAttribute(Attribute.Muted(value));

		public HtmlVideoElement WithPreload(string value) => WithAttribute(Attribute.Preload(value));

		public HtmlVideoElement WithSrc(string value) => WithAttribute(Attribute.Src(value));

		public HtmlVideoElement WithWidth(string value) => WithAttribute(Attribute.Width(value));

		public HtmlVideoElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlVideoElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlVideoElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlVideoElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlVideoElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlVideoElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlVideoElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlVideoElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlVideoElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlVideoElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlVideoElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
