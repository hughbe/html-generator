using HtmlGenerator.Meta;
using System.Reflection;
using System;

namespace HtmlGeneratorMeta
{
    public class ElementGenerator : Generator
    {
        public ElementGenerator(string folderPath) : base(folderPath)
        {
        }
        
        public override void Generate()
        {
            PreviousName = null;

            var type = typeof(MetaElements);
            var properties = type.GetProperties();

            var list = "";

            foreach (var property in properties)
            {
                var htmlObject = property.GetValue(null) as ElementInfo;
                if (htmlObject == null)
                {
                    continue;
                }

                var newName = property.Name;

                var propertyCode = GenerateElement(htmlObject, newName);
                list += propertyCode;

                PreviousName = newName;
            }
            list += Environment.NewLine;

            GenerateList("Tag", "public", "partial ", list);
        }

        public string GenerateElement(ElementInfo element, string newName)
        {
            var lowerName = element.Name;
            var isVoid = element.IsVoid ? "true" : "false";
            var className = "Html" + newName + "Element";

            var propertyCode = string.Format("\t\tpublic static {0} {1} => new {0}();", className, newName);

            if (!string.IsNullOrEmpty(PreviousName))
            {
                propertyCode = "\n" + propertyCode;
                if (newName[0] != PreviousName[0])
                {
                    propertyCode = "\n" + propertyCode;
                }
            }

            var attributesCode = "";

            foreach (var attribute in element.Attributes)
            {
                var methodName = attribute;

                AttributeInfo attributeInfo = (AttributeInfo)typeof(MetaAttributes).GetProperty(methodName).GetValue(null);
                var attributeCodeFormat = "\n\n\t\t";
                var methodStart = "";

                if (attributeInfo.IsVoid)
                {
                    attributeCodeFormat += "public {0}{1} With{2}() => WithAttribute(Attribute.{2});";
                }
                else
                {
                    attributeCodeFormat += "public {0}{1} With{2}(string value) => WithAttribute(Attribute.{2}(value));";
                }

                attributesCode += string.Format(attributeCodeFormat, methodStart, className, methodName);
            }

            var code = string.Format(@"using System.Collections.Generic;

namespace HtmlGenerator
{{
    public class {0} : HtmlElement
    {{
        public {0}() : base(""{1}"", {2}) 
        {{    
        }}

        public new {0} WithElement(HtmlElement element) => ({0})base.WithElement(element);
        public new {0} WithElements(IEnumerable<HtmlElement> elements) => ({0})base.WithElements(elements);

        public new {0} WithInnerText(string innerText) => ({0})base.WithInnerText(innerText);

        public new {0} WithAttribute(HtmlAttributeNew attribute) => ({0})base.WithAttribute(attribute);
        public new {0} WithAttributes(IEnumerable<HtmlAttributeNew> attributes) => ({0})base.WithAttributes(attributes);{3}
    }}
}}
", className, lowerName, isVoid, attributesCode);

            GenerateClass(className, code);

            return propertyCode;
        }
    }
}
