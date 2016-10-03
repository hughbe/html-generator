namespace HtmlGenerator
{
    public class HtmlDialogElement : HtmlElement
    {
        public HtmlDialogElement() : base("dialog", false) 
        {    
        }

		public HtmlDialogElement WithOpen(string value) => this.WithAttribute(Attribute.Open(value));
    }
}
