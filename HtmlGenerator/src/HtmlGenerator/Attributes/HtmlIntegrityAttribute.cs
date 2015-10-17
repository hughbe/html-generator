namespace HtmlGenerator
{
    public class HtmlIntegrityAttribute : HtmlAttribute 
    {
        public HtmlIntegrityAttribute() : base("integrity", "Integrity", null, false, false) 
        {
        }

        public HtmlIntegrityAttribute(string value) : base("integrity", "Integrity", value, false, false) 
        {
        }
    }
}
