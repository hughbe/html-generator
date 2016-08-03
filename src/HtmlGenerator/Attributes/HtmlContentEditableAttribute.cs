namespace HtmlGenerator
{
    public class HtmlContentEditableAttribute : HtmlAttribute 
    {
        public HtmlContentEditableAttribute() : base("contentEditable", "ContentEditable", null, false, true) 
        {
        }

        public HtmlContentEditableAttribute(string value) : base("contentEditable", "ContentEditable", value, false, true) 
        {
        }
    }
}
