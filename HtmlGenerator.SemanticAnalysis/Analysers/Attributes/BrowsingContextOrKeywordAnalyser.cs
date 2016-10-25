using System.Collections.Generic;

namespace HtmlGenerator.SemanticAnalysis.Analysers.Attributes
{
    public class BrowsingContextOrKeywordAnalyser : IAttributeAnalyser
    {
        public bool IsValid(string name, string value)
        {
            // 6.1.5. Browsing context names
            if (value.Length == 0)
            {
                return false;
            }
            if (Keywords.Contains(value))
            {
                return true;
            }

            return value[0] != '_';
        }

        private static List<string> s_keywords;

        private static List<string> Keywords
        {
            get
            {
                if (s_keywords == null)
                {
                    s_keywords = new List<string>();
                    InitializeKeywords();
                }
                return s_keywords;
            }
        }

        private static void InitializeKeywords()
        {
            s_keywords.Add("_blank");
            s_keywords.Add("_self");
            s_keywords.Add("_parent");
            s_keywords.Add("_top");
        }
    }
}
