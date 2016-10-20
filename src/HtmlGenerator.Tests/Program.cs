using System;

namespace HtmlGenerator.Tests
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(HtmlElement.Parse(@"<div>inner</div>"));

            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}
