namespace HtmlGenerator
{
    public class HtmlDirAttribute : HtmlAttribute 
    {
        public HtmlDirAttribute() : base("dir", "Dir", null, false, true) 
        {
        }

        public HtmlDirAttribute(string value) : base("dir", "Dir", value, false, true) 
        {
        }
    }
}
