namespace HtmlGenerator
{
    public class HtmlReadonlyAttribute : HtmlAttribute 
    {
        public HtmlReadonlyAttribute() : base("readonly", "Readonly", null, true, false) 
        {
        }
    }
}
