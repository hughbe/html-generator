namespace HtmlGenerator
{
    public class HtmlCiteAttribute : HtmlAttribute 
    {
        public HtmlCiteAttribute() : base("cite", "Cite", null, false, false) 
        {
        }

        public HtmlCiteAttribute(string value) : base("cite", "Cite", value, false, false) 
        {
        }
    }
}
