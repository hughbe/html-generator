namespace HtmlGenerator.SemanticAnalysis.Analysers
{
    public class HtmlAttributeAnalyser
    {
        public static bool IsValid(HtmlAttribute attribute)
        {
            AttributeInformation attributeInformation = Sema.GetAttributeInformation(attribute.Name);
            if (attributeInformation == null)
            {
                // No such attribute
                return false;
            }
            if (attribute.IsVoid && (attributeInformation.ValueType != AttributeValueType.Boolean))
            {
                // A non-void attribute was void
                return false;
            }

            return attributeInformation.Analyser.IsValid(attribute.Name, attribute.Value);
        }
    }
}
