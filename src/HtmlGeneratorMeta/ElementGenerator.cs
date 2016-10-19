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
            PropertyInfo[] properties = typeof(MetaElements).GetProperties();

            string list = "";
            foreach (PropertyInfo property in properties)
            {
                ElementInfo htmlObject = property.GetValue(null) as ElementInfo;
                if (htmlObject == null)
                {
                    continue;
                }

                var propertyName = property.Name;

                var propertyCode = GenerateElement(htmlObject, propertyName);
                if (!string.IsNullOrEmpty(PreviousName))
                {
                    propertyCode = Environment.NewLine + propertyCode;
                    if (propertyName[0] != PreviousName[0])
                    {
                        propertyCode = Environment.NewLine + propertyCode;
                    }
                }
                list += propertyCode;

                PreviousName = propertyName;
            }
            list += Environment.NewLine;
            GenerateList("Tag", "public", "partial ", list);
        }

        public string GenerateElement(ElementInfo element, string propertyName)
        {
            string isVoid = element.IsVoid ? "true" : "false";
            string lowerName = element.Name;
            if (element.Attributes.Count == 0)
            {
                return $"        public static HtmlElement {propertyName} => new HtmlElement(\"{lowerName}\", {isVoid});";                
            }

            string className = "Html" + propertyName + "Element";
            string propertyCode = $"        public static {className} {propertyName} => new {className}();";
            string attributesCode = "";
            foreach (string attribute in element.Attributes)
            {
                AttributeInfo attributeInfo = (AttributeInfo)typeof(MetaAttributes).GetProperty(attribute).GetValue(null);
                string attributeCodeFormat = Environment.NewLine + Environment.NewLine + "        ";

                if (attributeInfo.IsVoid)
                {
                    attributeCodeFormat += "public {0} With{1}() => this.WithAttribute(Attribute.{1});";
                }
                else
                {
                    attributeCodeFormat += "public {0} With{1}(string value) => this.WithAttribute(Attribute.{1}(value));";
                }

                attributesCode += string.Format(attributeCodeFormat, className, attribute);
            }

            string code = $@"namespace HtmlGenerator
{{
    public class {className} : HtmlElement
    {{
        public {className}() : base(""{lowerName}"", {isVoid})
        {{
        }}{attributesCode}
    }}
}}
";
            GenerateClass(className, code);
            return propertyCode;
        }
    }
}
