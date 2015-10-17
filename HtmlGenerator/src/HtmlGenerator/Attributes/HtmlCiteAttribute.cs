namespace HtmlGenerator
{
    public class HtmlCiteAttribute : HtmlAttribute 
    {
        internal HtmlCiteAttribute() : base("cite", "Cite", null, false) 
        {
        }

        internal HtmlCiteAttribute(string value) : base("cite", "Cite", value, false) 
        {
        }
    }
}
