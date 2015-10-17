namespace HtmlGenerator
{
    public class HtmlCanvasElement : HtmlElement 
    {
        internal HtmlCanvasElement() : base("canvas", false) 
        {    
        }

		public HtmlCanvasElement WithHeightAttribute(string value) => (HtmlCanvasElement)WithAttribute(Attribute.Height(value));

		public HtmlCanvasElement WithWidthAttribute(string value) => (HtmlCanvasElement)WithAttribute(Attribute.Width(value));
    }
}
