namespace HtmlGeneratorMeta
{
    class Program
    {
        static void Main(string[] args)
        {
            var folderPath = @"c:\temp\";

            new ElementGenerator(folderPath + @"elements\").Generate();
            new AttributeGenerator(folderPath + @"attributes\").Generate();
        }
    }
}
