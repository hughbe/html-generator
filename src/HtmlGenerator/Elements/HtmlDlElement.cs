namespace HtmlGenerator
{
    public class HtmlDlElement : HtmlElement
    {
        public HtmlDlElement() : base("dl", false) 
        {    
        }

		public HtmlDlElement WithCompact(string value) => this.WithAttribute(Attribute.Compact(value));
    }
}
