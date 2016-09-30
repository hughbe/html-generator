using Xunit;

namespace HtmlGenerator.Tests
{
    public class HtmlElementSerializeTests
    {
        [Fact]
        public void Serialize_NonVoidElement_Empty()
        {
            HtmlElement voidElement = new HtmlElement("p");
            Helpers.SerializeIgnoringFormatting(voidElement, "<p></p>");
        }

        [Fact]
        public void Serialize_VoidElement_VoidAttribute()
        {
            HtmlElement voidElement = new HtmlElement("br", isVoid: true);
            voidElement.Add(new HtmlAttribute("allowfullscreen"));
            Helpers.SerializeIgnoringFormatting(voidElement, "<br allowfullscreen />");
        }

        [Fact]
        public void Serialize_VoidElement_NonVoidAttribute()
        {
            HtmlElement voidElement = new HtmlElement("br", isVoid: true);
            voidElement.Add(new HtmlAttribute("class", "aClass"));
            Helpers.SerializeIgnoringFormatting(voidElement, "<br class=\"aClass\" />");
        }

        [Fact]
        public void Serialize_VoidElement_NoAttributes()
        {
            HtmlElement voidElement = new HtmlElement("br", isVoid: true);
            Helpers.SerializeIgnoringFormatting(voidElement, "<br />");
        }
    }
}
