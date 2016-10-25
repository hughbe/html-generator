using System.Collections.Generic;
using System.Linq;
using HtmlGenerator.Extensions;

namespace HtmlGenerator.SemanticAnalysis.Analysers.Attributes
{
    public class ColorAttributeAnalyser : IAttributeAnalyser
    {
        public bool IsValid(string name, string value)
        {
            // 2.4.6. Colors
            value = value.Trim();
            if (value.Length == 0)
            {
                return false;
            }
            if (StringExtensions.EqualsAsciiOrdinalIgnoreCase(value, "transparent"))
            {
                return false;
            }
            if (KnownColors.Contains(value, StringExtensions.AsciiCaseInsensitiveComparer.Comparer))
            {
                return true;
            }

            if (value[0] == '#')
            {
                if (value.Length != 7)
                {
                    return false;
                }

                for (int i = 1; i < value.Length; i++)
                {
                    if (!IsAsciiDigit(value[i]))
                    {
                        return false;
                    }
                }

                return true;
            }

            return false;
        }

        private static bool IsAsciiDigit(char c)
        {
            return
                ((c >= '1') && (c <= '9')) ||
                ((c >= 'A') && (c <= 'Z')) ||
                ((c >= 'a') && (c <= 'z'));
        }

        private static List<string> s_knownColors;

        private static IEnumerable<string> KnownColors
        {
            get
            {
                if (s_knownColors == null)
                {
                    s_knownColors = new List<string>();
                    InitializeKnownColors();
                }
                return s_knownColors;
            }
        }

