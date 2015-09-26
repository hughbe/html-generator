namespace HtmlGenerator
{
    public class HtmlLongDescAttribute : HtmlAttribute 
    {
        public HtmlLongDescAttribute() : base("longdesc", "LongDesc", null, false, false) 
        {
        }

        public HtmlLongDescAttribute(string value) : base("longdesc", "LongDesc", value, false, false) 
        {
        }
    }
}
