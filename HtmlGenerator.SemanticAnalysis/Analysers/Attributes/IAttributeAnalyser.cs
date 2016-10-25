namespace HtmlGenerator.SemanticAnalysis.Analysers.Attributes
{
    public interface IAttributeAnalyser
    {
        bool IsValid(string name, string value);
    }
}
