namespace HtmlGenerator
{
    public class HtmlSpellCheckAttribute : HtmlAttribute 
    {
        public HtmlSpellCheckAttribute() : base("spellCheck", "SpellCheck", null, false, true) 
        {
        }

        public HtmlSpellCheckAttribute(string value) : base("spellCheck", "SpellCheck", value, false, true) 
        {
        }
    }
}
