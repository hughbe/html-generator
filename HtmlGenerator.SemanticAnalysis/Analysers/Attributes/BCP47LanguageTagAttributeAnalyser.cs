using System.Collections.Generic;
using System.Linq;
using HtmlGenerator.Extensions;

namespace HtmlGenerator.SemanticAnalysis.Analysers.Attributes
{
    public class Bcp47LanguageTagAnalyser : IAttributeAnalyser
    {
        private bool AllowEmpty { get; }

        public Bcp47LanguageTagAnalyser(bool allowEmpty)
        {
            AllowEmpty = allowEmpty;
        }

        public bool IsValid(string name, string value)
        {
            // Normative References [BCP47]
            if (value.Length == 0)
            {
                return AllowEmpty;
            }
            if (!VerifyNextSegment(value, startIndex: 0, minLength: 2))
            {
                return IrregularTags.Contains(value, StringExtensions.AsciiCaseInsensitiveComparer.Comparer);
            }

            return true;
        }

        private static bool VerifyNextSegment(string value, int startIndex, int minLength)
        {
            while (true)
            {
                int nextDashIndex = value.IndexOf('-', startIndex);
                if ((nextDashIndex >= startIndex) && (nextDashIndex <= startIndex + minLength))
                {
                    // Tag must be at least min length
                    return false;
                }

                if (nextDashIndex == -1)
                {
                    nextDashIndex = value.Length;
                }
                if (nextDashIndex > 8)
                {
                    // Tag must be max length 8
                    return false;
                }

                for (int i = startIndex; i < nextDashIndex; i++)
                {
                    // Tag must be all ASCII letters
                    if (!IsAsciiChar(value[i]))
                    {
                        return false;
                    }
                }

                if (nextDashIndex != value.Length)
                {
                    startIndex = nextDashIndex + 1;
                    minLength = 2;
                    continue;
                }
                // Done parsing
                return true;
            }
        }

        private static bool IsAsciiChar(char c)
        {
            return
                ((c >= 'A') && (c <= 'Z')) ||
                ((c >= 'a') && (c <= 'z'));
        }

        private static List<string> s_irregularTags;

        private static IEnumerable<string> IrregularTags
        {
            get
            {
                if (s_irregularTags == null)
                {
                    s_irregularTags = new List<string>();
                    InitializeIrregularTags();
                }
                return s_irregularTags;
            }
        }

        private static void InitializeIrregularTags()
        {
            s_irregularTags.Add("en-GB-oed");
            s_irregularTags.Add("i-ami");
            s_irregularTags.Add("i-bnn");
            s_irregularTags.Add("i-default");
            s_irregularTags.Add("i-enochian");
            s_irregularTags.Add("i-hak");
            s_irregularTags.Add("i-klingon");
            s_irregularTags.Add("i-lux");
            s_irregularTags.Add("i-mingo");
            s_irregularTags.Add("i-navajo");
            s_irregularTags.Add("i-pwn");
            s_irregularTags.Add("i-tao");
            s_irregularTags.Add("i-tay");
            s_irregularTags.Add("i-tsu");
            s_irregularTags.Add("sgn-BE-FR");
            s_irregularTags.Add("sgn-BE-NL");
            s_irregularTags.Add("sgn-CH-DE");
        }
    }
}
