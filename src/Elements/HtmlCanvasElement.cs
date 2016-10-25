namespace HtmlGenerator.Elements
{
    public class HtmlCanvasElement : HtmlElement
    {
        public HtmlCanvasElement() : base("canvas") { }

        public HtmlCanvasElement WithHeight(string value) => this.WithAttribute(Attribute.Height(value));

        public HtmlCanvasElement WithWidth(string value) => this.WithAttribute(Attribute.Width(value));
    }
}
