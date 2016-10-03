namespace HtmlGenerator
{
    public class HtmlCanvasElement : HtmlElement
    {
        public HtmlCanvasElement() : base("canvas", false) 
        {    
        }

		public HtmlCanvasElement WithHeight(string value) => this.WithAttribute(Attribute.Height(value));

		public HtmlCanvasElement WithWidth(string value) => this.WithAttribute(Attribute.Width(value));
    }
}
