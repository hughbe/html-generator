namespace HtmlGenerator.Elements
{
    public class HtmlFormElement : HtmlElement
    {
        public HtmlFormElement() : base("form") { }

        public HtmlFormElement WithAcceptCharset(string value) => this.WithAttribute(Attribute.AcceptCharset(value));

        public HtmlFormElement WithAction(string value) => this.WithAttribute(Attribute.Action(value));

        public HtmlFormElement WithAutoComplete(string value) => this.WithAttribute(Attribute.AutoComplete(value));

        public HtmlFormElement WithEncType(string value) => this.WithAttribute(Attribute.EncType(value));

        public HtmlFormElement WithMethod(string value) => this.WithAttribute(Attribute.Method(value));

        public HtmlFormElement WithName(string value) => this.WithAttribute(Attribute.Name(value));

        public HtmlFormElement WithNoValidate() => this.WithAttribute(Attribute.NoValidate);

        public HtmlFormElement WithTarget(string value) => this.WithAttribute(Attribute.Target(value));
    }
}
