namespace HtmlGenerator.SemanticAnalysis.Analysers.Attributes
{
    public class ItemPropAttributeAnalyser : IAttributeAnalyser
    {
        public bool IsValid(string name, string value)
        {
            // Names: the itemprop attribute
            if (value.Length == 0)
            {
                return false;
            }

            foreach (char c in value)
            {
                if ((c == '.') || (c == ':'))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
