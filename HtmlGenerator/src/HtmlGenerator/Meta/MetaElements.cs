namespace HtmlGenerator.Meta
{
    using static BaseAttribute;

    public static class MetaElements
    {
        public static ElementInfo A => Custom("a", Download, Href, HrefLang, Media, Ping, Rel, Target, Type);
        public static ElementInfo Abbr => Custom("abbr");
        public static ElementInfo Address => Custom("address");
        public static ElementInfo Area => Custom("area", true, Alt, Coords, Download, Href, HrefLang, Media, Rel, Shape, Target, Type);
        public static ElementInfo Article => Custom("article");
        public static ElementInfo Audio => Custom("audio", AutoPlay, Controls, Loop, Muted, Preload, Src, Volume);

        public static ElementInfo B => Custom("b");
        public static ElementInfo Base => Custom("base", true, Href, Target);
        public static ElementInfo Bdi => Custom("bdi");
        public static ElementInfo Body => Custom("body");
        public static ElementInfo Br => Custom("br", true);
        public static ElementInfo Button => Custom("button", AutoFocus, Disabled, BaseAttribute.Form, FormAction, FormEncType, FormMethod, FormNoValidate, FormTarget, Name, Type, Value);

        public static ElementInfo Canvas => Custom("canvas", Height, Width);
        public static ElementInfo Caption => Custom("caption");
        public static ElementInfo Cite => Custom("cite");
        public static ElementInfo Code => Custom("code");
        public static ElementInfo Col => Custom("col", true, BaseAttribute.Span);
        public static ElementInfo Colgroup => Custom("colgroup", BaseAttribute.Span);

        public static ElementInfo Data => Custom("data", Value);
        public static ElementInfo Datalist => Custom("datalist");
        public static ElementInfo Dd => Custom("dd", NoWrap);
        public static ElementInfo Del => Custom("del", BaseAttribute.Cite, DateTime);
        public static ElementInfo Details => Custom("details", Open);
        public static ElementInfo Dfn => Custom("dfn");
        public static ElementInfo Dialog => Custom("dialog", Open);
        public static ElementInfo Div => Custom("div");
        public static ElementInfo Dl => Custom("dl", Compact);
        public static ElementInfo Dt => Custom("dt");

        public static ElementInfo Em => Custom("em");
        public static ElementInfo Embed => Custom("embed", true, Height, Src, Type, Width);

        public static ElementInfo Fieldset => Custom("fieldset");
        public static ElementInfo FigCaption => Custom("figcaption");
        public static ElementInfo Figure => Custom("figure");
        public static ElementInfo Footer => Custom("footer");
        public static ElementInfo Form => Custom("form", AcceptCharset, Action, AutoComplete, EncType, Method, Name, NoValidate, Target);

        public static ElementInfo H1 => Custom("h1");
        public static ElementInfo H2 => Custom("h2");
        public static ElementInfo H3 => Custom("h3");
        public static ElementInfo H4 => Custom("h4");
        public static ElementInfo H5 => Custom("h5");
        public static ElementInfo H6 => Custom("h6");
        public static ElementInfo Head => Custom("head");
        public static ElementInfo Header => Custom("header");
        public static ElementInfo Hr => Custom("hr", true, Color);
        public static ElementInfo Html => Custom("html", Xmls);

        public static ElementInfo I => Custom("i");
        public static ElementInfo Iframe => Custom("iframe", AllowFullScreen, Height, Name, Sandbox, Seamless, Src, SrcDoc, Width);
        public static ElementInfo Img => Custom("img", true, Alt, CrossOrigin, Height, IsMap, LongDesc, Sizes, Src, SrcSet, Width, UseMap);
        public static ElementInfo Input => Custom("input", true, Accept, AutoComplete, AutoFocus, AutoSave, Checked, Disabled, BaseAttribute.Form, FormAction, FormEncType, FormMethod, FormNoValidate, FormTarget, Height, InputMode, List, Max, MaxLength, Min, MinLength, Multiple, Name, Pattern, Placeholder, Readonly, Required, SelectionDirection, Size, Src, Step, Type, Value, Width);
        public static ElementInfo Ins => Custom("ins", BaseAttribute.Cite, DateTime);

        public static ElementInfo Kbd => Custom("kbd");

        public static ElementInfo Label => Custom("label", For, BaseAttribute.Form);
        public static ElementInfo Legend => Custom("legend");
        public static ElementInfo Li => Custom("li", Value);
        public static ElementInfo Link => Custom("link", true, CrossOrigin, Href, HrefLang, Integrity, Media, Rel, Sizes, Type);

        public static ElementInfo Main => Custom("main");
        public static ElementInfo Map => Custom("map", Name);
        public static ElementInfo Mark => Custom("mark");
        public static ElementInfo Menu => Custom("menu", BaseAttribute.Label, Type);
        public static ElementInfo MenuItem => Custom("menutiem", true, Checked, Command, Default, Disabled, Icon, BaseAttribute.Label, RadioGroup, Type);
        public static ElementInfo Meta => Custom("meta", true, Charset, Content, HttpEquiv, DefaultStyle, Refresh, Name);
        public static ElementInfo Meter => Custom("meter", BaseAttribute.Form, Low, High, Min, Max, Optimum, Value);
        public static ElementInfo Nav => Custom("nav");

        public static ElementInfo Noscript => Custom("noscript");

        public static ElementInfo Object => Custom("object", BaseAttribute.Data, BaseAttribute.Form, Height, Name, Type, TypeMustMatch, UseMap, Width);
        public static ElementInfo Ol => Custom("ol", Reversed, Start, Type);
        public static ElementInfo Optgroup => Custom("optgroup", Disabled, BaseAttribute.Label);
        public static ElementInfo Option => Custom("option", Disabled, BaseAttribute.Label, Selected, Value);
        public static ElementInfo Output => Custom("output", For, BaseAttribute.Form, Name);

        public static ElementInfo P => Custom("p");
        public static ElementInfo Param => Custom("param", true, Name, Value);
        public static ElementInfo Pre => Custom("pre");
        public static ElementInfo Progress => Custom("progress", Max, Value);

        public static ElementInfo Q => Custom("q", BaseAttribute.Cite);

        public static ElementInfo Rp => Custom("rp");
        public static ElementInfo Rt => Custom("rt");
        public static ElementInfo Rtc => Custom("rtc");
        public static ElementInfo Ruby => Custom("ruby");

        public static ElementInfo Samp => Custom("samp");
        public static ElementInfo Script => Custom("script", Async, CrossOrigin, Defer, Integrity, Src, Text, Type);
        public static ElementInfo Section => Custom("section");
        public static ElementInfo Select => Custom("select", AutoFocus, Disabled, BaseAttribute.Form, Multiple, Name, Required, Size);
        public static ElementInfo Small => Custom("small");
        public static ElementInfo Source => Custom("source", true, Src, Type);
        public static ElementInfo Span => Custom("span");
        public static ElementInfo Strong => Custom("strong");
        public static ElementInfo Style => Custom("style", Disabled, Type, Media, Scoped);
        public static ElementInfo Sub => Custom("sub");
        public static ElementInfo Summary => Custom("summary");
        public static ElementInfo Sup => Custom("sup");

        public static ElementInfo Table => Custom("table");
        public static ElementInfo Tbody => Custom("tbody");
        public static ElementInfo Template => Custom("template");
        public static ElementInfo TextArea => Custom("textarea", AutoComplete, AutoFocus, Cols, Disabled, BaseAttribute.Form, MaxLength, MinLength, Name, Placeholder, Readonly, Required, Rows, SelectionDirection, Wrap);
        public static ElementInfo Tfoot => Custom("tfoot");
        public static ElementInfo Th => Custom("th", ColSpan, Headers, RowSpan, Scope);
        public static ElementInfo Thead => Custom("thead");
        public static ElementInfo Time => Custom("time", DateTime);
        public static ElementInfo Title => Custom("title");
        public static ElementInfo Tr => Custom("tr");
        public static ElementInfo Track => Custom("track", true, Default, Kind, BaseAttribute.Label, Src, SrcLang);

        public static ElementInfo U => Custom("u");
        public static ElementInfo Ul => Custom("ul");

        public static ElementInfo Var => Custom("var");

        public static ElementInfo Video => Custom("video", AutoPlay, Controls, CrossOrigin, Height, Loop, Muted, Preload, Src, Width);

        public static ElementInfo Wbr => Custom("wbr");

        private static ElementInfo Custom(string tag) => Custom(tag, false);
        private static ElementInfo Custom(string tag, params HtmlAttribute[] attributes) => Custom(tag, false, attributes);
        private static ElementInfo Custom(string tag, bool isVoid, params HtmlAttribute[] attributes) => new ElementInfo(tag, isVoid, attributes);
    }
}
