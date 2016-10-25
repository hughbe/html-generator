namespace HtmlGenerator.SemanticAnalysis.Analysers.Attributes
{
    public class IdAttributeAnalyser : IAttributeAnalyser
    {
        public bool IsValid(string name, string value)
        {
            if (value.Length == 0)
            {
                return false;
            }

            foreach (char t in value)
            {
                if (char.IsWhiteSpace(t))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
