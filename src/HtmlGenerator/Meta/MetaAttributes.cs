namespace HtmlGenerator.Meta
{
    public static class MetaAttributes
    {
        public static AttributeInfo Accept => Basic("accept");
        public static AttributeInfo AcceptCharset => Basic("accept-charset");
        public static AttributeInfo AccessKey => Global("accesskey");
        public static AttributeInfo Action => Basic("action");
        public static AttributeInfo AllowFullScreen => Void("allowfullscreen");
        public static AttributeInfo Alt => Basic("alt");
        public static AttributeInfo Async => Basic("async");
        public static AttributeInfo AutoComplete => Basic("autocomplete");
        public static AttributeInfo AutoFocus => Void("autofocus");
        public static AttributeInfo AutoPlay => Basic("autoplay");
        public static AttributeInfo AutoSave => Basic("autosave");

        public static AttributeInfo Charset => Basic("charset");
        public static AttributeInfo Checked => Void("checked");
        public static AttributeInfo Cite => Basic("cite");
        public static AttributeInfo Class => Global("class");
        public static AttributeInfo Color => Basic("color");
        public static AttributeInfo Cols => Basic("cols");
        public static AttributeInfo ColSpan => Basic("colspan");
        public static AttributeInfo Command => Basic("command");
        public static AttributeInfo Compact => Basic("compact");
        public static AttributeInfo Content => Basic("content");
        public static AttributeInfo ContentEditable => Global("contentEditable");
        public static AttributeInfo ContextMenu => Basic("contextMenu");
        public static AttributeInfo Controls => Void("controls");
        public static AttributeInfo Coords => Basic("coords");
        public static AttributeInfo CrossOrigin => Basic("crossorigin");

        public static AttributeInfo Data => Basic("data");
        public static AttributeInfo DateTime => Basic("datetime");
        public static AttributeInfo Default => Void("default");
        public static AttributeInfo DefaultStyle => Basic("default-style");
        public static AttributeInfo Defer => Basic("defer");
        public static AttributeInfo Dir => Global("dir");
        public static AttributeInfo Disabled => Void("disabled");
        public static AttributeInfo Download => Basic("download");
        public static AttributeInfo Draggable => Basic("draggable");
        public static AttributeInfo DropZone => Basic("dropzone");

        public static AttributeInfo EncType => Basic("enctype");

        public static AttributeInfo For => Basic("for");
        public static AttributeInfo Form => Basic("form");
        public static AttributeInfo FormAction => Basic("formaction");
        public static AttributeInfo FormEncType => Basic("formenctype");
        public static AttributeInfo FormMethod => Basic("formmethod");
        public static AttributeInfo FormNoValidate => Void("formnovalidate");
        public static AttributeInfo FormTarget => Basic("formtarget");

        public static AttributeInfo Headers => Basic("headers");
        public static AttributeInfo Height => Basic("height");
        public static AttributeInfo Hidden => Global("hidden");
        public static AttributeInfo High => Basic("high");
        public static AttributeInfo Href => Basic("href");
        public static AttributeInfo HrefLang => Basic("hreflang");
        public static AttributeInfo HttpEquiv => Basic("http-equiv");

        public static AttributeInfo Icon => Basic("icon");
        public static AttributeInfo Id => Global("id");
        public static AttributeInfo InputMode => Basic("inputmode");
        public static AttributeInfo Integrity => Basic("integrity");
        public static AttributeInfo IsMap => Basic("ismap");

        public static AttributeInfo Kind => Basic("kind");

        public static AttributeInfo Label => Basic("label");
        public static AttributeInfo Lang => Global("lang");
        public static AttributeInfo List => Basic("list");
        public static AttributeInfo LongDesc => Basic("longdesc");
        public static AttributeInfo Loop => Basic("loop");
        public static AttributeInfo Low => Basic("low");

        public static AttributeInfo Max => Basic("max");
        public static AttributeInfo MaxLength => Basic("maxLength");
        public static AttributeInfo Media => Basic("media");
        public static AttributeInfo Method => Basic("method");
        public static AttributeInfo Min => Basic("min");
        public static AttributeInfo MinLength => Basic("minLength");
        public static AttributeInfo Multiple => Void("multiple");
        public static AttributeInfo Muted => Basic("muted");

        public static AttributeInfo Name => Basic("name");
        public static AttributeInfo NoValidate => Void("novalidate");
        public static AttributeInfo NoWrap => Basic("nowrap");

        public static AttributeInfo Optimum => Basic("optimum");
        public static AttributeInfo Open => Basic("open");

        public static AttributeInfo Pattern => Basic("pattern");
        public static AttributeInfo Ping => Basic("ping");
        public static AttributeInfo Placeholder => Basic("placeholder");
        public static AttributeInfo Preload => Basic("preload");
        public static AttributeInfo Poster => Basic("poster");

        public static AttributeInfo RadioGroup => Basic("radiogroup");
        public static AttributeInfo Readonly => Void("readonly");
        public static AttributeInfo Refresh => Basic("refresh");
        public static AttributeInfo Rel => Basic("rel");
        public static AttributeInfo Required => Void("required");
        public static AttributeInfo Reversed => Basic("reversed");
        public static AttributeInfo Rows => Basic("rows");
        public static AttributeInfo RowSpan => Basic("rowspan");

        public static AttributeInfo Sandbox => Void("sandbox");
        public static AttributeInfo Seamless => Void("seamless");
        public static AttributeInfo Selected => Void("selected");
        public static AttributeInfo SelectionDirection => Basic("selectionDirection");
        public static AttributeInfo Scope => Basic("scope");
        public static AttributeInfo Scoped => Void("scoped");
        public static AttributeInfo Shape => Basic("shape");
        public static AttributeInfo Size => Basic("size");
        public static AttributeInfo Sizes => Basic("sizes");
        public static AttributeInfo Span => Basic("span");
        public static AttributeInfo SpellCheck => Global("spellCheck");
        public static AttributeInfo Src => Basic("src");
        public static AttributeInfo SrcDoc => Basic("srcdoc");
        public static AttributeInfo SrcLang => Basic("srclang");
        public static AttributeInfo SrcSet => Basic("srcset");
        public static AttributeInfo Start => Basic("start");
        public static AttributeInfo Step => Basic("step");
        public static AttributeInfo Style => Basic("style");

        public static AttributeInfo TabIndex => Global("tabIndex");
        public static AttributeInfo Target => Basic("target");
        public static AttributeInfo Text => Basic("text");
        public static AttributeInfo Title => Global("title");
        public static AttributeInfo Translate => Global("translate");
        public static AttributeInfo Type => Basic("type");
        public static AttributeInfo TypeMustMatch => Void("typemustmatch");

        public static AttributeInfo UseMap => Basic("usemap");

        public static AttributeInfo Value => Basic("value");
        public static AttributeInfo Volume => Basic("volume");

        public static AttributeInfo Width => Basic("width");
        public static AttributeInfo Wrap => Basic("wrap");

        public static AttributeInfo Xmls => Basic("xmls");

        private static AttributeInfo Basic(string key) => Custom(key, false, false);
        private static AttributeInfo Void(string key) => Custom(key, true, false);
        private static AttributeInfo Global(string key) => Custom(key, false, true);

        private static AttributeInfo Custom(string key, bool isVoid, bool isGlobal) => new AttributeInfo(key, isVoid, isGlobal);
    }
}
