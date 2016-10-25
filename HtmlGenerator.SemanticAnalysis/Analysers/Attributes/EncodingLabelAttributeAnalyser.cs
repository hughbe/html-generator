using System.Collections.Generic;
using System.Linq;
using HtmlGenerator.Extensions;

namespace HtmlGenerator.SemanticAnalysis.Analysers.Attributes
{
    public class EncodingLabelAttributeAnalyser : IAttributeAnalyser
    {
        private static List<string> s_validEncodings;
        private static IEnumerable<string> ValidEncodings
        {
            get
            {
                if (s_validEncodings == null)
                {
                    s_validEncodings = new List<string>();
                    InitializeEncodings();
                }
                return s_validEncodings;
            }
        }

        public bool IsValid(string name, string value)
        {
            // 5.2 Names and labels
            return ValidEncodings.Contains(value, StringExtensions.AsciiCaseInsensitiveComparer.Comparer);
        }

        private static void InitializeEncodings()
        {
            // UTF-8
            s_validEncodings.Add("unicode-1-1-utf-8");
            s_validEncodings.Add("utf-8");
            s_validEncodings.Add("utf8");

            // IBM866
            s_validEncodings.Add("866");
            s_validEncodings.Add("cp866");
            s_validEncodings.Add("csibm866");
            s_validEncodings.Add("ibm866");

            // ISO-8859-2
            s_validEncodings.Add("csisolatin2");
            s_validEncodings.Add("iso-8859-2");
            s_validEncodings.Add("iso-ir-101");
            s_validEncodings.Add("iso8859-2");
            s_validEncodings.Add("iso88592");
            s_validEncodings.Add("iso_8859-2");
            s_validEncodings.Add("iso_8859-2:1987");
            s_validEncodings.Add("l2");
            s_validEncodings.Add("latin2");

            // ISO-8859-3
            s_validEncodings.Add("csisolatin3");
            s_validEncodings.Add("iso-8859-3");
            s_validEncodings.Add("iso-ir-109");
            s_validEncodings.Add("iso8859-3");
            s_validEncodings.Add("iso88593");
            s_validEncodings.Add("iso_8859-3");
            s_validEncodings.Add("iso_8859-3:1988");
            s_validEncodings.Add("l3");
            s_validEncodings.Add("latin3");

            // ISO-8859-4
            s_validEncodings.Add("csisolatin4");
            s_validEncodings.Add("iso-8859-4");
            s_validEncodings.Add("iso-ir-110");
            s_validEncodings.Add("iso8859-4");
            s_validEncodings.Add("iso88594");
            s_validEncodings.Add("iso_8859-4");
            s_validEncodings.Add("iso_8859-4:1988");
            s_validEncodings.Add("l4");
            s_validEncodings.Add("latin4");

            // ISO-8859-5
            s_validEncodings.Add("csisolatincyrillic");
            s_validEncodings.Add("cyrillic");
            s_validEncodings.Add("iso-8859-5");
            s_validEncodings.Add("iso-ir-144");
            s_validEncodings.Add("iso8859-5");
            s_validEncodings.Add("iso88595");
            s_validEncodings.Add("iso_8859-5");
            s_validEncodings.Add("iso_8859-5:1988");

            // ISO-8859-6
            s_validEncodings.Add("arabic");
            s_validEncodings.Add("asmo-708");
            s_validEncodings.Add("csiso88596e");
            s_validEncodings.Add("csiso88596i");
            s_validEncodings.Add("csisolatinarabic");
            s_validEncodings.Add("ecma-114");
            s_validEncodings.Add("iso-8859-6");
            s_validEncodings.Add("iso-8859-6-e");
            s_validEncodings.Add("iso-8859-6-i");
            s_validEncodings.Add("iso-ir-127");
            s_validEncodings.Add("iso8859-6");
            s_validEncodings.Add("iso88596");
            s_validEncodings.Add("iso_8859-6");
            s_validEncodings.Add("iso_8859-6:1987");

            // ISO-8859-7
            s_validEncodings.Add("csisolatingreek");
            s_validEncodings.Add("ecma-118");
            s_validEncodings.Add("elot_928");
            s_validEncodings.Add("greek");
            s_validEncodings.Add("greek8");
            s_validEncodings.Add("iso-8859-7");
            s_validEncodings.Add("iso-ir-126");
            s_validEncodings.Add("iso8859-7");
            s_validEncodings.Add("iso88597");
            s_validEncodings.Add("iso_8859-7");
            s_validEncodings.Add("iso_8859-7:1987");
            s_validEncodings.Add("sun_eu_greek");

            // ISO-8859-8
            s_validEncodings.Add("csiso88598e");
            s_validEncodings.Add("csisolatinhebrew");
            s_validEncodings.Add("hebrew");
            s_validEncodings.Add("iso-8859-8");
            s_validEncodings.Add("iso-8859-8-e");
            s_validEncodings.Add("iso-ir-138");
            s_validEncodings.Add("iso8859-8");
            s_validEncodings.Add("iso88598");
            s_validEncodings.Add("iso_8859-8");
            s_validEncodings.Add("iso_8859-8:1988");
            s_validEncodings.Add("visual");

            // ISO-8859-8-I
            s_validEncodings.Add("csiso88598i");
            s_validEncodings.Add("iso-8859-8-i");
            s_validEncodings.Add("logical");

            // ISO-8859-10
            s_validEncodings.Add("csisolatin6");
            s_validEncodings.Add("iso-8859-10");
            s_validEncodings.Add("iso-ir-157");
            s_validEncodings.Add("iso8859-10");
            s_validEncodings.Add("iso885910");
            s_validEncodings.Add("l6");
            s_validEncodings.Add("latin6");

            // ISO-8859-13
            s_validEncodings.Add("iso-8859-13");
            s_validEncodings.Add("iso8859-13");
            s_validEncodings.Add("iso885913");

            // ISO-8859-14
            s_validEncodings.Add("iso-8859-14");
            s_validEncodings.Add("iso8859-14");
            s_validEncodings.Add("iso885914");

            // ISO-8859-15
            s_validEncodings.Add("csisolatin9");
            s_validEncodings.Add("iso-8859-15");
            s_validEncodings.Add("iso8859-15");
            s_validEncodings.Add("iso885915");
            s_validEncodings.Add("iso_8859-15");
            s_validEncodings.Add("l9");

            // ISO-8859-16
            s_validEncodings.Add("iso-8859-16");

            // KOI8-R
            s_validEncodings.Add("cskoi8r");
            s_validEncodings.Add("koi");
            s_validEncodings.Add("koi8");
            s_validEncodings.Add("koi8-r");
            s_validEncodings.Add("koi8_r");

            // KOI8-U
            s_validEncodings.Add("koi8-ru");
            s_validEncodings.Add("koi8-u");

            // macintosh
            s_validEncodings.Add("csmacintosh");
            s_validEncodings.Add("mac");
            s_validEncodings.Add("macintosh");
            s_validEncodings.Add("x-mac-roman");

            // windows-874
            s_validEncodings.Add("dos-874");
            s_validEncodings.Add("iso-8859-11");
            s_validEncodings.Add("iso8859-11");
            s_validEncodings.Add("iso885911");
            s_validEncodings.Add("tis-620");
            s_validEncodings.Add("windows-874");

            // windows-1250
            s_validEncodings.Add("cp1250");
            s_validEncodings.Add("windows-1250");
            s_validEncodings.Add("x-cp1250");

            // windows-1251
            s_validEncodings.Add("cp1251");
            s_validEncodings.Add("windows-1251");
            s_validEncodings.Add("x-cp1251");

            // windows-1252
            s_validEncodings.Add("ansi_x3.4-1968");
            s_validEncodings.Add("ascii");
            s_validEncodings.Add("cp1252");
            s_validEncodings.Add("cp819");
            s_validEncodings.Add("csisolatin1");
            s_validEncodings.Add("ibm819");
            s_validEncodings.Add("iso-8859-1");
            s_validEncodings.Add("iso-ir-100");
            s_validEncodings.Add("iso8859-1");
            s_validEncodings.Add("iso88591");
            s_validEncodings.Add("iso_8859-1");
            s_validEncodings.Add("iso_8859-1:1987");
            s_validEncodings.Add("l1");
            s_validEncodings.Add("latin1");
            s_validEncodings.Add("us-ascii");
            s_validEncodings.Add("windows-1252");
            s_validEncodings.Add("x-cp1252");

            // windows-1253
            s_validEncodings.Add("cp1253");
            s_validEncodings.Add("windows-1253");
            s_validEncodings.Add("x-cp1253");

            // windows-1254
            s_validEncodings.Add("cp1254");
            s_validEncodings.Add("csisolatin5");
            s_validEncodings.Add("iso-8859-9");
            s_validEncodings.Add("iso-ir-148");
            s_validEncodings.Add("iso8859-9");
            s_validEncodings.Add("iso88599");
            s_validEncodings.Add("iso_8859-9");
            s_validEncodings.Add("iso_8859-9:1989");
            s_validEncodings.Add("l5");
            s_validEncodings.Add("latin5");
            s_validEncodings.Add("windows-1254");
            s_validEncodings.Add("x-cp1254");

            // windows-1255
            s_validEncodings.Add("cp1255");
            s_validEncodings.Add("windows-1255");
            s_validEncodings.Add("x-cp1255");

            // windows-1256
            s_validEncodings.Add("cp1256");
            s_validEncodings.Add("windows-1256");
            s_validEncodings.Add("x-cp1256");

            // windows-1257
            s_validEncodings.Add("cp1257");
            s_validEncodings.Add("windows-1257");
            s_validEncodings.Add("x-cp1257");

            // windows-1258
            s_validEncodings.Add("cp1258");
            s_validEncodings.Add("windows-1258");
            s_validEncodings.Add("x-cp1258");

            // x-mac-cyrillic
            s_validEncodings.Add("x-mac-cyrillic");
            s_validEncodings.Add("x-mac-ukrainian");

            // GBK
            s_validEncodings.Add("chinese");
            s_validEncodings.Add("csgb2312");
            s_validEncodings.Add("csiso58gb231280");
            s_validEncodings.Add("gb2312");
            s_validEncodings.Add("gb_2312");
            s_validEncodings.Add("gb_2312-80");
            s_validEncodings.Add("gbk");
            s_validEncodings.Add("iso-ir-58");
            s_validEncodings.Add("x-gbk");

            // gb18030
            s_validEncodings.Add("gb18030");

            // Big5
            s_validEncodings.Add("big5");
            s_validEncodings.Add("big5-hkscs");
            s_validEncodings.Add("cn-big5");
            s_validEncodings.Add("csbig5");
            s_validEncodings.Add("x-x-big5");
            // EUC-JP
            s_validEncodings.Add("cseucpkdfmtjapanese");
            s_validEncodings.Add("euc-jp");
            s_validEncodings.Add("x-euc-jp");

            // ISO-2022-JP
            s_validEncodings.Add("csiso2022jp");
            s_validEncodings.Add("iso-2022-jp");

            // Shift_JIS
            s_validEncodings.Add("csshiftjis");
            s_validEncodings.Add("ms932");
            s_validEncodings.Add("ms_kanji");
            s_validEncodings.Add("shift-jis");
            s_validEncodings.Add("shift_jis");
            s_validEncodings.Add("sjis");
            s_validEncodings.Add("windows-31j");
            s_validEncodings.Add("x-sjis");

            // EUC-KR
            s_validEncodings.Add("cseuckr");
            s_validEncodings.Add("csksc56011987");
            s_validEncodings.Add("euc-kr");
            s_validEncodings.Add("iso-ir-149");
            s_validEncodings.Add("korean");
            s_validEncodings.Add("ks_c_5601-1987");
            s_validEncodings.Add("ks_c_5601-1989");
            s_validEncodings.Add("ksc5601");
            s_validEncodings.Add("ksc_5601");
            s_validEncodings.Add("windows-949");

            // replacement
            s_validEncodings.Add("csiso2022kr");
            s_validEncodings.Add("hz-gb-2312");
            s_validEncodings.Add("iso-2022-cn");
            s_validEncodings.Add("iso-2022-cn-ext");
            s_validEncodings.Add("iso-2022-kr");

            // UTF-16BE
            s_validEncodings.Add("utf-16be");

            // UTF-16LE
            s_validEncodings.Add("utf-16");
            s_validEncodings.Add("utf-16le");

            // x-user-defined
            s_validEncodings.Add("x-user-defined");
        }
    }
}
