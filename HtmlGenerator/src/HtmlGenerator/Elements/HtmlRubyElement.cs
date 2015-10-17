namespace HtmlGenerator
{
    public class HtmlRubyElement : HtmlElement 
    {
        internal HtmlRubyElement() : base("ruby", false) 
        {    
        }

		public HtmlRubyElement WithAccessKey(string value) => (HtmlRubyElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlRubyElement WithClass(string value) => (HtmlRubyElement)WithAttribute(Attribute.Class(value));

		public HtmlRubyElement WithContentEditable(string value) => (HtmlRubyElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlRubyElement WithContextMenuAttribute(string value) => (HtmlRubyElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlRubyElement WithDir(string value) => (HtmlRubyElement)WithAttribute(Attribute.Dir(value));

		public HtmlRubyElement WithHidden(string value) => (HtmlRubyElement)WithAttribute(Attribute.Hidden(value));

		public HtmlRubyElement WithId(string value) => (HtmlRubyElement)WithAttribute(Attribute.Id(value));

		public HtmlRubyElement WithLang(string value) => (HtmlRubyElement)WithAttribute(Attribute.Lang(value));

		public HtmlRubyElement WithSpellCheck(string value) => (HtmlRubyElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlRubyElement WithStyleAttribute(string value) => (HtmlRubyElement)WithAttribute(Attribute.Style(value));

		public HtmlRubyElement WithTabIndex(string value) => (HtmlRubyElement)WithAttribute(Attribute.TabIndex(value));
    }
}
