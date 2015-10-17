namespace HtmlGenerator
{
    public class HtmlDirAttribute : HtmlAttribute 
    {
        internal HtmlDirAttribute() : base("dir", "Dir", null, false, true) 
        {
        }

        internal HtmlDirAttribute(string value) : base("dir", "Dir", value, false, true) 
        {
        }
    }
}
