namespace HtmlGenerator
{
    public class HtmlEncTypeAttribute : HtmlAttribute 
    {
        internal HtmlEncTypeAttribute() : base("enctype", "EncType", null, false, false) 
        {
        }

        internal HtmlEncTypeAttribute(string value) : base("enctype", "EncType", value, false, false) 
        {
        }
    }
}
