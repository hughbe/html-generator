using System.Collections.ObjectModel;

namespace HtmlGenerator
{
    public class HtmlImgElement : HtmlElement 
    {
        public HtmlImgElement() : base("img", true) 
        {    
        }

        public new HtmlImgElement WithChild(HtmlElement child) => (HtmlImgElement)base.WithChild(child);
        public new HtmlImgElement WithChildren(Collection<HtmlElement> children) => (HtmlImgElement)base.WithChildren(children);

        public new HtmlImgElement WithInnerText(string innerText) => (HtmlImgElement)base.WithInnerText(innerText);

        public new HtmlImgElement WithAttribute(HtmlAttribute attribute) => (HtmlImgElement)base.WithAttribute(attribute);
        public new HtmlImgElement WithAttributes(Collection<HtmlAttribute> attributes) => (HtmlImgElement)base.WithAttributes(attributes);

		public HtmlImgElement WithAlt(string value) => WithAttribute(Attribute.Alt(value));

		public HtmlImgElement WithCrossOrigin(string value) => WithAttribute(Attribute.CrossOrigin(value));

		public HtmlImgElement WithHeight(string value) => WithAttribute(Attribute.Height(value));

		public HtmlImgElement WithIsMap(string value) => WithAttribute(Attribute.IsMap(value));

		public HtmlImgElement WithLongDesc(string value) => WithAttribute(Attribute.LongDesc(value));

		public HtmlImgElement WithSizes(string value) => WithAttribute(Attribute.Sizes(value));

		public HtmlImgElement WithSrc(string value) => WithAttribute(Attribute.Src(value));

		public HtmlImgElement WithSrcSet(string value) => WithAttribute(Attribute.SrcSet(value));

		public HtmlImgElement WithWidth(string value) => WithAttribute(Attribute.Width(value));

		public HtmlImgElement WithUseMap(string value) => WithAttribute(Attribute.UseMap(value));

		public HtmlImgElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlImgElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlImgElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlImgElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlImgElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlImgElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlImgElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlImgElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlImgElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlImgElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlImgElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
