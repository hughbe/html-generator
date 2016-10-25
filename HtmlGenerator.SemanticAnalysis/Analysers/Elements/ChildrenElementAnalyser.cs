using System.Collections.Generic;
using System.Linq;
using HtmlGenerator.Extensions;

namespace HtmlGenerator.SemanticAnalysis.Analysers.Elements
{
    public class ChildrenElementAnalyser : IElementAnalyser
    {
        public IEnumerable<string> RequiredElements { get; }

        public ChildrenElementAnalyser(IEnumerable<string> requiredElements = null)
        {
            RequiredElements = requiredElements ?? Enumerable.Empty<string>();
        }

        public bool IsValid(HtmlElement element)
        {
            IEnumerable<HtmlElement> elements = element.Elements().ToArray();
            foreach (string requiredAttribute in RequiredElements)
            {
                if (!elements.Any(child => StringExtensions.EqualsAsciiOrdinalIgnoreCase(child.Tag, requiredAttribute)))
                {
                    return false;
                }
            }

            foreach (HtmlElement childElement in element.Elements())
            {
                if (!HtmlElementAnalyser.IsValid(childElement))
                {
                    // Element is invalid
                    return false;
                }
            }

            return true;
        }
    }
}
