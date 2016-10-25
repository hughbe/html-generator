using System;

namespace HtmlGenerator.SemanticAnalysis.Analysers.Attributes
{
    public class SpaceArrayAttributeAnalyser : IAttributeAnalyser
    {
        public IAttributeAnalyser Analyser { get; }
        public bool AllowEmpty { get; }

        public SpaceArrayAttributeAnalyser(IAttributeAnalyser analyser, bool allowEmpty)
        {
            Analyser = analyser;
            AllowEmpty = allowEmpty;
        }

        private static readonly char[] s_separator = new char[] { ' ', '\t', '\n', '\r', '\v', '\b' };

        public bool IsValid(string name, string value)
        {
            value = value.Trim();
            if (value.Length == 0)
            {
                return AllowEmpty;
            }

            string[] values = value.Split(s_separator, StringSplitOptions.RemoveEmptyEntries);
            foreach (string individualValue in values)
            {
                if (!Analyser.IsValid(name, individualValue))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
