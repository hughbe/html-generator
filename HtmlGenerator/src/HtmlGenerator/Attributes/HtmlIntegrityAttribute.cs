namespace HtmlGenerator
{
    public class HtmlIntegrityAttribute : HtmlAttribute 
    {
        internal HtmlIntegrityAttribute() : base("integrity", "Integrity", null, false, false) 
        {
        }

        internal HtmlIntegrityAttribute(string value) : base("integrity", "Integrity", value, false, false) 
        {
        }
    }
}
