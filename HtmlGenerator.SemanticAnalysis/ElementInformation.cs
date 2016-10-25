using System.Collections.Generic;
using System.Linq;

namespace HtmlGenerator.SemanticAnalysis
{
    public class ElementInformation
    {
        internal ElementInformation(string tag,
            ElementCategory category, ElementCategory parentCategory, ElementCategory childrenCategory,
            IEnumerable<string> requiredAttributes = null, IEnumerable<string> requiredElements = null,
            IEnumerable<string> attributes = null, IEnumerable<string> ariaRoleAttributes = null,
            SupportedStatus supportedStatus = SupportedStatus.Supported,
            bool isVoid = false)
        {
            Tag = tag;

            Category = category;
            ParentCategory = parentCategory;
            ChildrenCategory = childrenCategory;

            RequiredAttributes = requiredAttributes ?? Enumerable.Empty<string>();
            RequiredElements = requiredElements ?? Enumerable.Empty<string>();

            Attributes = attributes ?? Enumerable.Empty<string>();
            AriaRoleAttributes = ariaRoleAttributes ?? Enumerable.Empty<string>();

            IsVoid = isVoid;
            SupportedStatus = supportedStatus;
        }

        public string Tag { get; }

        public ElementCategory Category { get; }
        public ElementCategory ParentCategory { get; }
        public ElementCategory ChildrenCategory { get; }

        public IEnumerable<string> RequiredAttributes { get; }
        public IEnumerable<string> RequiredElements { get; }

        public IEnumerable<string> Attributes { get; }
        public IEnumerable<string> AriaRoleAttributes { get; }

        public SupportedStatus SupportedStatus { get; }

        public bool IsVoid { get; }
    }
}
