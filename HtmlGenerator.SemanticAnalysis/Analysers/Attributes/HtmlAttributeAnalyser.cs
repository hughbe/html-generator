namespace HtmlGenerator.SemanticAnalysis.Analysers.Attributes
{
    public class HtmlAttributeAnalyser : IAttributeAnalyser
    {
        public bool IsValid(string name, string value)
        {
            HtmlElement dummy;
            return HtmlElement.TryParse(value, out dummy);
        }
    }
}
