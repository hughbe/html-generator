namespace HtmlGenerator
{
    public class HtmlTimeElement : HtmlElement
    {
        public HtmlTimeElement() : base("time", false)
        {
        }

        public HtmlTimeElement WithDateTime(string value) => this.WithAttribute(Attribute.DateTime(value));
    }
}
