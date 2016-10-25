using System;

namespace HtmlGenerator.SemanticAnalysis.Analysers.Attributes
{
    internal class UrlAttributeAnalyser : IAttributeAnalyser
    {
        private UriKind AllowedKind { get; }
        private bool AllowEmpty { get; }

        public UrlAttributeAnalyser(UriKind allowedKind, bool allowEmpty)
        {
            AllowedKind = allowedKind;
            AllowEmpty = allowEmpty;
        }

        public bool IsValid(string name, string value)
        {
            value = value.Trim();
            if (AllowEmpty && (value.Length == 0))
            {
                return true;
            }

            Uri dummy;
            return Uri.TryCreate(value, AllowedKind, out dummy);
        }
    }
}
