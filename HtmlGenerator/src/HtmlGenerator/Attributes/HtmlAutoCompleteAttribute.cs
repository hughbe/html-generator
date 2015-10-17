namespace HtmlGenerator
{
    public class HtmlAutoCompleteAttribute : HtmlAttribute 
    {
        public HtmlAutoCompleteAttribute() : base("autocomplete", "AutoComplete", null, false, false) 
        {
        }

        public HtmlAutoCompleteAttribute(string value) : base("autocomplete", "AutoComplete", value, false, false) 
        {
        }
    }
}
