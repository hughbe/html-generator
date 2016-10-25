namespace HtmlGenerator.Elements
{
    public class HtmlParamElement : HtmlElement
    {
        public HtmlParamElement() : base("param", isVoid: true) { }

        public HtmlParamElement WithName(string value) => this.WithAttribute(Attribute.Name(value));

        public HtmlParamElement WithValue(string value) => this.WithAttribute(Attribute.Value(value));
    }
}
