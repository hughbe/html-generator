using Xunit;

namespace HtmlGenerator.Tests
{
    public class HtmlElementSerializeTests
    {
        [Fact]
        public void VoidElement_OneVoidAttribute()
        {
            HtmlElement element = new HtmlElement("element", isVoid: true);
            element.Add(new HtmlAttribute("void"));
            Helpers.SerializeIgnoringFormatting(element, "<element void />");
        }

        [Fact]
        public void VoidElement_OneNonVoidAttribute()
        {
            HtmlElement element = new HtmlElement("element", isVoid: true);
            element.Add(new HtmlAttribute("name", "value"));
            Helpers.SerializeIgnoringFormatting(element, "<element name=\"value\" />");
        }

        [Fact]
        public void VoidElement_MultipleAttributes()
        {
            HtmlElement element = new HtmlElement("element", isVoid: true);
            element.Add(new HtmlAttribute("void"), new HtmlAttribute("name", "value"));
            Helpers.SerializeIgnoringFormatting(element, "<element void name=\"value\" />");
        }

        [Fact]
        public void VoidElement_NoAttributes()
        {
            HtmlElement voidElement = new HtmlElement("element", isVoid: true);
            Helpers.SerializeIgnoringFormatting(voidElement, "<element />");
        }

        [Fact]
        public void NonVoidElement_NoAttributes_NoInnerText_NoChildren()
        {
            HtmlElement element = new HtmlElement("element");
            Helpers.SerializeIgnoringFormatting(element, "<element></element>");
        }

        [Fact]
        public void NonVoidElement_OneVoidAttribute_NoInnerText_NoChildren()
        {
            HtmlElement element = new HtmlElement("element", new HtmlAttribute("void"));
            Helpers.SerializeIgnoringFormatting(element, "<element void></element>");
        }

        [Fact]
        public void NonVoidElement_OneNonVoidAttribute_NoInnerText_NoChildren()
        {
            HtmlElement element = new HtmlElement("element", new HtmlAttribute("name", "value"));
            Helpers.SerializeIgnoringFormatting(element, "<element name=\"value\"></element>");
        }

        [Fact]
        public void NonVoidElement_MultipleAttributes_NoInnerText_NoChildren()
        {
            HtmlElement element = new HtmlElement("element", new HtmlAttribute("void"), new HtmlAttribute("name", "value"));
            Helpers.SerializeIgnoringFormatting(element, "<element void name=\"value\"></element>");
        }

        [Fact]
        public void NonVoidElement_NoAttributes_InnerText_NoChildren()
        {
            HtmlElement element = new HtmlElement("element").WithInnerText("InnerText");
            Helpers.SerializeIgnoringFormatting(element, "<element>InnerText</element>");
        }

        [Fact]
        public void NonVoidElement_MultipleAttributes_InnerText_NoChildren()
        {
            HtmlElement element = new HtmlElement("element", new HtmlAttribute("void"), new HtmlAttribute("name", "value")).WithInnerText("InnerText");
            Helpers.SerializeIgnoringFormatting(element, "<element void name=\"value\">InnerText</element>");
        }

        [Fact]
        public void NonVoidElement_NoAttributes_NoInnerText_MultipleChildren()
        {
            HtmlElement element = new HtmlElement("parent", new HtmlElement[]
            {
                new HtmlElement("element1", isVoid: true),
                new HtmlElement("element2"),
                new HtmlElement("element3", new HtmlElement[]
                {
                    new HtmlElement("element").WithInnerText("InnerText"),
                    new HtmlElement("element4", new HtmlAttribute("name", "value")),
                })
            });
            Helpers.SerializeIgnoringFormatting(element, @"<parent>
<element1 />
<element2></element2>
<element3>
<element>InnerText</element>
<element4 name=""value""></element4>
</element3>
</parent>");
        }

        [Fact]
        public void NonVoidElement_Attributes_InnerText_MultipleChildren()
        {
            HtmlElement element = new HtmlElement("parent", new HtmlObject[]
            {
                new HtmlText("Inner"),
                new HtmlAttribute("void"),
                new HtmlAttribute("name", "value"),
                new HtmlElement("element1", isVoid: true),
                new HtmlElement("element2"),
                new HtmlElement("element3", new HtmlElement[]
                {
                    new HtmlElement("element").WithInnerText("InnerText"),
                    new HtmlElement("element4", new HtmlAttribute("name", "value")),
                })
            });
            Helpers.SerializeIgnoringFormatting(element, @"<parent void name=""value"">Inner
<element1 />
<element2></element2>
<element3>
<element>InnerText</element>
<element4 name=""value""></element4>
</element3>
</parent>");
        }
    }
}
