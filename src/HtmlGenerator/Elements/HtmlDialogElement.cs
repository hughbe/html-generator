namespace HtmlGenerator
{
    public class HtmlDialogElement : HtmlElement
    {
        public HtmlDialogElement() : base("dialog") { }

        public HtmlDialogElement WithOpen(string value) => this.WithAttribute(Attribute.Open(value));
    }
}
