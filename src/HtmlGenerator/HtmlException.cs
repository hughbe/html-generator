using System;

namespace HtmlGenerator
{
    public class HtmlException : Exception
    {
        public HtmlException() { }

        public HtmlException(string message) : base(message) { }

        public HtmlException(string message, Exception innerException) : base(message, innerException) { }
    }
}
