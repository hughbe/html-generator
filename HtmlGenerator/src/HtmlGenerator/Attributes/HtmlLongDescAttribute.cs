namespace HtmlGenerator
{
    public class HtmlLongDescAttribute : HtmlAttribute 
    {
        internal HtmlLongDescAttribute() : base("longdesc", "LongDesc", null, false, false) 
        {
        }

        internal HtmlLongDescAttribute(string value) : base("longdesc", "LongDesc", value, false, false) 
        {
        }
    }
}
