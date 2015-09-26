namespace HtmlGenerator
{
    public class HtmlFormEncTypeAttribute : HtmlAttribute 
    {
        public HtmlFormEncTypeAttribute() : base("formenctype", "FormEncType", null, false, false) 
        {
        }

        public HtmlFormEncTypeAttribute(string value) : base("formenctype", "FormEncType", value, false, false) 
        {
        }
    }
}
