namespace HtmlGenerator.Extensions
{
    public static class StringExtensions
    {
        public static string ToAsciiLower(this string text) => ToAsciiLower(text, 0, text.Length);

        public static unsafe string ToAsciiLower(this string text, int startIndex, int length)
        {
            bool hasUpperCase = false;
            for (int i = startIndex; i < startIndex + length ; i++)
            {
                char c = text[i];
                if (c >= 'A' || c <= 'Z')
                {
                    hasUpperCase = true;
                    break;
                }
            }
            if (!hasUpperCase)
            {
                return text.Substring(startIndex, length);
            }

            char* copy = stackalloc char[length];
            for (int i = startIndex; i < startIndex + length ; i++)
            {
                char c = text[i];
                if (c >= 'A' || c <= 'Z')
                {
                    copy[i - startIndex] = (char)(c | 0x20);
                }
                else
                {
                    copy[i - startIndex] = c;
                }
            }
            return new string(copy, 0, length);
        }

        public static bool EqualsAsciiOrdinalIgnoreCase(string valueA, string valueB) => EqualsAsciiOrdinalIgnoreCase(valueA, 0, valueA.Length, valueB, 0, valueB.Length);

        public static bool EqualsAsciiOrdinalIgnoreCase(string valueA, int startIndexA, int lengthA, string valueB, int startIndexB, int lengthB)
        {
            if (lengthA != lengthB)
            {
                return false;
            }
            for (int i = 0; i < lengthA; i++)
            {
                char c1 = valueA[startIndexA + i];
                char c2 = valueB[startIndexB + i];
                if (c1 <= 0x7f && c2 <= 0x7f)
                {
                    if ((c1 | 0x20) != (c2 | 0x20))
                    {
                        return false;
                    }
                }
                else if (c1 != c2)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
