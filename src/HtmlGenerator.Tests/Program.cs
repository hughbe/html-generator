using System;

namespace HtmlGenerator.Tests
{
    public class Program
    {
        public static void Main(string[] args)
        {
            HtmlElement element = new HtmlElement("br");
            Console.WriteLine(element.Serialize());

            Console.ReadLine();
        }
    }
}
