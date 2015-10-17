namespace HtmlGenerator
{
    public class HtmlReadonlyAttribute : HtmlAttribute 
    {
        internal HtmlReadonlyAttribute() : base("readonly", "Readonly", null, true) 
        {
        }
    }
}
