namespace HtmlGenerator
{
    public class HtmlXmlsAttribute : HtmlAttribute 
    {
        public HtmlXmlsAttribute() : base("xmls", "Xmls", null, false, false) 
        {
        }

        public HtmlXmlsAttribute(string value) : base("xmls", "Xmls", value, false, false) 
        {
        }
    }
}
