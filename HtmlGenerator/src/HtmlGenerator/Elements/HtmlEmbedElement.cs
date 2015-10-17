namespace HtmlGenerator
{
    public class HtmlEmbedElement : HtmlElement 
    {
        internal HtmlEmbedElement() : base("embed", true) 
        {    
        }

		public HtmlEmbedElement WithHeightAttribute(string value) => (HtmlEmbedElement)WithAttribute(Attribute.Height(value));

		public HtmlEmbedElement WithSrcAttribute(string value) => (HtmlEmbedElement)WithAttribute(Attribute.Src(value));

		public HtmlEmbedElement WithTypeAttribute(string value) => (HtmlEmbedElement)WithAttribute(Attribute.Type(value));

		public HtmlEmbedElement WithWidthAttribute(string value) => (HtmlEmbedElement)WithAttribute(Attribute.Width(value));
    }
}
