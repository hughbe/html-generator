namespace HtmlGenerator.Meta
{
    public static class MetaAttributes
    {
        public static AttributeInfo Accept => Custom("accept");
        public static AttributeInfo AcceptCharset => Custom("accept-charset");
        public static AttributeInfo AccessKey => Custom("accesskey");
        public static AttributeInfo Action => Custom("action");
        public static AttributeInfo AllowFullScreen => Custom("allowfullscreen", true);
        public static AttributeInfo Alt => Custom("alt");
        public static AttributeInfo Async => Custom("async");
        public static AttributeInfo AutoComplete => Custom("autocomplete");
        public static AttributeInfo AutoFocus => Custom("autofocus", true);
        public static AttributeInfo AutoPlay => Custom("autoplay");
        public static AttributeInfo AutoSave => Custom("autosave");

        public static AttributeInfo Charset => Custom("charset");
        public static AttributeInfo Checked => Custom("checked", true);
        public static AttributeInfo Cite => Custom("cite");
        public static AttributeInfo Class => Custom("class");
        public static AttributeInfo Color => Custom("color");
        public static AttributeInfo Cols => Custom("cols");
        public static AttributeInfo ColSpan => Custom("colspan");
        public static AttributeInfo Command => Custom("command");
        public static AttributeInfo Compact => Custom("compact");
        public static AttributeInfo Content => Custom("content");
        public static AttributeInfo ContentEditable => Custom("contentEditable");
        public static AttributeInfo ContextMenu => Custom("contextMenu");
        public static AttributeInfo Controls => Custom("controls", true);
        public static AttributeInfo Coords => Custom("coords");
        public static AttributeInfo CrossOrigin => Custom("crossorigin");

        public static AttributeInfo Data => Custom("data");
        public static AttributeInfo DateTime => Custom("datetime");
        public static AttributeInfo Default => Custom("default", true);
        public static AttributeInfo DefaultStyle => Custom("default-style");
        public static AttributeInfo Defer => Custom("defer");
        public static AttributeInfo Dir => Custom("dir");
        public static AttributeInfo Disabled => Custom("disabled", true);
        public static AttributeInfo Download => Custom("download");
        public static AttributeInfo Draggable => Custom("draggable");
        public static AttributeInfo DropZone => Custom("dropzone");

        public static AttributeInfo EncType => Custom("enctype");

        public static AttributeInfo For => Custom("for");
        public static AttributeInfo Form => Custom("form");
        public static AttributeInfo FormAction => Custom("formaction");
        public static AttributeInfo FormEncType => Custom("formenctype");
        public static AttributeInfo FormMethod => Custom("formmethod");
        public static AttributeInfo FormNoValidate => Custom("formnovalidate", true);
        public static AttributeInfo FormTarget => Custom("formtarget");

        public static AttributeInfo Headers => Custom("headers");
        public static AttributeInfo Height => Custom("height");
        public static AttributeInfo Hidden => Custom("hidden");
        public static AttributeInfo High => Custom("high");
        public static AttributeInfo Href => Custom("href");
        public static AttributeInfo HrefLang => Custom("hreflang");
        public static AttributeInfo HttpEquiv => Custom("http-equiv");

        public static AttributeInfo Icon => Custom("icon");
        public static AttributeInfo Id => Custom("id");
        public static AttributeInfo InputMode => Custom("inputmode");
        public static AttributeInfo Integrity => Custom("integrity");
        public static AttributeInfo IsMap => Custom("ismap");

        public static AttributeInfo Kind => Custom("kind");

        public static AttributeInfo Label => Custom("label");
        public static AttributeInfo Lang => Custom("lang");
        public static AttributeInfo List => Custom("list");
        public static AttributeInfo LongDesc => Custom("longdesc");
        public static AttributeInfo Loop => Custom("loop");
        public static AttributeInfo Low => Custom("low");

        public static AttributeInfo Max => Custom("max");
        public static AttributeInfo MaxLength => Custom("maxLength");
        public static AttributeInfo Media => Custom("media");
        public static AttributeInfo Method => Custom("method");
        public static AttributeInfo Min => Custom("min");
        public static AttributeInfo MinLength => Custom("minLength");
        public static AttributeInfo Multiple => Custom("multiple", true);
        public static AttributeInfo Muted => Custom("muted");

        public static AttributeInfo Name => Custom("name");
        public static AttributeInfo NoValidate => Custom("novalidate", true);
        public static AttributeInfo NoWrap => Custom("nowrap");

        public static AttributeInfo Optimum => Custom("optimum");
        public static AttributeInfo Open => Custom("open");

        public static AttributeInfo Pattern => Custom("pattern");
        public static AttributeInfo Ping => Custom("ping");
        public static AttributeInfo Placeholder => Custom("placeholder");
        public static AttributeInfo Preload => Custom("preload");
        public static AttributeInfo Poster => Custom("poster");

        public static AttributeInfo RadioGroup => Custom("radiogroup");
        public static AttributeInfo Readonly => Custom("readonly", true);
        public static AttributeInfo Refresh => Custom("refresh");
        public static AttributeInfo Rel => Custom("rel");
        public static AttributeInfo Required => Custom("required", true);
        public static AttributeInfo Reversed => Custom("reversed");
        public static AttributeInfo Rows => Custom("rows");
        public static AttributeInfo RowSpan => Custom("rowspan");

        public static AttributeInfo Sandbox => Custom("sandbox", true);
        public static AttributeInfo Seamless => Custom("seamless", true);
        public static AttributeInfo Selected => Custom("selected", true);
        public static AttributeInfo SelectionDirection => Custom("selectionDirection");
        public static AttributeInfo Scope => Custom("scope");
        public static AttributeInfo Scoped => Custom("scoped", true);
        public static AttributeInfo Shape => Custom("shape");
        public static AttributeInfo Size => Custom("size");
        public static AttributeInfo Sizes => Custom("sizes");
        public static AttributeInfo Span => Custom("span");
        public static AttributeInfo SpellCheck => Custom("spellCheck");
        public static AttributeInfo Src => Custom("src");
        public static AttributeInfo SrcDoc => Custom("srcdoc");
        public static AttributeInfo SrcLang => Custom("srclang");
        public static AttributeInfo SrcSet => Custom("srcset");
        public static AttributeInfo Start => Custom("start");
        public static AttributeInfo Step => Custom("step");
        public static AttributeInfo Style => Custom("style");

        public static AttributeInfo TabIndex => Custom("tabIndex");
        public static AttributeInfo Target => Custom("target");
        public static AttributeInfo Text => Custom("text");
        public static AttributeInfo Title => Custom("title");
        public static AttributeInfo Translate => Custom("translate");
        public static AttributeInfo Type => Custom("type");
        public static AttributeInfo TypeMustMatch => Custom("typemustmatch", true);

        public static AttributeInfo UseMap => Custom("usemap");

        public static AttributeInfo Value => Custom("value");
        public static AttributeInfo Volume => Custom("volume");

        public static AttributeInfo Width => Custom("width");
        public static AttributeInfo Wrap => Custom("wrap");

        public static AttributeInfo Xmls => Custom("xmls");

        public static AttributeInfo Custom(string key) => Custom(key, false);
        public static AttributeInfo Custom(string key, bool isVoid) => new AttributeInfo(key, isVoid);
    }
}
