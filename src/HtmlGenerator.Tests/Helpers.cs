using System;
using Xunit;

namespace HtmlGenerator.Tests
{
    public static class Helpers
    {
        public static void SerializeIgnoringFormatting(HtmlElement element, string expected)
        {
            expected = expected.Replace("\r\n", "\n").Replace("\n", Environment.NewLine);
            Assert.Equal(expected, element.ToString());
            Assert.Equal(expected, element.Serialize());
            Assert.Equal(expected.Replace(Environment.NewLine, ""), element.Serialize(HtmlSerializeOptions.NoFormatting));
        }
    }
}
