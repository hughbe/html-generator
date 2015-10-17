namespace HtmlGenerator
{
    public class HtmlRtcElement : HtmlElement 
    {
        public HtmlRtcElement() : base("rtc", false) 
        {    
        }

		public HtmlRtcElement WithAccessKey(string value) => (HtmlRtcElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlRtcElement WithClass(string value) => (HtmlRtcElement)WithAttribute(Attribute.Class(value));

		public HtmlRtcElement WithContentEditable(string value) => (HtmlRtcElement)WithAttribute(Attribute.ContentEditable(value));

		public HtmlRtcElement WithContextMenu(string value) => (HtmlRtcElement)WithAttribute(Attribute.ContextMenu(value));

		public HtmlRtcElement WithDir(string value) => (HtmlRtcElement)WithAttribute(Attribute.Dir(value));

		public HtmlRtcElement WithHidden(string value) => (HtmlRtcElement)WithAttribute(Attribute.Hidden(value));

		public HtmlRtcElement WithId(string value) => (HtmlRtcElement)WithAttribute(Attribute.Id(value));

		public HtmlRtcElement WithLang(string value) => (HtmlRtcElement)WithAttribute(Attribute.Lang(value));

		public HtmlRtcElement WithSpellCheck(string value) => (HtmlRtcElement)WithAttribute(Attribute.SpellCheck(value));

		public HtmlRtcElement WithStyle(string value) => (HtmlRtcElement)WithAttribute(Attribute.Style(value));

		public HtmlRtcElement WithTabIndex(string value) => (HtmlRtcElement)WithAttribute(Attribute.TabIndex(value));
    }
}
