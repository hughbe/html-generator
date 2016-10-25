namespace HtmlGenerator.SemanticAnalysis.Analysers.Attributes
{
    public class HashNameAttributeAnalyser : IAttributeAnalyser
    {
        public bool IsValid(string name, string value)
        {
            if (value.Length <= 1)
            {
                return false;
            }
            if (value[0] != '#')
            {
                return false;
            }

            return new IdAttributeAnalyser().IsValid(name, value.Substring(1, value.Length - 1));
        }
    }
}
