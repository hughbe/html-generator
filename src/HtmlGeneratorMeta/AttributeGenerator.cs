using HtmlGenerator.Meta;
using System.Reflection;
using System;

namespace HtmlGeneratorMeta
{
    public class AttributeGenerator : Generator
    {
        public AttributeGenerator(string folderPath) : base(folderPath)
        {
        }

        public override void Generate()
        {
            PreviousName = "";

            var type = typeof(MetaAttributes);
            var properties = type.GetProperties();

            var baseList = "";
            var createList = "";
            
            foreach (var property in properties)
            {
                var htmlObject = property.GetValue(null) as AttributeInfo;
                if (htmlObject == null)
                {
                    continue;
                }

                var lowerName = htmlObject.Name;
                var upperName = property.Name;

                var isVoid = htmlObject.IsVoid ? "true" : "false";
                var isGlobal = htmlObject.IsGlobal ? "true" : "false";

                var className = "Html" + upperName + "Attribute";

                string basePropertyCode = string.Format("\t\tpublic static {0} {1} => new {0}();", className, upperName);
                string createPropertyCode = basePropertyCode;

                if (!htmlObject.IsVoid)
                { 
                    createPropertyCode = string.Format("\t\tpublic static {0} {1}(string value) => new {0}(value);", className, upperName);
                }

                if (!string.IsNullOrEmpty(PreviousName))
                {
                    basePropertyCode = "\n" + basePropertyCode;
                    createPropertyCode = "\n" + createPropertyCode;

                    if (upperName[0] != PreviousName[0])
                    {
                        basePropertyCode = "\n" + basePropertyCode;
                        createPropertyCode = "\n" + createPropertyCode;
                    }
                }

                baseList += basePropertyCode;
                createList += createPropertyCode;

                var ctorCode = "";
                if (htmlObject.IsVoid)
                {
                    ctorCode = $"public {className}() : base(\"{lowerName}\") {{}}";
                }
                else
                {
                    ctorCode = $"public {className}(string value) : base(\"{lowerName}\", value) {{}}";
                }

                var code = string.Format(@"namespace HtmlGenerator
{{
    public class {0} : HtmlAttribute
    {{
        {1}
    }}
}}
", className, ctorCode);

                GenerateClass(className, code);
                
                PreviousName = upperName;
            }

            GenerateList("BaseAttribute", "public", "", baseList);

            createList += Environment.NewLine;
            GenerateList("Attribute", "public", "", createList);
        }
    }
}
