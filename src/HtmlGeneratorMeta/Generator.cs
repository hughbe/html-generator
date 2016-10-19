using System.IO;

namespace HtmlGeneratorMeta
{
    public abstract class Generator
    {
        public string FolderPath { get; }

        protected string PreviousName { get; set; } = "";

        public Generator(string folderPath)
        {
            FolderPath = folderPath;
        }

        public abstract void Generate();

        public void GenerateClass(string className, string code)
        {
            if (!Directory.Exists(FolderPath))
            {
                Directory.CreateDirectory(FolderPath);
            }

            string filePath = Path.Combine(FolderPath, className + ".cs");
            File.WriteAllText(filePath, code);
        }

        public void GenerateList(string fileName, string accessModifier, string partialModifier, string list)
        {
            var code = string.Format(@"namespace HtmlGenerator 
{{
    {0} static {1}class {2} 
    {{
{3}
    }}
}}", accessModifier, partialModifier, fileName, list);
            string filePath = Path.Combine(FolderPath, "../") + fileName + ".cs";
            File.WriteAllText(filePath, code);
        }
    }
}
