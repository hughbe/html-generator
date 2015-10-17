namespace HtmlGenerator
{
    public class HtmlDownloadAttribute : HtmlAttribute 
    {
        internal HtmlDownloadAttribute() : base("download", "Download", null, false, false) 
        {
        }

        internal HtmlDownloadAttribute(string value) : base("download", "Download", value, false, false) 
        {
        }
    }
}
