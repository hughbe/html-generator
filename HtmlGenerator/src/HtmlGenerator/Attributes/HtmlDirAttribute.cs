namespace HtmlGenerator
{
    public class HtmlDirAttribute : HtmlAttribute 
    {
        internal HtmlDirAttribute() : base("dir", "Dir", null, false) 
        {
        }

        internal HtmlDirAttribute(string value) : base("dir", "Dir", value, false) 
        {
        }
    }
}
