using System.Collections.Generic;

namespace HtmlGenerator.SemanticAnalysis
{
    public static partial class Sema
    {
        public static AttributeInformation GetAttributeInformation(string name)
        {
            Requires.NotNullOrWhitespace(name, nameof(name));
            AttributeInformation attributeInformation;
            AttributeInformationDictionary.TryGetValue(name, out attributeInformation);
            return attributeInformation;
        }

        private static Dictionary<string, AttributeInformation> s_attributeInformation;
        private static Dictionary<string, AttributeInformation> AttributeInformationDictionary
        {
            get
            {
                if (s_attributeInformation == null)
                {
                    s_attributeInformation = new Dictionary<string, AttributeInformation>();
                    InitializeAttributeInformation();
                }
                return s_attributeInformation;
            }
        }

        private static void InitializeAttributeInformation()
        {
            // TODO: add (WHATWG only)
            RegisterAtribute(new AttributeInformation(
                "abbr",
                AttributeValueType.Text
            ));

            RegisterAtribute(new AttributeInformation(
                "accept",
                AttributeValueType.MimeTypeCommaDelimitedArray
            ));

            RegisterAtribute(new AttributeInformation(
                "accept-charset",
                AttributeValueType.AsciiCompatibleEncodingSpaceDelimitedArray
            ));

            RegisterAtribute(new AttributeInformation(
                "accesskey",
                AttributeValueType.UniqueOneUnicodeCodePointLengthSpaceDelimitedArray
            ));

            RegisterAtribute(new AttributeInformation(
                "action",
                AttributeValueType.NonEmptyUrl
            ));

            RegisterAtribute(new AttributeInformation(
                "align",
                AttributeValueType.Enumerated,
                validValues: new string[] { "left", "right", "center", "justify" },
                supportedStatus: SupportedStatus.Deprecated
            ));

            RegisterAtribute(new AttributeInformation(
                "allowfullscreen",
                AttributeValueType.Boolean
            ));

            RegisterAtribute(new AttributeInformation(
                "alt",
                AttributeValueType.NonEmptyText
            ));

            // TODO: add
            RegisterAtribute(new AttributeInformation(
                "archive",
                AttributeValueType.NonEmptyUrl,
                supportedStatus: SupportedStatus.Obsolete
            ));

            RegisterAtribute(new AttributeInformation(
                "async",
                AttributeValueType.Boolean
            ));

            RegisterAtribute(new AttributeInformation(
                "autocomplete",
                AttributeValueType.Enumerated,
                validValues: new string[] { "on", "off" }
            ));

            RegisterAtribute(new AttributeInformation(
                "autofocus",
                AttributeValueType.Boolean
            ));

            RegisterAtribute(new AttributeInformation(
                "autoplay",
                AttributeValueType.Boolean
            ));

            RegisterAtribute(new AttributeInformation(
                "autosave",
                AttributeValueType.Boolean
            ));

            RegisterAtribute(new AttributeInformation(
                "background",
                AttributeValueType.NonEmptyUrl,
                supportedStatus: SupportedStatus.Deprecated
            ));

            RegisterAtribute(new AttributeInformation(
                "bgcolor",
                AttributeValueType.Color,
                supportedStatus: SupportedStatus.Deprecated
            ));

            // TODO: W3C only
            RegisterAtribute(new AttributeInformation(
                "border",
                AttributeValueType.Enumerated,
                validValues: new string[] { "", "0", "1" }
            ));

            RegisterAtribute(new AttributeInformation(
                "cellpadding",
                AttributeValueType.Integer,
                supportedStatus: SupportedStatus.Deprecated
            ));

            RegisterAtribute(new AttributeInformation(
                "cellspacing",
                AttributeValueType.Integer,
                supportedStatus: SupportedStatus.Deprecated
            ));

            // TODO: add (WHATWG only)
            RegisterAtribute(new AttributeInformation(
                "challenge",
                AttributeValueType.Text,
                supportedStatus: SupportedStatus.Deprecated
            ));

            RegisterAtribute(new AttributeInformation(
                "charset",
                AttributeValueType.EncodingLabel
            ));

            RegisterAtribute(new AttributeInformation(
                "checked",
                AttributeValueType.Boolean
            ));

            RegisterAtribute(new AttributeInformation(
                "cite",
                AttributeValueType.Url
            ));

            // TODO: unique
            RegisterAtribute(new AttributeInformation(
                "class",
                AttributeValueType.SpaceDelimitedArray,
                isGlobal: true
            ));

            // TODO: add (for br)
            RegisterAtribute(new AttributeInformation(
                "clear",
                AttributeValueType.Enumerated,
                validValues: new string[] { "left", "right", "all" },
                supportedStatus: SupportedStatus.Obsolete
            ));

            // TODO: add
            RegisterAtribute(new AttributeInformation(
                "code",
                AttributeValueType.NonEmptyUrl,
                supportedStatus: SupportedStatus.Obsolete
            ));

            // TODO: add
            RegisterAtribute(new AttributeInformation(
                "codebase",
                AttributeValueType.NonEmptyUrl,
                supportedStatus: SupportedStatus.Obsolete
            ));

            RegisterAtribute(new AttributeInformation(
                "color",
                AttributeValueType.Color,
                supportedStatus: SupportedStatus.Deprecated
            ));

            RegisterAtribute(new AttributeInformation(
                "cols",
                AttributeValueType.PositiveInteger
            ));

            RegisterAtribute(new AttributeInformation(
                "colspan",
                AttributeValueType.PositiveInteger
            ));

            // TODO: W3C, but not WHATWG
            RegisterAtribute(new AttributeInformation(
                "command",
                AttributeValueType.Id
            ));

            RegisterAtribute(new AttributeInformation(
                "compact",
                AttributeValueType.Boolean,
                supportedStatus: SupportedStatus.Deprecated
            ));

            RegisterAtribute(new AttributeInformation(
                "content",
                AttributeValueType.Text
            ));

            RegisterAtribute(new AttributeInformation(
                "contenteditable",
                AttributeValueType.Enumerated,
                isGlobal: true,
                validValues: new string[] { "true", "false", "" }
            ));

            RegisterAtribute(new AttributeInformation(
                "contextmenu",
                AttributeValueType.Id,
                isGlobal: true
            ));

            RegisterAtribute(new AttributeInformation(
                "controls",
                AttributeValueType.Boolean
            ));

            RegisterAtribute(new AttributeInformation(
                "coords",
                AttributeValueType.FloatingPointCommaDelimitedArray
            ));

            RegisterAtribute(new AttributeInformation(
                "crossorigin",
                AttributeValueType.Enumerated,
                validValues: new string[] { "anonymous", "use-credentials" }
            ));

            RegisterAtribute(new AttributeInformation(
                "data",
                AttributeValueType.NonEmptyUrl
            ));

            // TODO: add
            RegisterAtribute(new AttributeInformation(
                "datafld",
                AttributeValueType.Id,
                supportedStatus: SupportedStatus.Obsolete
            ));

            // TODO: add
            RegisterAtribute(new AttributeInformation(
                "datasrc",
                AttributeValueType.Id,
                supportedStatus: SupportedStatus.Obsolete
            ));

            RegisterAtribute(new AttributeInformation(
                "datetime",
                AttributeValueType.DateTime
            ));

            RegisterAtribute(new AttributeInformation(
                "default",
                AttributeValueType.Boolean
            ));

            RegisterAtribute(new AttributeInformation(
                "defer",
                AttributeValueType.Boolean
            ));

            RegisterAtribute(new AttributeInformation(
                "dir",
                AttributeValueType.Enumerated,
                isGlobal: true,
                validValues: new string[] { "ltr", "rtl", "auto" }
            ));

            // TODO: add
            RegisterAtribute(new AttributeInformation(
                "dirname",
                AttributeValueType.NonEmptyText
            ));

            RegisterAtribute(new AttributeInformation(
                "disabled",
                AttributeValueType.Boolean
            ));

            RegisterAtribute(new AttributeInformation(
                "download",
                AttributeValueType.Text
            ));

            RegisterAtribute(new AttributeInformation(
                "draggable",
                AttributeValueType.EncodingLabel,
                isGlobal: true,
                validValues: new string[] { "true", "false" }
            ));

            // TODO: element with dropzone should have title attribute
            RegisterAtribute(new AttributeInformation(
                "dropzone",
                AttributeValueType.DropzoneSpaceDelimitedArray,
                isGlobal: true,
                supportedStatus: SupportedStatus.Experimental
            ));

            RegisterAtribute(new AttributeInformation(
                "enctype",
                AttributeValueType.Enumerated,
                validValues: new string[] { "application/x-www-form-urlencoded", "multipart/form-data", "text/plain" }
            ));

            // TODO: Id in <label>
            // TOOD: IdSpaceDelimitedArray in <output>
            RegisterAtribute(new AttributeInformation(
                "for",
                AttributeValueType.IdSpaceDelimitedArray
            ));

            RegisterAtribute(new AttributeInformation(
                "form",
                AttributeValueType.Id
            ));

            RegisterAtribute(new AttributeInformation(
                "formaction",
                AttributeValueType.NonEmptyUrl
            ));

            RegisterAtribute(new AttributeInformation(
                "formenctype",
                AttributeValueType.Enumerated,
                validValues: new string[] { "application/x-www-form-urlencoded", "multipart/form-data", "text/plain" }
            ));

            RegisterAtribute(new AttributeInformation(
                "formmethod",
                AttributeValueType.Enumerated,
                validValues: new string[] { "GET", "POST" }
            ));

            RegisterAtribute(new AttributeInformation(
                "formnovalidate",
                AttributeValueType.Boolean
            ));

            RegisterAtribute(new AttributeInformation(
                "formtarget",
                AttributeValueType.BrowsingContextNameOrKeyword
            ));

            RegisterAtribute(new AttributeInformation(
                "headers",
                AttributeValueType.IdSpaceDelimitedArray
            ));

            RegisterAtribute(new AttributeInformation(
                "height",
                AttributeValueType.NonNegativeInteger
            ));

            RegisterAtribute(new AttributeInformation(
                "hidden",
                AttributeValueType.Boolean
            ));

            // TODO: must be greater than high
            RegisterAtribute(new AttributeInformation(
                "high",
                AttributeValueType.FloatingPointNumber
            ));

            // TODO: Url in <a>,<area>,<base>
            // TODO: NonEmptyUrl in <link>
            RegisterAtribute(new AttributeInformation(
                "href",
                AttributeValueType.Url
            ));

            RegisterAtribute(new AttributeInformation(
                "hreflang",
                AttributeValueType.Bcp47LanguageTag
            ));

            // TODO: add
            RegisterAtribute(new AttributeInformation(
                "hspace",
                AttributeValueType.NonNegativeInteger,
                supportedStatus: SupportedStatus.Obsolete
            ));

            // TODO: content-language and set-cookie are non-conforming
            RegisterAtribute(new AttributeInformation(
                "http-equiv",
                AttributeValueType.Enumerated,
                validValues: new string[] { "content-language", "content-type", "default-style", "refresh", "set-cookie", "x-ua-compatible", "content-security-policy" }
            ));

            RegisterAtribute(new AttributeInformation(
                "icon",
                AttributeValueType.NonEmptyUrl
            ));

            RegisterAtribute(new AttributeInformation(
                "id",
                AttributeValueType.Id,
                isGlobal: true
            ));

            RegisterAtribute(new AttributeInformation(
                "inputmode",
                AttributeValueType.Enumerated,
                validValues: new string[] { "verbatim", "latin", "latin-name", "latin-prose", "full-width-latin", "kana", "kana-name", "katakana", "numeric", "tel", "email", "url" }
            ));

            // TODO: Subresource Integrity standard
            RegisterAtribute(new AttributeInformation(
                "integrity",
                AttributeValueType.Text
            ));

            RegisterAtribute(new AttributeInformation(
                "ismap",
                AttributeValueType.Boolean
            ));

            // TODO: add (WHATWG only)
            RegisterAtribute(new AttributeInformation(
                "itemid",
                AttributeValueType.Url,
                supportedStatus: SupportedStatus.Experimental,
                isGlobal: true
            ));

            RegisterAtribute(new AttributeInformation(
                "itemprop",
                AttributeValueType.UniqueSpaceSeparatedCaseSensitiveAbsoluteUrlsDefinedPropertyNamesOrTextSpaceDelimitedArray,
                supportedStatus: SupportedStatus.Experimental,
                isGlobal: true
            ));

            // TODO: unique
            RegisterAtribute(new AttributeInformation(
                "itemref",
                AttributeValueType.IdSpaceDelimitedArray,
                supportedStatus: SupportedStatus.Experimental,
                isGlobal: true
            ));

            RegisterAtribute(new AttributeInformation(
                "itemscope",
                AttributeValueType.Boolean,
                supportedStatus: SupportedStatus.Experimental,
                isGlobal: true
            ));

            // TODO: unique
            RegisterAtribute(new AttributeInformation(
                "itemtype",
                AttributeValueType.UniqueAbsoluteUrlSpaceDelimitedArray,
                supportedStatus: SupportedStatus.Experimental,
                isGlobal: true
            ));

            // TODO: WHATWG only
            RegisterAtribute(new AttributeInformation(
                "keytype",
                AttributeValueType.Enumerated,
                validValues: new string[] { "rsa", "dsa", "ec" },
                supportedStatus: SupportedStatus.Deprecated
            ));

            RegisterAtribute(new AttributeInformation(
                "kind",
                AttributeValueType.Enumerated,
                validValues: new string[] { "subtitles", "captions", "descriptions", "chapters", "metadata" }
            ));

            RegisterAtribute(new AttributeInformation(
                "label",
                AttributeValueType.Text
            ));

            RegisterAtribute(new AttributeInformation(
                "lang",
                AttributeValueType.Bcp47LanguageTagOrEmpty,
                isGlobal: true
            ));

            // TODO: add
            RegisterAtribute(new AttributeInformation(
                "language",
                AttributeValueType.Text,
                supportedStatus: SupportedStatus.Obsolete
            ));

            RegisterAtribute(new AttributeInformation(
                "list",
                AttributeValueType.Id
            ));

            // TODO: W3C only
            RegisterAtribute(new AttributeInformation(
                "longdesc",
                AttributeValueType.NonEmptyUrl
            ));

            RegisterAtribute(new AttributeInformation(
                "loop",
                AttributeValueType.Boolean
            ));

            RegisterAtribute(new AttributeInformation(
                "low",
                AttributeValueType.FloatingPointNumber
            ));

            // TODO: add (WHATWG only)
            RegisterAtribute(new AttributeInformation(
                "manifest",
                AttributeValueType.NonEmptyUrl
            ));

            // TODO: add
            RegisterAtribute(new AttributeInformation(
                "mayscript",
                AttributeValueType.Boolean,
                supportedStatus: SupportedStatus.Obsolete
            ));

            RegisterAtribute(new AttributeInformation(
                "max",
                AttributeValueType.FloatingPointNumber
            ));

            RegisterAtribute(new AttributeInformation(
                "maxlength",
                AttributeValueType.NonNegativeInteger
            ));

            RegisterAtribute(new AttributeInformation(
                "media",
                AttributeValueType.MediaQueryList
            ));

            // TODO: add
            RegisterAtribute(new AttributeInformation(
                "menu",
                AttributeValueType.Id
            ));

            // TODO: W3C: "get", "post", "dialog"
            // TODO: WHATWG: "GET", "POST", "dialog"
            RegisterAtribute(new AttributeInformation(
                "method",
                AttributeValueType.Enumerated,
                validValues: new string[] { "GET", "POST", "dialog" }
            ));

            RegisterAtribute(new AttributeInformation(
                "min",
                AttributeValueType.FloatingPointNumber
            ));

            RegisterAtribute(new AttributeInformation(
                "minlength",
                AttributeValueType.NonNegativeInteger
            ));

            RegisterAtribute(new AttributeInformation(
                "multiple",
                AttributeValueType.Boolean
            ));

            RegisterAtribute(new AttributeInformation(
                "muted",
                AttributeValueType.Boolean
            ));

            // TODO: not empty or "isindex" in <button>,<fieldset>,<input>,(<keygen> - WHATWG),<output>,<select>,<textarea>,<map>,<param>,(<slot> - WHATWG)
            // TODO: ValidBrowsingContextNameOrKeyword in <iframe>,<object>
            // TODO: unique non empty Text in <form>
            // TODO: extensible enumeration in <meta>: { "application-name", "author", "description", "generator", "keywords", "referrer", "theme-color" }
            RegisterAtribute(new AttributeInformation(
                "name",
                AttributeValueType.Text
            ));

            // TODO: add
            RegisterAtribute(new AttributeInformation(
                "nonce",
                AttributeValueType.Text
            ));

            RegisterAtribute(new AttributeInformation(
                "novalidate",
                AttributeValueType.Boolean
            ));

            RegisterAtribute(new AttributeInformation(
                "nowrap",
                AttributeValueType.Boolean,
                supportedStatus: SupportedStatus.Deprecated
            ));

            // TODO: add
            RegisterAtribute(new AttributeInformation(
                "object",
                AttributeValueType.NonEmptyUrl
            ));

            RegisterAtribute(new AttributeInformation(
                "open",
                AttributeValueType.Boolean
            ));

            // TODO minimum ≤ optimum ≤ maximum
            RegisterAtribute(new AttributeInformation(
                "optimum",
                AttributeValueType.FloatingPointNumber
            ));

            RegisterAtribute(new AttributeInformation(
                "pattern",
                AttributeValueType.RegularExpression
            ));

            // TODO: WHATWG only
            RegisterAtribute(new AttributeInformation(
                "ping",
                AttributeValueType.NonEmptyUrlSpaceDelimitedArray
            ));

            // TODO: Text not containing Line Feed or Carriage Return in <input>
            // TODO: Text in <textarea>
            RegisterAtribute(new AttributeInformation(
                "placeholder",
                AttributeValueType.Text
            ));

            // TODO: add (WHATWG only)
            RegisterAtribute(new AttributeInformation(
                "playsinline",
                AttributeValueType.Boolean
            ));

            // TODO: WHATWG only
            RegisterAtribute(new AttributeInformation(
                "poster",
                AttributeValueType.NonEmptyUrl
            ));

            RegisterAtribute(new AttributeInformation(
                "preload",
                AttributeValueType.Enumerated,
                validValues: new string[] { "none", "metadata", "auto" }
            ));

            RegisterAtribute(new AttributeInformation(
                "radiogroup",
                AttributeValueType.Text
            ));

            RegisterAtribute(new AttributeInformation(
                "readonly",
                AttributeValueType.Boolean
            ));

            // TODO: add (WHATWG only)
            RegisterAtribute(new AttributeInformation(
                "referrerpolicy",
                AttributeValueType.Enumerated,
                validValues: new string[] { "", "no-referrer", "no-referrer-when-downgrade", "same-origin", "origin", "strict-origin", "origin-when-cross-origin", "strict-origin-when-cross-origin", "unsafe-url" }
            ));

            RegisterAtribute(new AttributeInformation(
                "rel",
                AttributeValueType.SpaceDelimitedArray
            ));

            RegisterAtribute(new AttributeInformation(
                "required",
                AttributeValueType.Boolean
            ));

            // TODO: add (W3C only)
            RegisterAtribute(new AttributeInformation(
                "rev",
                AttributeValueType.SpaceDelimitedArray
            ));

            RegisterAtribute(new AttributeInformation(
                "reversed",
                AttributeValueType.Boolean
            ));

            RegisterAtribute(new AttributeInformation(
                "rows",
                AttributeValueType.PositiveInteger
            ));

            RegisterAtribute(new AttributeInformation(
                "rowspan",
                AttributeValueType.NonNegativeInteger
            ));

            // TODO: W3C: "allow-forms", "allow-pointer-lock", "allow-popups", "allow-same-origin", "allow-scripts and "allow-top-navigation"
            // TODO: WHATWG:  "allow-forms", "allow-modals", "allow-orientation-lock", "allow-pointer-lock", "allow-popups", "allow-popups-to-escape-sandbox", "allow-presentation", "allow-same-origin", "allow-scripts, "allow-top-navigation"
            RegisterAtribute(new AttributeInformation(
                "sandbox",
                AttributeValueType.EnumeratedCaseInsensitiveSpaceDelimitedArray,
                validValues: new string[] { "allow-forms", "allow-modals", "allow-orientation-lock", "allow-pointer-lock", "allow-popups", "allow-popups-to-escape-sandbox", "allow-presentation", "allow-same-origin", "allow-scripts", "allow-top-navigation" }
            ));

            RegisterAtribute(new AttributeInformation(
                "spellcheck",
                AttributeValueType.Enumerated,
                validValues: new string[] { "true", "false" },
                supportedStatus: SupportedStatus.Experimental
            ));

            RegisterAtribute(new AttributeInformation(
                "scope",
                AttributeValueType.Enumerated,
                validValues: new string[] { "row", "col", "rowgroup", "colgroup" }
            ));

            RegisterAtribute(new AttributeInformation(
                "scoped",
                AttributeValueType.NonNegativeInteger,
                supportedStatus: SupportedStatus.Dropped
            ));

            RegisterAtribute(new AttributeInformation(
                "seamless",
                AttributeValueType.Boolean,
                supportedStatus: SupportedStatus.Dropped
            ));

            RegisterAtribute(new AttributeInformation(
                "selected",
                AttributeValueType.Boolean
            ));

            // TODO: non-conforming: "circ", "polygon", "rectangle"
            RegisterAtribute(new AttributeInformation(
                "shape",
                AttributeValueType.Enumerated,
                validValues: new string[] { "circle", "circ", "default", "poly", "polygon", "rect", "rectangle" }
            ));

            RegisterAtribute(new AttributeInformation(
                "size",
                AttributeValueType.PositiveInteger
            ));

            RegisterAtribute(new AttributeInformation(
                "sizes",
                AttributeValueType.SizeCaseInsensitiveSpaceDelimitedArray
            ));

            RegisterAtribute(new AttributeInformation(
                "span",
                AttributeValueType.PositiveInteger
            ));

            RegisterAtribute(new AttributeInformation(
                "src",
                AttributeValueType.NonEmptyUrl
            ));

            RegisterAtribute(new AttributeInformation(
                "srcdoc",
                AttributeValueType.Html
            ));

            RegisterAtribute(new AttributeInformation(
                "srclang",
                AttributeValueType.Bcp47LanguageTag
            ));

            RegisterAtribute(new AttributeInformation(
                "srcset",
                AttributeValueType.ImageCandidateCommaDelimitedArray
            ));

            RegisterAtribute(new AttributeInformation(
                "start",
                AttributeValueType.Integer
            ));

            RegisterAtribute(new AttributeInformation(
                "step",
                AttributeValueType.PositiveFloatingPointNumberOrAny
            ));

            RegisterAtribute(new AttributeInformation(
                "style",
                AttributeValueType.CssDeclarations,
                isGlobal: true
            ));

            RegisterAtribute(new AttributeInformation(
                "tabindex",
                AttributeValueType.Integer
            ));

            RegisterAtribute(new AttributeInformation(
                "target",
                AttributeValueType.BrowsingContextNameOrKeyword
            ));

            RegisterAtribute(new AttributeInformation(
                "text",
                AttributeValueType.Color,
                supportedStatus: SupportedStatus.Deprecated
            ));

            RegisterAtribute(new AttributeInformation(
                "title",
                AttributeValueType.Text,
                isGlobal: true
            ));

            RegisterAtribute(new AttributeInformation(
                "translate",
                AttributeValueType.Enumerated,
                validValues: new string[] { "yes", "no" }
            ));

            // TODO: parent model
            // TODO: MimeType for <a>,<link>,(<area> - W3C),<embed>,<object>,<script>,<source>,<style>
            // TODO: { "context", "toolbar" } for <menu>
            // TODO: { "command", "checkbox", "radio" } for <menuitem>
            // TODO: { "1", "a", "A", "i", "I" } for <ol>
            // TODO: { "hidden", "text", "search", "tel", "url", "email", "password", "date", "month", "week", "time", "datetime-local", "number", "range", "color", "checkbox", "radio", "file", "submit", "image", "reset", "button" }
            RegisterAtribute(new AttributeInformation(
                "type",
                AttributeValueType.ContextSensitive
            ));

            RegisterAtribute(new AttributeInformation(
                "typemustmatch",
                AttributeValueType.Boolean
            ));

            RegisterAtribute(new AttributeInformation(
                "usemap",
                AttributeValueType.HashNameReference
            ));

            // TODO: parent model
            // TODO: Text for <button>,<option>,<data>,<param>
            // TODO: FloatingPointNumber for <meter>,<progress>
            // TODO: Integer for <li>
            // TODO: Varies for <input>
            RegisterAtribute(new AttributeInformation(
                "value",
                AttributeValueType.ContextSensitive
            ));

            // TODO: add
            RegisterAtribute(new AttributeInformation(
                "vspace",
                AttributeValueType.NonNegativeInteger,
                supportedStatus: SupportedStatus.Obsolete
            ));

            RegisterAtribute(new AttributeInformation(
                "width",
                AttributeValueType.NonNegativeInteger
            ));

            RegisterAtribute(new AttributeInformation(
                "wrap",
                AttributeValueType.Enumerated,
                validValues: new string[] { "soft", "hard" }
            ));

            RegisterAtribute(new AttributeInformation(
                "xmls",
                AttributeValueType.NonEmptyUrl
            ));

            RegisterAtribute(new AttributeInformation(
                "xml:lang",
                AttributeValueType.Text,
                isGlobal: true
            ));
        }

        private static void RegisterAtribute(AttributeInformation attributeInformation)
        {
            s_attributeInformation.Add(attributeInformation.Tag, attributeInformation);
        }
    }
}
