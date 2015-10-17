namespace HtmlGenerator
{
    public class HtmlAutoCompleteAttribute : HtmlAttribute 
    {
        internal HtmlAutoCompleteAttribute() : base("autocomplete", "AutoComplete", null, false) 
        {
        }

        internal HtmlAutoCompleteAttribute(string value) : base("autocomplete", "AutoComplete", value, false) 
        {
        }
    }
}
