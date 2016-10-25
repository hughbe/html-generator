using System;
using System.Diagnostics;
using HtmlGenerator.SemanticAnalysis;

namespace HtmlGenerator.Tests
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Stopwatch s = new Stopwatch();
            s.Start();
            Sema.GetElementInformation("a");
            s.Stop();

            Console.WriteLine(s.ElapsedMilliseconds);

            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}
