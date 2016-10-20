using System;

namespace HtmlGenerator.Tests
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("***Serialize***");
            Console.WriteLine(new HtmlElement("div"));

            Console.WriteLine();
            Console.WriteLine("***Parse***");
            Console.WriteLine(HtmlElement.Parse(@"<div></div>"));

            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}
