namespace HtmlGenerator
{
    public class HtmlContentEditableAttribute : HtmlAttribute 
    {
        internal HtmlContentEditableAttribute() : base("contentEditable", "ContentEditable", null, false) 
        {
        }

        internal HtmlContentEditableAttribute(string value) : base("contentEditable", "ContentEditable", value, false) 
        {
        }
    }
}
