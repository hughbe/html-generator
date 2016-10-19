using System;
using Xunit;

namespace HtmlGenerator.Tests
{
    public class Program
    {
        public static void Main(string[] args)
        {
            HtmlElement parent = new HtmlElement("parent");
            HtmlElement child1 = new HtmlElement("child1");
            parent.Add(child1);

            // Element
            HtmlElement child2 = new HtmlElement("child2");
            child1.AddAfterSelf(child2);
            Assert.Equal(parent, child2.Parent);
            Assert.Equal(new HtmlElement[] { child1, child2 }, parent.Elements());

            // Comment
            HtmlComment comment = new HtmlComment("comment");
            child1.AddAfterSelf(comment);
            Assert.Equal(parent, comment.Parent);
            Assert.Equal(new HtmlObject[] { child1, comment, child2 }, parent.Nodes());


            Console.WriteLine(HtmlElement.Parse(@"<p>Inner text<a href=""abc"">url</a> more</p>"));

            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}
