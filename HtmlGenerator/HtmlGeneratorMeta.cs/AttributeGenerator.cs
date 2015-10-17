using HtmlGenerator.Meta;

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

                var className = "Html" + upperName + "Attribute";

                string basePropertyCode = string.Format("\t\tinternal static {0} {1} => new {0}();", className, upperName);
                string createPropertyCode;

                if (htmlObject.IsVoid)
                {
                    createPropertyCode = string.Format("\t\tpublic static {0} {1} => new {0}();", className, upperName);
                }
                else
                {
                    createPropertyCode = string.Format("\t\tpublic static {0} {1}(string value) => new {0}(value);", className, upperName);
                }

                if (!string.IsNullOrEmpty(PreviousName))
                {
                    basePropertyCode = "\n" + basePropertyCode;
                    createPropertyCode = "\n" + createPropertyCode;

                    var newLetter = upperName.Substring(0, 1);
                    var previousLetter = PreviousName.Substring(0, 1);
                    if (newLetter != previousLetter)
                    {
                        basePropertyCode = "\n" + basePropertyCode;
                        createPropertyCode = "\n" + createPropertyCode;
                    }
                }

                baseList += basePropertyCode;
                createList += createPropertyCode;

                var valueCreationCode = "";
                if (!htmlObject.IsVoid)
                {
                    valueCreationCode = string.Format(
"\n\n" + @"        internal {0}(string value) : base(""{1}"", ""{2}"", value, {3}) 
        {{
        }}", className, lowerName, upperName, isVoid);
                }

                var code = string.Format(@"namespace HtmlGenerator
{{
    public class {0} : HtmlAttribute 
    {{
        internal {0}() : base(""{1}"", ""{2}"", null, {3}) 
        {{
        }}{4}
    }}
}}
", className, lowerName, upperName, isVoid, valueCreationCode);

                GenerateClass(className, code);
                
                PreviousName = upperName;
            }

            GenerateList("BaseAttribute", "internal", baseList);
            GenerateList("Attribute", "public", createList);
        }
    }
}
