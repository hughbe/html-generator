namespace HtmlGenerator
{
    public class HtmlImgElement : HtmlElement 
    {
        internal HtmlImgElement() : base("img", true) 
        {    
        }

		public HtmlImgElement WithAltAttribute(string value) => (HtmlImgElement)WithAttribute(Attribute.Alt(value));

		public HtmlImgElement WithCrossOriginAttribute(string value) => (HtmlImgElement)WithAttribute(Attribute.CrossOrigin(value));

		public HtmlImgElement WithHeightAttribute(string value) => (HtmlImgElement)WithAttribute(Attribute.Height(value));

		public HtmlImgElement WithIsMapAttribute(string value) => (HtmlImgElement)WithAttribute(Attribute.IsMap(value));

		public HtmlImgElement WithLongDescAttribute(string value) => (HtmlImgElement)WithAttribute(Attribute.LongDesc(value));

		public HtmlImgElement WithSizesAttribute(string value) => (HtmlImgElement)WithAttribute(Attribute.Sizes(value));

		public HtmlImgElement WithSrcAttribute(string value) => (HtmlImgElement)WithAttribute(Attribute.Src(value));

		public HtmlImgElement WithSrcSetAttribute(string value) => (HtmlImgElement)WithAttribute(Attribute.SrcSet(value));

		public HtmlImgElement WithWidthAttribute(string value) => (HtmlImgElement)WithAttribute(Attribute.Width(value));

		public HtmlImgElement WithUseMapAttribute(string value) => (HtmlImgElement)WithAttribute(Attribute.UseMap(value));
    }
}
