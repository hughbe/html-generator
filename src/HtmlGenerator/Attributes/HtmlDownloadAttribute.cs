namespace HtmlGenerator
{
    public class HtmlDownloadAttribute : HtmlAttribute 
    {
        public HtmlDownloadAttribute() : base("download", "Download", null, false, false) 
        {
        }

        public HtmlDownloadAttribute(string value) : base("download", "Download", value, false, false) 
        {
        }
    }
}
