namespace HtmlGenerator.Elements
{
    public class HtmlOptgroupElement : HtmlElement
    {
        public HtmlOptgroupElement() : base("optgroup") { }

        public HtmlOptgroupElement WithDisabled() => this.WithAttribute(Attribute.Disabled);

        public HtmlOptgroupElement WithLabel(string value) => this.WithAttribute(Attribute.Label(value));
    }
}
