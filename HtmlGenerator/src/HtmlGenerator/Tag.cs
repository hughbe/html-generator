namespace HtmlGenerator
{
    public static class Tag
    {
        //Root
        public static HtmlElement Html => Custom("html"); //Uses attributes (xmlns)
        public static HtmlElement Base => Custom("base", true); //Uses attributes (href, target)

        //Meta
        public static HtmlElement Head => Custom("head");

        public static HtmlElement Link => Custom("link", true);
        //Uses attributes (crossorigin, href, hreflang, integrity, media, rel, sizes, type)
        public static HtmlElement Style => Custom("style"); //Uses attributes (type, media, scoped, title, disabled)

        public static HtmlElement Meta => Custom("meta", true);
        //Uses attributes (charset, content, http-equiv, default-style, refresh, name)
        public static HtmlElement Title => Custom("title");

        public static HtmlElement Script => Custom("script");
        //Uses attributes (async, integrity, src, type, text, defer, crossorigin)
        public static HtmlElement Noscript => Custom("noscript");
        public static HtmlElement Canvas => Custom("canvas"); //Uses attributes (height, width)

        //Structure
        public static HtmlElement Address => Custom("address");
        public static HtmlElement Article => Custom("article");
        public static HtmlElement Body => Custom("body");
        public static HtmlElement Div => Custom("div");
        public static HtmlElement Footer => Custom("footer");
        public static HtmlElement Header => Custom("header");
        public static HtmlElement Main => Custom("main");
        public static HtmlElement Nav => Custom("nav");
        public static HtmlElement Section => Custom("section");
        public static HtmlElement Span => Custom("span");
        public static HtmlElement Template => Custom("template"); //Unsupported

        //Seperators
        public static HtmlElement Br => Custom("br", true);
        public static HtmlElement Hr => Custom("hr", true); //Uses attributes (color)
        public static HtmlElement Wbr => Custom("wbr");

        //Lists
        public static HtmlElement Dd => Custom("dd"); //Uses attributes (nowrap)
        public static HtmlElement Dl => Custom("dl"); //Uses attributes (compact)
        public static HtmlElement Dt => Custom("dt");

        public static HtmlElement Li => Custom("li"); //Uses attributes (value)
        public static HtmlElement Ol => Custom("ol"); //Uses attributes (reversed, start, type)
        public static HtmlElement Ul => Custom("ul");

        //Text
        public static HtmlElement A => Custom("a");
        //Uses attributes (download, href, hreflang, media, ping, rel, target, type)

        public static HtmlElement H1 => Custom("h1");
        public static HtmlElement H2 => Custom("h2");
        public static HtmlElement H3 => Custom("h3");
        public static HtmlElement H4 => Custom("h4");
        public static HtmlElement H5 => Custom("h5");
        public static HtmlElement H6 => Custom("h6");

        public static HtmlElement P => Custom("p");

        //Displaying External Content
        public static HtmlElement Cite => Custom("cite");
        public static HtmlElement Data => Custom("data"); //Uses attributes (value); unsupported
        public static HtmlElement Dfn => Custom("dfn");
        public static HtmlElement Figure => Custom("figure");
        public static HtmlElement FigCaption => Custom("figcaption");
        public static HtmlElement Q => Custom("q"); //Uses attributes (cite)
        public static HtmlElement Sub => Custom("sub");
        public static HtmlElement Sup => Custom("sup");
        public static HtmlElement Time => Custom("time"); //Uses attributes (datetime)

        //Formatting
        public static HtmlElement Abbr => Custom("abbr");
        public static HtmlElement B => Custom("b"); //LEGACY
        public static HtmlElement Code => Custom("code");
        public static HtmlElement Del => Custom("del"); //Uses attributes (cite, datetime)
        public static HtmlElement Em => Custom("em");
        public static HtmlElement I => Custom("i");
        public static HtmlElement Ins => Custom("ins"); //Uses attributes (cite, datetime)
        public static HtmlElement Kbd => Custom("kbd");
        public static HtmlElement Mark => Custom("mark");
        public static HtmlElement Pre => Custom("pre");
        public static HtmlElement Samp => Custom("samp");
        public static HtmlElement Small => Custom("small");
        public static HtmlElement Strong => Custom("strong");
        public static HtmlElement U => Custom("u");
        public static HtmlElement Var => Custom("var");

        //Localisation
        public static HtmlElement Bdi => Custom("bdi");
        public static HtmlElement Rp => Custom("rp");
        public static HtmlElement Ruby => Custom("ruby");
        public static HtmlElement Rt => Custom("rt");
        public static HtmlElement Rtc => Custom("rtc");

        //Multimedia
        public static HtmlElement Area => Custom("area", true);
        //Uses attributes (alt, coords, download, href, hreflang, media, rel, shape, target, type)
        public static HtmlElement Audio => Custom("audio");
        //Uses attributes (autoplay, buffered, controls, loop, muted, played, preload, src, volume)
        public static HtmlElement Img => Custom("img", true);
        //Uses attributes (alt, crossorigin, height, ismap, longdesc, sizes, src, srcset, width, usemap)
        public static HtmlElement Map => Custom("map"); //Uses attributes (name)
        public static HtmlElement Track => Custom("track", true); //Uses attributes (default, kind, label, src, srclang)
        public static HtmlElement Video => Custom("video");
        //Uses attributes (autoplay, buffers, controls, crossorigin, height, loop, muted, played, preload, poster, src, width)

        //Embedding
        public static HtmlElement Embed => Custom("embed", true); //Uses attributes (height, src, type, width)
        public static HtmlElement Iframe => Custom("iframe");
        //Uses attributes (allowfullscreen, height, name, sandbox, seamless, src, srcdoc, width)
        public static HtmlElement Object => Custom("object");
        //Uses attributes (data, form, height, height, name, type, typemustmatch, usemap, width)
        public static HtmlElement Param => Custom("param", true); //Uses attributes (name, value)
        public static HtmlElement Source => Custom("source", true); //Uses attributes (src, type)

        //Table
        public static HtmlElement Caption => Custom("caption");
        public static HtmlElement Col => Custom("col", true); //Uses attributes (span)
        public static HtmlElement Colgroup => Custom("colgroup"); //Uses attributes (span)
        public static HtmlElement Table => Custom("table");
        public static HtmlElement Tbody => Custom("tbody");
        public static HtmlElement Tfoot => Custom("tfoot");
        public static HtmlElement Th => Custom("th"); //Uses attributes (colspan, headers, rowspan, scope)
        public static HtmlElement Thead => Custom("thead");
        public static HtmlElement Tr => Custom("tr");

        //Forms
        public static HtmlElement Button => Custom("button");
        //Uses attributes (autofocus, disabled, form, formaction, formenctype, formmethod, formnovalidate, formtarget, name, type, value)
        public static HtmlElement Datalist => Custom("datalist");
        public static HtmlElement Fieldset => Custom("fieldset"); //Uses attributes (disabled, form, name)
        public static HtmlElement Form => Custom("form");
        //Uses attributes (accept-charset, action, autocomplete, enctype, method, name, novalidate, target)
        public static HtmlElement Input => Custom("input", true);
        //Uses attributes (type, accept, autocomplete, autofocus, autosave, checked, disabled, form, formaction, formenctype, formmethod, formnovalidate, formtarget, height, inputmode, list, max, maxlength, min, minLength, multiple, name, pattern, placeholder, readonly, required, selectionDirection, size, spellCheck, src, step, tabIndex, value, width)
        public static HtmlElement Label => Custom("label"); //Uses attributes (accesskey, for, form)
        public static HtmlElement Legend => Custom("legend");
        public static HtmlElement Meter => Custom("meter");
        //Uses attributes (value, min, max, low, high, optimum, form)
        public static HtmlElement Optgroup => Custom("optgroup"); //Uses attributes (disabled, label)
        public static HtmlElement Option => Custom("option"); //Uses attributes (disabled, label, selected, value)
        public static HtmlElement Output => Custom("output"); //Uses attributes (for, form, name)
        public static HtmlElement Progress => Custom("progress"); //Uses attributes (max, value)
        public static HtmlElement Select => Custom("select");
        //Uses attributes (autofocus, disabled, form, multiple, name, required, size)
        public static HtmlElement TextArea => Custom("textarea");
        //Uses attributes (autocomplete, autofocus, cols, disabled, form, maxlength, minLength, name, placeholder, readonly, required, rows, selectionDirection, selectionEnd, selectionStart, spellcheck, wrap)

        //Interactivity
        public static HtmlElement Details => Custom("details"); //Uses attributes (open); Unsupported
        public static HtmlElement Dialog => Custom("dialog"); //Uses attributes (open); Unsupported
        public static HtmlElement Menu => Custom("menu"); //Uses attributes (label, type); Unsupported
        public static HtmlElement MenuItem => Custom("menutiem", true);
        //Uses attributes (checked, command, default, disabled, icon, label, radiogroup, type); Unsupported
        public static HtmlElement Summary => Custom("summary"); //Unsupported

        public static HtmlElement Custom(string tag) => Custom(tag, false);
        public static HtmlElement Custom(string tag, bool isVoid) => new HtmlElement(tag, isVoid);
    }
}