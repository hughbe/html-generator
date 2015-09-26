namespace HtmlGenerator
{
    public static class Tags
    {
        //Root
        public static HtmlElement Html => new HtmlElement("html");

        //Meta
        public static HtmlElement Head => new HtmlElement("head");
        public static HtmlElement Title => new HtmlElement("title");

        public static HtmlElement Script => new HtmlElement("script"); //Uses attributes (async, integrity, src, type, text, defer, crossorigin)
        public static HtmlElement Noscript => new HtmlElement("noscript");
        public static HtmlElement Canvas => new HtmlElement("canvas"); //Uses attributes (height, width)

        //Structure
        public static HtmlElement Address => new HtmlElement("address");
        public static HtmlElement Article => new HtmlElement("article");
        public static HtmlElement Body => new HtmlElement("body");
        public static HtmlElement Div => new HtmlElement("div");
        public static HtmlElement Footer => new HtmlElement("footer");
        public static HtmlElement Header => new HtmlElement("header");
        public static HtmlElement Main => new HtmlElement("main");
        public static HtmlElement Nav => new HtmlElement("nav");
        public static HtmlElement Section => new HtmlElement("section");
        public static HtmlElement Span => new HtmlElement("span");
        public static HtmlElement Template => new HtmlElement("template"); //Unsupported

        //Seperators
        public static HtmlElement Br => new HtmlElement("br");
        public static HtmlElement Hr => new HtmlElement("hr"); //Uses attributes (color)
        public static HtmlElement Wbr => new HtmlElement("wbr");

        //Lists
        public static HtmlElement Dd => new HtmlElement("dd"); //Uses attributes (nowrap)
        public static HtmlElement Dl => new HtmlElement("dl"); //Uses attributes (compact)
        public static HtmlElement Dt => new HtmlElement("dt");

        public static HtmlElement Li => new HtmlElement("li"); //Uses attributes (value)
        public static HtmlElement Ol => new HtmlElement("ol"); //Uses attributes (reversed, start, type)
        public static HtmlElement Ul => new HtmlElement("ul");

        //Text
        public static HtmlElement Anchor => new HtmlElement("a"); //Uses attributes (download, href, hreflang, media, ping, rel, target, type)

        public static HtmlElement H1 => new HtmlElement("h1");
        public static HtmlElement H2 => new HtmlElement("h2");
        public static HtmlElement H3 => new HtmlElement("h3");
        public static HtmlElement H4 => new HtmlElement("h4");
        public static HtmlElement H5 => new HtmlElement("h5");
        public static HtmlElement H6 => new HtmlElement("h6");

        public static HtmlElement P => new HtmlElement("p");

        //Displaying External Content
        public static HtmlElement Cite => new HtmlElement("cite");
        public static HtmlElement Data => new HtmlElement("data"); //Uses attributes (value); unsupported
        public static HtmlElement Dfn => new HtmlElement("dfn");
        public static HtmlElement Figure => new HtmlElement("figure");
        public static HtmlElement FigCaption => new HtmlElement("figcaption");
        public static HtmlElement Q => new HtmlElement("q"); //Uses attributes (cite)
        public static HtmlElement Sub => new HtmlElement("sub");
        public static HtmlElement Sup => new HtmlElement("sup");
        public static HtmlElement Time => new HtmlElement("time"); //Uses attributes (datetime)

        //Formatting
        public static HtmlElement Abbr => new HtmlElement("abbr");
        public static HtmlElement B => new HtmlElement("b"); //LEGACY
        public static HtmlElement Code => new HtmlElement("code");
        public static HtmlElement Del => new HtmlElement("del"); //Uses attributes (cite, datetime)
        public static HtmlElement Em => new HtmlElement("em");
        public static HtmlElement I => new HtmlElement("i");
        public static HtmlElement Ins => new HtmlElement("ins"); //Uses attributes (cite, datetime)
        public static HtmlElement Kbd => new HtmlElement("kbd");
        public static HtmlElement Mark => new HtmlElement("mark");
        public static HtmlElement Pre => new HtmlElement("pre");
        public static HtmlElement Samp => new HtmlElement("samp");
        public static HtmlElement Small => new HtmlElement("small");
        public static HtmlElement Strong => new HtmlElement("strong");
        public static HtmlElement U => new HtmlElement("u");
        public static HtmlElement Var => new HtmlElement("var");

        //Localisation
        public static HtmlElement Bdi => new HtmlElement("bdi");
        public static HtmlElement Rp => new HtmlElement("rp");
        public static HtmlElement Ruby => new HtmlElement("ruby");
        public static HtmlElement Rt => new HtmlElement("rt");
        public static HtmlElement Rtc => new HtmlElement("rtc");

        //Multimedia
        public static HtmlElement Area => new HtmlElement("area"); //Uses attributes (alt, coords, download, href, hreflang, media, rel, shape, target, type)
        public static HtmlElement Audio => new HtmlElement("audio"); //Uses attributes (autoplay, buffered, controls, loop, muted, played, preload, src, volume)
        public static HtmlElement Img => new HtmlElement("img"); //Uses attributes (alt, crossorigin, height, ismap, longdesc, sizes, src, srcset, width, usemap)
        public static HtmlElement Map => new HtmlElement("img"); //Uses attributes (name)
        public static HtmlElement Track => new HtmlElement("img"); //Uses attributes (default, kind, label, src, srclang)
        public static HtmlElement Video => new HtmlElement("video"); //Uses attributes (autoplay, buffers, controls, crossorigin, height, loop, muted, played, preload, poster, src, width)

        //Embedding
        public static HtmlElement Embed => new HtmlElement("embed"); //Uses attributes (height, src, type, width)
        public static HtmlElement Iframe => new HtmlElement("iframe"); //Uses attributes (allowfullscreen, height, name, sandbox, seamless, src, srcdoc, width)
        public static HtmlElement Object => new HtmlElement("object"); //Uses attributes (data, form, height, height, name, type, typemustmatch, usemap, width)
        public static HtmlElement Param => new HtmlElement("param"); //Uses attributes (name, value)
        public static HtmlElement Source => new HtmlElement("source"); //Uses attributes (src, type)

        //Table
        public static HtmlElement Caption => new HtmlElement("caption");
        public static HtmlElement Col => new HtmlElement("col"); //Uses attributes (span)
        public static HtmlElement Colgroup => new HtmlElement("colgroup"); //Uses attributes (span)
        public static HtmlElement Table => new HtmlElement("table");
        public static HtmlElement Tbody => new HtmlElement("tbody");
        public static HtmlElement Tfoot => new HtmlElement("tfoot");
        public static HtmlElement Th => new HtmlElement("th"); //Uses attributes (colspan, headers, rowspan, scope)
        public static HtmlElement Thead => new HtmlElement("thead");
        public static HtmlElement Tr => new HtmlElement("tr");

        //Forms
        public static HtmlElement Button => new HtmlElement("button"); //Uses attributes (autofocus, disabled, form, formaction, formenctype, formmethod, formnovalidate, formtarget, name, type, value)
        public static HtmlElement Datalist => new HtmlElement("datalist");
        public static HtmlElement Fieldset => new HtmlElement("fieldset"); //Uses attributes (disabled, form, name)
        public static HtmlElement Form => new HtmlElement("form"); //Uses attributes (accept-charset, action, autocomplete, enctype, method, name, novalidate, target)
        public static HtmlElement Input => new HtmlElement("input"); //Uses attributes (type, accept, autocomplete, autofocus, autosave, checked, disabled, form, formaction, formenctype, formmethod, formnovalidate, formtarget, height, inputmode, list, max, maxlength, min, minLength, multiple, name, pattern, placeholder, readonly, required, selectionDirection, size, spellCheck, src, step, tabIndex, value, width)
        public static HtmlElement Label => new HtmlElement("label"); //Uses attributes (accesskey, for, form)
        public static HtmlElement Legend => new HtmlElement("legend");
        public static HtmlElement Meter => new HtmlElement("meter"); //Uses attributes (value, min, max, low, high, optimum, form)
        public static HtmlElement Optgroup => new HtmlElement("optgroup"); //Uses attributes (disabled, label)
        public static HtmlElement Option => new HtmlElement("option"); //Uses attributes (disabled, label, selected, value)
        public static HtmlElement Output => new HtmlElement("output"); //Uses attributes (for, form, name)
        public static HtmlElement Progress => new HtmlElement("progress"); //Uses attributes (max, value)
        public static HtmlElement Select => new HtmlElement("select"); //Uses attributes (autofocus, disabled, form, multiple, name, required, size)
        public static HtmlElement Textarea => new HtmlElement("textarea"); //Uses attributes (autocomplete, autofocus, cols, disabled, form, maxlength, minLength, name, placeholder, readonly, required, rows, selectiondirection, selectionend, selectionstart, spellcheck, wrap)

        //Interactivity
        public static HtmlElement Details => new HtmlElement("details"); //Uses attributes (open); Unsupported
        public static HtmlElement Dialog => new HtmlElement("dialog"); //Uses attributes (open); Unsupported
        public static HtmlElement Menu => new HtmlElement("menu"); //Uses attributes (label, type); Unsupported
        public static HtmlElement MenuItem => new HtmlElement("menutiem"); //Uses attributes (checked, command, default, disabled, icon, label, radiogroup, type); Unsupported
        public static HtmlElement Summary => new HtmlElement("summary"); //Unsupported
        
    }
}
