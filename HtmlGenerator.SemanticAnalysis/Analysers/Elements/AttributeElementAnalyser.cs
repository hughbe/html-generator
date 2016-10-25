using System.Collections.Generic;
using System.Linq;
using HtmlGenerator.Extensions;

namespace HtmlGenerator.SemanticAnalysis.Analysers.Elements
{
    public class AttributeElementAnalyser : IElementAnalyser
    {
        public IEnumerable<string> RequiredAttributes { get; }

        public AttributeElementAnalyser(IEnumerable<string> requiredAttributes = null)
        {
            RequiredAttributes = requiredAttributes ?? Enumerable.Empty<string>();
        }

        public bool IsValid(HtmlElement element)
        {
            IEnumerable<HtmlAttribute> attributes = element.Attributes().ToArray();
            foreach (string requiredAttribute in RequiredAttributes)
            {
                if (!attributes.Any(attribute => StringExtensions.EqualsAsciiOrdinalIgnoreCase(attribute.Name, requiredAttribute)))
                {
                    return false;
                }
            }
            foreach (HtmlAttribute attribute in attributes)
            {
                AttributeInformation attributeInformation = Sema.GetAttributeInformation(attribute.Name);
                if (attributeInformation == null)
                {
                    // No such attribute
                    return false;
                }
                if (attribute.IsVoid && (attributeInformation.ValueType != AttributeValueType.Boolean))
                {
                    // A non-boolean attribute was void
                    return false;
                }
                if (!attributeInformation.Analyser.IsValid(attribute.Name, attribute.Value))
                {
                    // Attribute is invalid
                    return false;
                }
            }

            return true;
        }
    }
}
