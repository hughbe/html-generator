namespace HtmlGenerator.SemanticAnalysis.Analysers.Attributes
{
    public class TextAttributeAnalyser : IAttributeAnalyser
    {
        public int MinLength { get; }
        public int MaxLength { get; }

        public TextAttributeAnalyser(int minLength, int maxLength)
        {
            MinLength = minLength;
            MaxLength = maxLength;
        }

        public bool IsValid(string name, string value)
        {
            if ((MinLength == 0) && (value == null))
            {
                return false;
            }
            if (MaxLength == -1)
            {
                return value.Length >= MinLength;
            }

            return (value.Length >= MinLength) && (value.Length <= MaxLength);
        }
    }
}
