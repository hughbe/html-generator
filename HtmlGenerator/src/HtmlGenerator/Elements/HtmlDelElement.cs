namespace HtmlGenerator
{
    public class HtmlDelElement : HtmlElement 
    {
        internal HtmlDelElement() : base("del", false) 
        {    
        }

		public HtmlDelElement WithCiteAttribute(string value) => (HtmlDelElement)WithAttribute(Attribute.Cite(value));

		public HtmlDelElement WithDateTimeAttribute(string value) => (HtmlDelElement)WithAttribute(Attribute.DateTime(value));
    }
}
