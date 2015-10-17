namespace HtmlGenerator
{
    public class HtmlInsElement : HtmlElement 
    {
        internal HtmlInsElement() : base("ins", false) 
        {    
        }

		public HtmlInsElement WithCiteAttribute(string value) => (HtmlInsElement)WithAttribute(Attribute.Cite(value));

		public HtmlInsElement WithDateTimeAttribute(string value) => (HtmlInsElement)WithAttribute(Attribute.DateTime(value));
    }
}
