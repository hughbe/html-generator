using System.Collections.ObjectModel;

namespace HtmlGenerator
{
    public class HtmlArticleElement : HtmlElement 
    {
        public HtmlArticleElement() : base("article", false) 
        {    
        }

        public new HtmlArticleElement WithChild(HtmlElement child) => (HtmlArticleElement)base.WithChild(child);
        public new HtmlArticleElement WithChildren(Collection<HtmlElement> children) => (HtmlArticleElement)base.WithChildren(children);

        public new HtmlArticleElement WithInnerText(string innerText) => (HtmlArticleElement)base.WithInnerText(innerText);

        public new HtmlArticleElement WithAttribute(HtmlAttribute attribute) => (HtmlArticleElement)base.WithAttribute(attribute);
        public new HtmlArticleElement WithAttributes(Collection<HtmlAttribute> attributes) => (HtmlArticleElement)base.WithAttributes(attributes);

		public HtmlArticleElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlArticleElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlArticleElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlArticleElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlArticleElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlArticleElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlArticleElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlArticleElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlArticleElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlArticleElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlArticleElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
