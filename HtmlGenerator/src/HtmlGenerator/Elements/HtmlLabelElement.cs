namespace HtmlGenerator
{
    public class HtmlLabelElement : HtmlElement 
    {
        internal HtmlLabelElement() : base("label", false) 
        {    
        }

		public HtmlLabelElement WithAccessKeyAttribute(string value) => (HtmlLabelElement)WithAttribute(Attribute.AccessKey(value));

		public HtmlLabelElement WithForAttribute(string value) => (HtmlLabelElement)WithAttribute(Attribute.For(value));

		public HtmlLabelElement WithFormAttribute(string value) => (HtmlLabelElement)WithAttribute(Attribute.Form(value));
    }
}
