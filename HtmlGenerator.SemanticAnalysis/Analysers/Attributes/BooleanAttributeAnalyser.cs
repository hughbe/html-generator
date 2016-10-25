using HtmlGenerator.Extensions;

namespace HtmlGenerator.SemanticAnalysis.Analysers.Attributes
{
    public class BooleanAttributeAnalyser : IAttributeAnalyser
    {
        public bool IsValid(string name, string value)
        {
            // 2.4.2 Boolean attributes
            if (string.IsNullOrEmpty(value))
            {
                return true;
            }

            return StringExtensions.EqualsAsciiOrdinalIgnoreCase(name, value);
        }
    }
}
