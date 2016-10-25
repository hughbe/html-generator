namespace HtmlGenerator.Elements
{
    public class HtmlMapElement : HtmlElement
    {
        public HtmlMapElement() : base("map") { }

        public HtmlMapElement WithName(string value) => this.WithAttribute(Attribute.Name(value));
    }
}
