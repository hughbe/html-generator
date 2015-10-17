namespace HtmlGenerator
{
    public class HtmlDialogElement : HtmlElement 
    {
        internal HtmlDialogElement() : base("dialog", false) 
        {    
        }

		public HtmlDialogElement WithOpenAttribute(string value) => (HtmlDialogElement)WithAttribute(Attribute.Open(value));
    }
}
