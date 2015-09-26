namespace HtmlGenerator
{
    public class HtmlAutoSaveAttribute : HtmlAttribute 
    {
        public HtmlAutoSaveAttribute() : base("autosave", "AutoSave", null, false, false) 
        {
        }

        public HtmlAutoSaveAttribute(string value) : base("autosave", "AutoSave", value, false, false) 
        {
        }
    }
}
