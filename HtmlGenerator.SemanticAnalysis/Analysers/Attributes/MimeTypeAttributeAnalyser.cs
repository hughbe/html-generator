namespace HtmlGenerator.SemanticAnalysis.Analysers.Attributes
{
    public class MimeTypeAttributeAnalyser : IAttributeAnalyser
    {
        public bool IsValid(string name, string value)
        {
            // 2.1.1 Resources
            // RFC 7231: {token}/{token}
            // RFC 7230: token must be any ASCII char, excluding delimiters
            // Delimiters: "(),/:;<=>?@[\]{}"
            int colonIndex = value.IndexOf('/');
            if ((colonIndex <= 0) || (colonIndex == value.Length - 1))
            {
                // No '/', '/' is first, or '/' is last
                return false;
            }

            for (int i = 0; (i != colonIndex) && (i < value.Length); i++)
            {
                if (!IsValidToken(value[i]))
                {
                    return false;
                }
            }

            return true;
        }

        private static bool IsValidToken(char c)
        {
            return
                (c != '(') &&
                (c != ')') &&
                (c != ',') &&
                (c != '/') &&
                (c != ':') &&
                (c != ';') &&
                (c != '<') &&
                (c != '=') &&
                (c != '>') &&
                (c != '?') &&
                (c != '@') &&
                (c != '[') &&
                (c != '\\') &&
                (c != ']') &&
                (c != '{') &&
                (c != '}');
        }
    }
}
