namespace HtmlGenerator.SemanticAnalysis.Analysers.Attributes
{
    public class StepAttributeAnalyser : IAttributeAnalyser
    {
        private static readonly IAttributeAnalyser s_floatAnalyzer = new FloatingPointAttributeAnalyser(allowNegative: false, allowZero: false);

        public bool IsValid(string name, string value)
        {
            if (value == "any")
            {
                return true;
            }

            return s_floatAnalyzer.IsValid(name, value);
        }
    }
}
