namespace HtmlGenerator
{
    public class HtmlVolumeAttribute : HtmlAttribute 
    {
        public HtmlVolumeAttribute() : base("volume", "Volume", null, false, false) 
        {
        }

        public HtmlVolumeAttribute(string value) : base("volume", "Volume", value, false, false) 
        {
        }
    }
}
