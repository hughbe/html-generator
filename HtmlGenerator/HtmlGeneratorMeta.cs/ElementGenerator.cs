using HtmlGenerator.Meta;

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

            GenerateList("Tag", "public", list);
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

                var newLetter = newName.Substring(0, 1);
                var previousLetter = PreviousName.Substring(0, 1);
                if (newLetter != previousLetter)
                {
                    propertyCode = "\n" + propertyCode;
                }
            }

            var attributesCode = "";

            foreach (var attribute in element.Attributes)
            {
                var methodName = attribute.ProperName;

                var attributeCodeFormat = "\n\n\t\t";
                var methodStart = "";
                
                if (attribute.Name.Equals("content"))
                {
                    methodStart = "new ";
                }

                if (attribute.IsVoid)
                {
                    attributeCodeFormat += "public {0}{1} With{2}() => ({1})WithAttribute(Attribute.{2});";
                }
                else
                {
                    attributeCodeFormat += "public {0}{1} With{2}(string value) => ({1})WithAttribute(Attribute.{2}(value));";
                }

                attributesCode += string.Format(attributeCodeFormat, methodStart, className, methodName);
            }

            var code = string.Format(@"namespace HtmlGenerator
{{
    public class {0} : HtmlElement 
    {{
        public {0}() : base(""{1}"", {2}) 
        {{    
        }}{3}
    }}
}}
", className, lowerName, isVoid, attributesCode);

            GenerateClass(className, code);

            return propertyCode;
        }
    }
}
