using System;

namespace HtmlGenerator
{
    public struct Attribute
    {
        public static Attribute Accept => new Attribute("accept");
        public static Attribute AcceptCharset => new Attribute("accept-charset");
        public static Attribute AccessKey => new Attribute("accesskey");
        public static Attribute Action => new Attribute("action");
        public static Attribute AllowFullScreen => new Attribute("allowfullscreen");
        public static Attribute Alt => new Attribute("alt");
        public static Attribute Async => new Attribute("async");
        public static Attribute AutoComplete => new Attribute("autocomplete");
        public static Attribute AutoFocus => new Attribute("autofocus");
        public static Attribute AutoPlay => new Attribute("autoplay");
        public static Attribute AutoSave => new Attribute("autosave");

        public static Attribute Buffered => new Attribute("buffered");
        public static Attribute Buffers => new Attribute("buffers");

        public static Attribute Charset => new Attribute("charset");
        public static Attribute Checked => new Attribute("checked");
        public static Attribute Cite => new Attribute("cite");
        public static Attribute Class => new Attribute("class");
        public static Attribute Color => new Attribute("color");
        public static Attribute Cols => new Attribute("cols");
        public static Attribute ColSpan => new Attribute("colspan");
        public static Attribute Command => new Attribute("command");
        public static Attribute Compact => new Attribute("compact");
        public static Attribute Content => new Attribute("content");
        public static Attribute ContentEditable => new Attribute("contentEditable");
        public static Attribute ContextMenu => new Attribute("contextMenu");
        public static Attribute Controls => new Attribute("controls");
        public static Attribute Coords => new Attribute("coords");
        public static Attribute CrossOrigin => new Attribute("crossorigin");

        public static Attribute Data => new Attribute("data");
        public static Attribute DateTime => new Attribute("datetime");
        public static Attribute Default => new Attribute("default");
        public static Attribute DefaultStyle => new Attribute("default-style");
        public static Attribute Defer => new Attribute("defer");
        public static Attribute Dir => new Attribute("dir");
        public static Attribute Disabled => new Attribute("disabled");
        public static Attribute Download => new Attribute("download");
        public static Attribute Draggable => new Attribute("draggable");
        public static Attribute DropZone => new Attribute("dropzone");

        public static Attribute EncType => new Attribute("enctype");

        public static Attribute For => new Attribute("for");
        public static Attribute Form => new Attribute("form");
        public static Attribute FormAction => new Attribute("formaction");
        public static Attribute FormEncType => new Attribute("formenctype");
        public static Attribute FormMethod => new Attribute("formmethod");
        public static Attribute FormNoValidate => new Attribute("formnovalidate");
        public static Attribute FormTarget => new Attribute("formtarget");

        public static Attribute Headers => new Attribute("headers");
        public static Attribute Height => new Attribute("height");
        public static Attribute Hidden => new Attribute("hidden");
        public static Attribute High => new Attribute("high");
        public static Attribute Href => new Attribute("href");
        public static Attribute HrefLang => new Attribute("hreflang");
        public static Attribute HttpEquiv => new Attribute("http-equiv");

        public static Attribute Icon => new Attribute("icon");
        public static Attribute Id => new Attribute("id");
        public static Attribute InputMode => new Attribute("inputmode");
        public static Attribute Integrity => new Attribute("integrity");
        public static Attribute IsMap => new Attribute("ismap");

        public static Attribute Kind => new Attribute("kind");

        public static Attribute Label => new Attribute("label");
        public static Attribute Lang => new Attribute("lang");
        public static Attribute List => new Attribute("list");
        public static Attribute LongDesc => new Attribute("longdesc");
        public static Attribute Loop => new Attribute("loop");
        public static Attribute Low => new Attribute("low");

        public static Attribute Max => new Attribute("max");
        public static Attribute MaxLength => new Attribute("maxLength");
        public static Attribute Media => new Attribute("media");
        public static Attribute Min => new Attribute("min");
        public static Attribute MinLength => new Attribute("minLength");
        public static Attribute Multiple => new Attribute("multiple");
        public static Attribute Muted => new Attribute("muted");

        public static Attribute Name => new Attribute("name");
        public static Attribute NoValidate => new Attribute("novalidate");
        public static Attribute NoWrap => new Attribute("nowrap");

        public static Attribute Optimum => new Attribute("optimum");
        public static Attribute Open => new Attribute("open");

        public static Attribute Pattern => new Attribute("pattern");
        public static Attribute Ping => new Attribute("ping");
        public static Attribute Placeholder => new Attribute("placeholder");
        public static Attribute Played => new Attribute("played");
        public static Attribute Preload => new Attribute("preload");
        public static Attribute Poster => new Attribute("poster");

        public static Attribute RadioGroup => new Attribute("radiogroup");
        public static Attribute Readonly => new Attribute("readonly");
        public static Attribute Refresh => new Attribute("refresh");
        public static Attribute Rel => new Attribute("rel");
        public static Attribute Required => new Attribute("required");
        public static Attribute Reversed => new Attribute("reversed");
        public static Attribute Rows => new Attribute("rows");
        public static Attribute RowSpan => new Attribute("rowspan");

        public static Attribute Sandbox => new Attribute("sandbox");
        public static Attribute Seamless => new Attribute("seamless");
        public static Attribute Selected => new Attribute("selected");
        public static Attribute SelectionDirection => new Attribute("selectionDirection");
        public static Attribute Scope => new Attribute("scope");
        public static Attribute Scoped => new Attribute("scoped");
        public static Attribute Shape => new Attribute("shape");
        public static Attribute Size => new Attribute("size");
        public static Attribute Sizes => new Attribute("sizes");
        public static Attribute Span => new Attribute("span");
        public static Attribute SpellCheck => new Attribute("spellCheck");
        public static Attribute Src => new Attribute("src");
        public static Attribute SrcDoc => new Attribute("srcdoc");
        public static Attribute SrcLang => new Attribute("srclang");
        public static Attribute SrcSet => new Attribute("srcset");
        public static Attribute Start => new Attribute("start");
        public static Attribute Step => new Attribute("step");
        public static Attribute Style => new Attribute("style");

        public static Attribute TabIndex => new Attribute("tabIndex");
        public static Attribute Target => new Attribute("target");
        public static Attribute Text => new Attribute("text");
        public static Attribute Title => new Attribute("title");
        public static Attribute Translate => new Attribute("translate");
        public static Attribute Type => new Attribute("type");
        public static Attribute TypeMustMatch => new Attribute("typemustmatch");

        public static Attribute UseMap => new Attribute("usemap");

        public static Attribute Value => new Attribute("value");
        public static Attribute Volume => new Attribute("volume");

        public static Attribute Width => new Attribute("width");
        public static Attribute Wrap => new Attribute("wrap");

        public static Attribute Xmls => new Attribute("xmls");

        public string Key { get; }

        public Attribute(string key)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }
            if (key.Length == 0)
            {
                throw new ArgumentException("Key must not be an empty string", nameof(key));
            }
            Key = key;
        }
    }
}
