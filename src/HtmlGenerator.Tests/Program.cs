using System;

namespace HtmlGenerator.Tests
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(HtmlElement.Parse(@"<p>Inner text<a href=""abc"">url</a> more</p>"));

            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}
