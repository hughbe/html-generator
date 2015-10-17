namespace HtmlGenerator
{
    public class HtmlDlElement : HtmlElement 
    {
        internal HtmlDlElement() : base("dl", false) 
        {    
        }

		public HtmlDlElement WithCompactAttribute(string value) => (HtmlDlElement)WithAttribute(Attribute.Compact(value));
    }
}
