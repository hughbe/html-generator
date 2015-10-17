namespace HtmlGenerator
{
    public class HtmlEncTypeAttribute : HtmlAttribute 
    {
        public HtmlEncTypeAttribute() : base("enctype", "EncType", null, false, false) 
        {
        }

        public HtmlEncTypeAttribute(string value) : base("enctype", "EncType", value, false, false) 
        {
        }
    }
}
