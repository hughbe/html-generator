namespace HtmlGenerator.SemanticAnalysis.Analysers.Attributes
{
    public class MediaQueryAttributeAnalyser : IAttributeAnalyser
    {
        public bool IsValid(string name, string value)
        {
            // CSS3 MediaQueries specification
            return true;
        }
    }
}