        private static void InitializeKnownColors()
        {
            // CSS 3
            // 4.3. Extended color keywords
            s_knownColors.Add("aliceblue");
            s_knownColors.Add("antiquewhite");
            s_knownColors.Add("aqua");
            s_knownColors.Add("aquamarine");
            s_knownColors.Add("azure");
            s_knownColors.Add("beige");
            s_knownColors.Add("bisque");
            s_knownColors.Add("black");
            s_knownColors.Add("blanchedalmond");
            s_knownColors.Add("blue");
            s_knownColors.Add("blueviolet");
            s_knownColors.Add("brown");
            s_knownColors.Add("burlywood");
            s_knownColors.Add("cadetblue");
            s_knownColors.Add("chartreuse");
            s_knownColors.Add("chocolate");
            s_knownColors.Add("coral");
            s_knownColors.Add("cornflowerblue");
            s_knownColors.Add("cornsilk");
            s_knownColors.Add("crimson");
            s_knownColors.Add("cyan");
            s_knownColors.Add("darkblue");
            s_knownColors.Add("darkcyan");
            s_knownColors.Add("darkgoldenrod");
            s_knownColors.Add("darkgray");
            s_knownColors.Add("darkgreen");
            s_knownColors.Add("darkgrey");
            s_knownColors.Add("darkkhaki");
            s_knownColors.Add("darkmagenta");
            s_knownColors.Add("darkolivegreen");
            s_knownColors.Add("darkorange");
            s_knownColors.Add("darkorchid");
            s_knownColors.Add("darkred");
            s_knownColors.Add("darksalmon");
            s_knownColors.Add("darkseagreen");
            s_knownColors.Add("darkslateblue");
            s_knownColors.Add("darkslategray");
            s_knownColors.Add("darkslategrey");
            s_knownColors.Add("darkturquoise");
            s_knownColors.Add("darkviolet");
            s_knownColors.Add("deeppink");
            s_knownColors.Add("deepskyblue");
            s_knownColors.Add("dimgray");
            s_knownColors.Add("dimgrey");
            s_knownColors.Add("dodgerblue");
            s_knownColors.Add("firebrick");
            s_knownColors.Add("floralwhite");
            s_knownColors.Add("forestgreen");
            s_knownColors.Add("fuchsia");
            s_knownColors.Add("gainsboro");
            s_knownColors.Add("ghostwhite");
            s_knownColors.Add("gold");
            s_knownColors.Add("goldenrod");
            s_knownColors.Add("gray");
            s_knownColors.Add("green");
            s_knownColors.Add("greenyellow");
            s_knownColors.Add("grey");
            s_knownColors.Add("honeydew");
            s_knownColors.Add("hotpink");
            s_knownColors.Add("indianred");
            s_knownColors.Add("indigo");
            s_knownColors.Add("ivory");
            s_knownColors.Add("khaki");
            s_knownColors.Add("lavender");
            s_knownColors.Add("lavenderblush");
            s_knownColors.Add("lawngreen");
            s_knownColors.Add("lemonchiffon");
            s_knownColors.Add("lightblue");
            s_knownColors.Add("lightcoral");
            s_knownColors.Add("lightcyan");
            s_knownColors.Add("lightgoldenrodyellow");
            s_knownColors.Add("lightgray");
            s_knownColors.Add("lightgreen");
            s_knownColors.Add("lightgrey");
            s_knownColors.Add("lightpink");
            s_knownColors.Add("lightsalmon");
            s_knownColors.Add("lightseagreen");
            s_knownColors.Add("lightskyblue");
            s_knownColors.Add("lightslategray");
            s_knownColors.Add("lightslategrey");
            s_knownColors.Add("lightsteelblue");
            s_knownColors.Add("lightyellow");
            s_knownColors.Add("lime");
            s_knownColors.Add("limegreen");
            s_knownColors.Add("linen");
            s_knownColors.Add("magenta");
            s_knownColors.Add("maroon");
            s_knownColors.Add("mediumaquamarine");
            s_knownColors.Add("mediumblue");
            s_knownColors.Add("mediumorchid");
            s_knownColors.Add("mediumpurple");
            s_knownColors.Add("mediumseagreen");
            s_knownColors.Add("mediumslateblue");
            s_knownColors.Add("mediumspringgreen");
            s_knownColors.Add("mediumturquoise");
            s_knownColors.Add("mediumvioletred");
            s_knownColors.Add("midnightblue");
            s_knownColors.Add("mintcream");
            s_knownColors.Add("mistyrose");
            s_knownColors.Add("moccasin");
            s_knownColors.Add("navajowhite");
            s_knownColors.Add("navy");
            s_knownColors.Add("oldlace");
            s_knownColors.Add("olive");
            s_knownColors.Add("olivedrab");
            s_knownColors.Add("orange");
            s_knownColors.Add("orangered");
            s_knownColors.Add("orchid");
            s_knownColors.Add("palegoldenrod");
            s_knownColors.Add("palegreen");
            s_knownColors.Add("paleturquoise");
            s_knownColors.Add("palevioletred");
            s_knownColors.Add("papayawhip");
            s_knownColors.Add("peachpuff");
            s_knownColors.Add("peru");
            s_knownColors.Add("pink");
            s_knownColors.Add("plum");
            s_knownColors.Add("powderblue");
            s_knownColors.Add("purple");
            s_knownColors.Add("red");
            s_knownColors.Add("rosybrown");
            s_knownColors.Add("royalblue");
            s_knownColors.Add("saddlebrown");
            s_knownColors.Add("salmon");
            s_knownColors.Add("sandybrown");
            s_knownColors.Add("seagreen");
            s_knownColors.Add("seashell");
            s_knownColors.Add("sienna");
            s_knownColors.Add("silver");
            s_knownColors.Add("skyblue");
            s_knownColors.Add("slateblue");
            s_knownColors.Add("slategray");
            s_knownColors.Add("slategrey");
            s_knownColors.Add("snow");
            s_knownColors.Add("springgreen");
            s_knownColors.Add("steelblue");
            s_knownColors.Add("tan");
            s_knownColors.Add("teal");
            s_knownColors.Add("thistle");
            s_knownColors.Add("tomato");
            s_knownColors.Add("turquoise");
            s_knownColors.Add("violet");
            s_knownColors.Add("wheat");
            s_knownColors.Add("white");
            s_knownColors.Add("whitesmoke");
            s_knownColors.Add("yellow");
            s_knownColors.Add("yellowgreen");

            // 4.4. ‘currentColor’ color keyword
            s_knownColors.Add("currentcolor");

            // CSS2 (deprecated)
            // 4.5.1. CSS2 system colors
            s_knownColors.Add("activeborder");
            s_knownColors.Add("activecaption");
            s_knownColors.Add("appworkspace");
            s_knownColors.Add("background");
            s_knownColors.Add("buttonface");
            s_knownColors.Add("buttonhighlight");
            s_knownColors.Add("buttonshadow");
            s_knownColors.Add("buttontext");
            s_knownColors.Add("captiontext");
            s_knownColors.Add("graytext");
            s_knownColors.Add("highlight");
            s_knownColors.Add("highlighttext");
            s_knownColors.Add("inactiveborder");
            s_knownColors.Add("inactivecaption");
            s_knownColors.Add("inactivecaptiontext");
            s_knownColors.Add("infobackground");
            s_knownColors.Add("infotext");
            s_knownColors.Add("menu");
            s_knownColors.Add("menutext");
            s_knownColors.Add("scrollbar");
            s_knownColors.Add("threeddarkshadow");
            s_knownColors.Add("threedface");
            s_knownColors.Add("threedhighlight");
            s_knownColors.Add("threedlightshadow");
            s_knownColors.Add("threedshadow");
            s_knownColors.Add("window");
            s_knownColors.Add("windowframe");
            s_knownColors.Add("windowtext");
        }
    }
}
