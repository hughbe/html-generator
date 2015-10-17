namespace HtmlGenerator
{
    public class HtmlAutoCompleteAttribute : HtmlAttribute 
    {
        internal HtmlAutoCompleteAttribute() : base("autocomplete", "AutoComplete", null, false, false) 
        {
        }

        internal HtmlAutoCompleteAttribute(string value) : base("autocomplete", "AutoComplete", value, false, false) 
        {
        }
    }
}
