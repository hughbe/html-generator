using System;
using System.IO;

namespace HtmlGeneratorMeta
{
    class Program
    {
        static void Main(string[] args)
        {
            string folderPath = args.Length > 0 ? args[0] : null;
            
            if(string.IsNullOrEmpty(folderPath))
            {
                Console.WriteLine(@"Base directory was not provided!");
                return;
            }

            Console.WriteLine("Generating elements ..");
            new ElementGenerator(Path.Combine(folderPath, "Elements/")).Generate();
            Console.WriteLine("Elements successfully generated!\n");
            
            Console.WriteLine("Generating attributes ..");
            new AttributeGenerator(Path.Combine(folderPath, "Attributes/")).Generate();
            Console.WriteLine("Attributes successfully generated!\n");
        }
    }
}
