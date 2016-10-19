using HtmlGenerator.Meta;
using System.Reflection;
using System;

namespace HtmlGeneratorMeta
{
    public class AttributeGenerator : Generator
    {
        public AttributeGenerator(string folderPath) : base(folderPath) { }

        public override void Generate()
        {
            PreviousName = "";

            PropertyInfo[] properties = typeof(MetaAttributes).GetProperties();
            string createList = "";
            foreach (var property in properties)
            {
                AttributeInfo htmlObject = property.GetValue(null) as AttributeInfo;
                if (htmlObject == null)
                {
                    continue;
                }

                string lowerName = htmlObject.Name;
                string upperName = property.Name;

                string isVoid = htmlObject.IsVoid ? "true" : "false";
                string isGlobal = htmlObject.IsGlobal ? "true" : "false";

                string createPropertyCode;
                if (htmlObject.IsVoid)
                {
                    createPropertyCode = string.Format($"        public static HtmlAttribute {upperName} => new HtmlAttribute(\"{lowerName}\");");
                }
                else
                {
                    createPropertyCode = string.Format($"        public static HtmlAttribute {upperName}(string value) => new HtmlAttribute(\"{lowerName}\", value);");
                }

                if (!string.IsNullOrEmpty(PreviousName))
                {
                    createPropertyCode = Environment.NewLine + createPropertyCode;

                    if (upperName[0] != PreviousName[0])
                    {
                        // Group alphabetically by starting letter
                        createPropertyCode = Environment.NewLine + createPropertyCode;
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
