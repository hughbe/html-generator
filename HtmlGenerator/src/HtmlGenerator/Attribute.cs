namespace HtmlGenerator
{
    public static class Attribute
    {
        public static HtmlAttribute Accept(string value) => Custom("accept", value);
        public static HtmlAttribute AcceptCharset(string value) => Custom("accept-charset", value);
        public static HtmlAttribute AccessKey(string value) => Custom("accesskey", value);
        public static HtmlAttribute Action(string value) => Custom("action", value);
        public static HtmlAttribute AllowFullScreen(string value) => Custom("allowfullscreen", value);
        public static HtmlAttribute Alt(string value) => Custom("alt", value);
        public static HtmlAttribute Async(string value) => Custom("async", value);
        public static HtmlAttribute AutoComplete(string value) => Custom("autocomplete", value);
        public static HtmlAttribute AutoFocus => Custom("autofocus");
        public static HtmlAttribute AutoPlay(string value) => Custom("autoplay", value);
        public static HtmlAttribute AutoSave(string value) => Custom("autosave", value);

        public static HtmlAttribute Charset(string value) => Custom("charset", value);
        public static HtmlAttribute Checked => Custom("checked");
        public static HtmlAttribute Cite(string value) => Custom("cite", value);
        public static HtmlAttribute Class(string value) => Custom("class", value);
        public static HtmlAttribute Color(string value) => Custom("color", value);
        public static HtmlAttribute Cols(string value) => Custom("cols", value);
        public static HtmlAttribute ColSpan(string value) => Custom("colspan", value);
        public static HtmlAttribute Command(string value) => Custom("command", value);
        public static HtmlAttribute Compact(string value) => Custom("compact", value);
        public static HtmlAttribute Content(string value) => Custom("content", value);
        public static HtmlAttribute ContentEditable(string value) => Custom("contentEditable", value);
        public static HtmlAttribute ContextMenu(string value) => Custom("contextMenu", value);
        public static HtmlAttribute Controls(string value) => Custom("controls", value);
        public static HtmlAttribute Coords(string value) => Custom("coords", value);
        public static HtmlAttribute CrossOrigin(string value) => Custom("crossorigin", value);

        public static HtmlAttribute Data(string value) => Custom("data", value);
        public static HtmlAttribute DateTime(string value) => Custom("datetime", value);
        public static HtmlAttribute DefaultStyle(string value) => Custom("default-style", value);
        public static HtmlAttribute Defer(string value) => Custom("defer", value);
        public static HtmlAttribute Dir(string value) => Custom("dir", value);
        public static HtmlAttribute Disabled => Custom("disabled");
        public static HtmlAttribute Download(string value) => Custom("download", value);
        public static HtmlAttribute Draggable(string value) => Custom("draggable", value);
        public static HtmlAttribute DropZone(string value) => Custom("dropzone", value);

        public static HtmlAttribute EncType(string value) => Custom("enctype", value);

        public static HtmlAttribute For(string value) => Custom("for", value);
        public static HtmlAttribute Form(string value) => Custom("form", value);
        public static HtmlAttribute FormAction(string value) => Custom("formaction", value);
        public static HtmlAttribute FormEncType(string value) => Custom("formenctype", value);
        public static HtmlAttribute FormMethod(string value) => Custom("formmethod", value);
        public static HtmlAttribute FormNoValidate => Custom("formnovalidate");
        public static HtmlAttribute FormTarget(string value) => Custom("formtarget", value);

        public static HtmlAttribute Headers(string value) => Custom("headers", value);
        public static HtmlAttribute Height(string value) => Custom("height", value);
        public static HtmlAttribute Hidden(string value) => Custom("hidden", value);
        public static HtmlAttribute High(string value) => Custom("high", value);
        public static HtmlAttribute Href(string value) => Custom("href", value);
        public static HtmlAttribute HrefLang(string value) => Custom("hreflang", value);
        public static HtmlAttribute HttpEquiv(string value) => Custom("http-equiv", value);

        public static HtmlAttribute Icon(string value) => Custom("icon", value);
        public static HtmlAttribute Id(string value) => Custom("id", value);
        public static HtmlAttribute InputMode(string value) => Custom("inputmode", value);
        public static HtmlAttribute Integrity(string value) => Custom("integrity", value);
        public static HtmlAttribute IsMap(string value) => Custom("ismap", value);

        public static HtmlAttribute Kind(string value) => Custom("kind", value);

        public static HtmlAttribute Label(string value) => Custom("label", value);
        public static HtmlAttribute Lang(string value) => Custom("lang", value);
        public static HtmlAttribute List(string value) => Custom("list", value);
        public static HtmlAttribute LongDesc(string value) => Custom("longdesc", value);
        public static HtmlAttribute Loop(string value) => Custom("loop", value);
        public static HtmlAttribute Low(string value) => Custom("low", value);

        public static HtmlAttribute Max(string value) => Custom("max", value);
        public static HtmlAttribute MaxLength(string value) => Custom("maxLength", value);
        public static HtmlAttribute Media(string value) => Custom("media", value);
        public static HtmlAttribute Min(string value) => Custom("min", value);
        public static HtmlAttribute MinLength(string value) => Custom("minLeng  th", value);
        public static HtmlAttribute Multiple(string value) => Custom("multiple");
        public static HtmlAttribute Muted(string value) => Custom("muted", value);

        public static HtmlAttribute Name(string value) => Custom("name", value);
        public static HtmlAttribute NoValidate => Custom("novalidate");
        public static HtmlAttribute NoWrap(string value) => Custom("nowrap", value);

        public static HtmlAttribute Optimum(string value) => Custom("optimum", value);
        public static HtmlAttribute Open(string value) => Custom("open", value);

        public static HtmlAttribute Pattern(string value) => Custom("pattern", value);
        public static HtmlAttribute Ping(string value) => Custom("ping", value);
        public static HtmlAttribute Placeholder(string value) => Custom("placeholder", value);
        public static HtmlAttribute Played(string value) => Custom("played", value);
        public static HtmlAttribute Preload(string value) => Custom("preload", value);
        public static HtmlAttribute Poster(string value) => Custom("poster", value);

        public static HtmlAttribute RadioGroup(string value) => Custom("radiogroup", value);
        public static HtmlAttribute Readonly => Custom("readonly");
        public static HtmlAttribute Refresh(string value) => Custom("refresh", value);
        public static HtmlAttribute Rel(string value) => Custom("rel", value);
        public static HtmlAttribute Required => Custom("required");
        public static HtmlAttribute Reversed(string value) => Custom("reversed", value);
        public static HtmlAttribute Rows(string value) => Custom("rows", value);
        public static HtmlAttribute RowSpan(string value) => Custom("rowspan", value);

        public static HtmlAttribute Sandbox(string value) => Custom("sandbox");
        public static HtmlAttribute Seamless => Custom("seamless");
        public static HtmlAttribute Selected => Custom("selected");
        public static HtmlAttribute SelectionDirection(string value) => Custom("selectionDirection", value);
        public static HtmlAttribute Scope(string value) => Custom("scope", value);
        public static HtmlAttribute Scoped => Custom("scoped");
        public static HtmlAttribute Shape(string value) => Custom("shape", value);
        public static HtmlAttribute Size(string value) => Custom("size", value);
        public static HtmlAttribute Sizes(string value) => Custom("sizes", value);
        public static HtmlAttribute Span(string value) => Custom("span", value);
        public static HtmlAttribute SpellCheck(string value) => Custom("spellCheck", value);
        public static HtmlAttribute Src(string value) => Custom("src", value);
        public static HtmlAttribute SrcDoc(string value) => Custom("srcdoc", value);
        public static HtmlAttribute SrcLang(string value) => Custom("srclang", value);
        public static HtmlAttribute SrcSet(string value) => Custom("srcset", value);
        public static HtmlAttribute Start(string value) => Custom("start", value);
        public static HtmlAttribute Step(string value) => Custom("step", value);
        public static HtmlAttribute Style(string value) => Custom("style", value);

        public static HtmlAttribute TabIndex(string value) => Custom("tabIndex", value);
        public static HtmlAttribute Target(string value) => Custom("target", value);
        public static HtmlAttribute Text(string value) => Custom("text", value);
        public static HtmlAttribute Title(string value) => Custom("title", value);
        public static HtmlAttribute Translate(string value) => Custom("translate", value);
        public static HtmlAttribute Type(string value) => Custom("type", value);
        public static HtmlAttribute TypeMustMatch => Custom("typemustmatch");

        public static HtmlAttribute UseMap(string value) => Custom("usemap", value);

        public static HtmlAttribute Value(string value) => Custom("value", value);
        public static HtmlAttribute Volume(string value) => Custom("volume", value);

        public static HtmlAttribute Width(string value) => Custom("width", value);
        public static HtmlAttribute Wrap(string value) => Custom("wrap", value);

        public static HtmlAttribute Xmls(string value) => Custom("xmls", value);

        public static HtmlAttribute Custom(string key) => new HtmlAttribute(key, null, true);
        public static HtmlAttribute Custom(string key, string value) => new HtmlAttribute(key, value, false);
    }
}