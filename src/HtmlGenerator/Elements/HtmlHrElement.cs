namespace HtmlGenerator
{
    public class HtmlHrElement : HtmlElement
    {
        public HtmlHrElement() : base("hr", true)
        {
        }

        public HtmlHrElement WithColor(string value) => this.WithAttribute(Attribute.Color(value));
    }
}
