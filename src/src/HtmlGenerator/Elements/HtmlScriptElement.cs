using System.Collections.ObjectModel;

namespace HtmlGenerator
{
    public class HtmlScriptElement : HtmlElement 
    {
        public HtmlScriptElement() : base("script", false) 
        {    
        }

        public new HtmlScriptElement WithChild(HtmlElement child) => (HtmlScriptElement)base.WithChild(child);
        public new HtmlScriptElement WithChildren(Collection<HtmlElement> children) => (HtmlScriptElement)base.WithChildren(children);

        public new HtmlScriptElement WithInnerText(string innerText) => (HtmlScriptElement)base.WithInnerText(innerText);

        public new HtmlScriptElement WithAttribute(HtmlAttribute attribute) => (HtmlScriptElement)base.WithAttribute(attribute);
        public new HtmlScriptElement WithAttributes(Collection<HtmlAttribute> attributes) => (HtmlScriptElement)base.WithAttributes(attributes);

		public HtmlScriptElement WithAsync(string value) => WithAttribute(Attribute.Async(value));

		public HtmlScriptElement WithCrossOrigin(string value) => WithAttribute(Attribute.CrossOrigin(value));

		public HtmlScriptElement WithDefer(string value) => WithAttribute(Attribute.Defer(value));

		public HtmlScriptElement WithIntegrity(string value) => WithAttribute(Attribute.Integrity(value));

		public HtmlScriptElement WithSrc(string value) => WithAttribute(Attribute.Src(value));

		public HtmlScriptElement WithText(string value) => WithAttribute(Attribute.Text(value));

		public HtmlScriptElement WithType(string value) => WithAttribute(Attribute.Type(value));

		public HtmlScriptElement WithAccessKey(string value) => WithAttribute(Attribute.AccessKey(value));

		public HtmlScriptElement WithClass(string value) => WithAttribute(Attribute.Class(value));

		public HtmlScriptElement WithContentEditable(string value) => WithAttribute(Attribute.ContentEditable(value));

		public HtmlScriptElement WithContextMenu(string value) => WithAttribute(Attribute.ContextMenu(value));

		public HtmlScriptElement WithDir(string value) => WithAttribute(Attribute.Dir(value));

		public HtmlScriptElement WithHidden(string value) => WithAttribute(Attribute.Hidden(value));

		public HtmlScriptElement WithId(string value) => WithAttribute(Attribute.Id(value));

		public HtmlScriptElement WithLang(string value) => WithAttribute(Attribute.Lang(value));

		public HtmlScriptElement WithSpellCheck(string value) => WithAttribute(Attribute.SpellCheck(value));

		public HtmlScriptElement WithStyle(string value) => WithAttribute(Attribute.Style(value));

		public HtmlScriptElement WithTabIndex(string value) => WithAttribute(Attribute.TabIndex(value));
    }
}
