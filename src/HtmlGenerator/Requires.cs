using System;

namespace HtmlGenerator
{
    public static class Requires
    {
        public static void NotNull(object value, string paramName)
        {
            if (value == null)
            {
                throw new ArgumentNullException(paramName);
            }
        }

        public static void NotNullOrWhitespace(string value, string paramName)
        {
            NotNull(value, paramName);
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Argument cannot be empty or whitespace.", paramName);
            }
        }
    }
}
