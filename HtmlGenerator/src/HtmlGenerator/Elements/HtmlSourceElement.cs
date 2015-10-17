namespace HtmlGenerator
{
    public class HtmlSourceElement : HtmlElement 
    {
        internal HtmlSourceElement() : base("source", true) 
        {    
        }

		public HtmlSourceElement WithSrcAttribute(string value) => (HtmlSourceElement)WithAttribute(Attribute.Src(value));

		public HtmlSourceElement WithTypeAttribute(string value) => (HtmlSourceElement)WithAttribute(Attribute.Type(value));
    }
}
