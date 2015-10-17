namespace HtmlGenerator
{
    public class HtmlSpellCheckAttribute : HtmlAttribute 
    {
        internal HtmlSpellCheckAttribute() : base("spellCheck", "SpellCheck", null, false) 
        {
        }

        internal HtmlSpellCheckAttribute(string value) : base("spellCheck", "SpellCheck", value, false) 
        {
        }
    }
}
