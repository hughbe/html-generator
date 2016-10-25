namespace HtmlGenerator.SemanticAnalysis.Analysers.Attributes
{
    internal class IntegerAttributeAnalyser : IAttributeAnalyser
    {
        public bool AllowNegative { get; set; }
        public bool AllowZero { get; set; }

        public IntegerAttributeAnalyser(bool allowNegative, bool allowZero)
        {
            AllowNegative = allowNegative;
            AllowZero = allowZero;
        }

        public bool IsValid(string name, string value)
        {
            // 2.4.4.1 Signed integers
            // 2.4.4.2 Non-negative integers
            int result;
            if (!int.TryParse(value, out result))
            {
                return false;
            }
            if ((result == 0) && !AllowZero)
            {
                return false;
            }
            if ((result < 0) && !AllowNegative)
            {
                return false;
            }

            return true;
        }
    }
}
