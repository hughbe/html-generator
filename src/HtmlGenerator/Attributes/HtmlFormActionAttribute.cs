namespace HtmlGenerator
{
    public class HtmlFormActionAttribute : HtmlAttribute
    {
        public HtmlFormActionAttribute(string value) : base("formaction", value) {}
    }
}
