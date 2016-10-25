using System.Collections.Generic;
using System.Linq;

namespace HtmlGenerator.SemanticAnalysis.Analysers.Attributes
{
    public class EnumeratedAnalyser : IAttributeAnalyser
    {
        public IEnumerable<string> ValidValues { get; }

        public EnumeratedAnalyser(IEnumerable<string> validValues)
        {
            ValidValues = validValues;
        }

        public bool IsValid(string name, string value)
        {
            // 2.4.3 Keywords and enumerated attributes
            return ValidValues.Contains(value);
        }
    }
}
