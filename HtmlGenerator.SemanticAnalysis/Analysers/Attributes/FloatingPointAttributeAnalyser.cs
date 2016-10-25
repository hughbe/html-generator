using System;

namespace HtmlGenerator.SemanticAnalysis.Analysers.Attributes
{
    public class FloatingPointAttributeAnalyser : IAttributeAnalyser
    {
        private bool AllowNegative { get; }
        private bool AllowZero { get; }

        public FloatingPointAttributeAnalyser(bool allowNegative, bool allowZero)
        {
            AllowNegative = allowNegative;
            AllowZero = allowZero;
        }

        public bool IsValid(string name, string value)
        {
            // 2.4.4.3 Floating-point numbers
            float result;
            if (!float.TryParse(value, out result))
            {
                return false;
            }
            if ((Math.Abs(result) < 0.01) && !AllowZero)
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
