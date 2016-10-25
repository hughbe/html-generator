namespace HtmlGenerator.SemanticAnalysis.Analysers.Attributes
{
    public class CommaArrayAttributeAnalyser : IAttributeAnalyser
    {
        private IAttributeAnalyser Analyser { get; }

        public CommaArrayAttributeAnalyser(IAttributeAnalyser analyser)
        {
            Analyser = analyser;
        }

        private static readonly char[] s_separator = new char[] { ',' };

        public bool IsValid(string name, string value)
        {
            string[] values = value.Split(s_separator);
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
