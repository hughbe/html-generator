namespace HtmlGenerator.Elements
{
    public class HtmlImgElement : HtmlElement
    {
        public HtmlImgElement() : base("img", isVoid: true) { }

        public HtmlImgElement WithAlt(string value) => this.WithAttribute(Attribute.Alt(value));

        public HtmlImgElement WithCrossOrigin(string value) => this.WithAttribute(Attribute.CrossOrigin(value));

        public HtmlImgElement WithHeight(string value) => this.WithAttribute(Attribute.Height(value));

        public HtmlImgElement WithIsMap(string value) => this.WithAttribute(Attribute.IsMap(value));

        public HtmlImgElement WithLongDesc(string value) => this.WithAttribute(Attribute.LongDesc(value));

        public HtmlImgElement WithSizes(string value) => this.WithAttribute(Attribute.Sizes(value));

        public HtmlImgElement WithSrc(string value) => this.WithAttribute(Attribute.Src(value));

        public HtmlImgElement WithSrcSet(string value) => this.WithAttribute(Attribute.SrcSet(value));

        public HtmlImgElement WithWidth(string value) => this.WithAttribute(Attribute.Width(value));

        public HtmlImgElement WithUseMap(string value) => this.WithAttribute(Attribute.UseMap(value));
    }
}
