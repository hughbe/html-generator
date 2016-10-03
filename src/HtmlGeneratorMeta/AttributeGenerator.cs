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

                string createPropertyCode;
                if (htmlObject.IsVoid)
                {
                    createPropertyCode = string.Format($"\t\tpublic static HtmlAttribute {upperName} => new HtmlAttribute(\"{lowerName}\");");
                }
                else
                {
                    createPropertyCode = string.Format($"\t\tpublic static HtmlAttribute {upperName}(string value) => new HtmlAttribute(\"{lowerName}\", value);");
                }

                if (!string.IsNullOrEmpty(PreviousName))
                {
                    createPropertyCode = "\n" + createPropertyCode;

                    if (upperName[0] != PreviousName[0])
                    {
                        createPropertyCode = "\n" + createPropertyCode;
                    }
                }
                createList += createPropertyCode;
                PreviousName = upperName;
            }

            createList += Environment.NewLine;
            GenerateList("Attribute", "public", "", createList);
        }
    }
}
