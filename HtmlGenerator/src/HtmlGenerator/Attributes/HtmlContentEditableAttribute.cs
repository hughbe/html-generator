namespace HtmlGenerator
{
    public class HtmlContentEditableAttribute : HtmlAttribute 
    {
        internal HtmlContentEditableAttribute() : base("contentEditable", "ContentEditable", null, false, true) 
        {
        }

        internal HtmlContentEditableAttribute(string value) : base("contentEditable", "ContentEditable", value, false, true) 
        {
        }
    }
}
