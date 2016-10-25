using System.Collections.Generic;

namespace HtmlGenerator.SemanticAnalysis
{
    public static partial class Sema
    {
        public static ElementInformation GetElementInformation(string tag)
        {
            Requires.NotNullOrWhitespace(tag, nameof(tag));
            ElementInformation value;
            ElementInformationDictionary.TryGetValue(tag, out value);
            return value;
        }

        private static Dictionary<string, ElementInformation> s_elementInformation;
        private static Dictionary<string, ElementInformation> ElementInformationDictionary
        {
            get
            {
                if (s_elementInformation == null)
                {
                    s_elementInformation = new Dictionary<string, ElementInformation>();
                    InitializeElementInformation();
                }
                return s_elementInformation;
            }
        }

        private static void RegisterElement(ElementInformation elementInformation)
        {
            s_elementInformation.Add(elementInformation.Tag, elementInformation);
        }

        private static void InitializeElementInformation()
        {
            // 4.5.1 The a element
            RegisterElement(new ElementInformation(
                tag: "a",
                category: ElementCategory.Flow | ElementCategory.Phrasing | ElementCategory.Interactive | ElementCategory.Palpable,
                parentCategory: ElementCategory.Phrasing,
                childrenCategory: ElementCategory.Phrasing,
                requiredAttributes: new string[] { "href" },
                attributes: new string[] { "href", "target", "download", "rel", "rev", "hreflang", "type" },
                ariaRoleAttributes: new string[] { "link", "button", "checkbox", "menuitem", "menuitemcheckbox", "menuitemradio", "radio", "switch", "tab", "treeitem" }
            ));

            // 4.5.9 The abbr element
            RegisterElement(new ElementInformation(
                tag: "abbr",
                category: ElementCategory.Flow | ElementCategory.Phrasing | ElementCategory.Palpable,
                parentCategory: ElementCategory.Phrasing,
                childrenCategory: ElementCategory.Phrasing
            ));

            // 4.3.10 The address element
            RegisterElement(new ElementInformation(
                tag: "address",
                category: ElementCategory.Flow | ElementCategory.Palpable,
                parentCategory: ElementCategory.Flow,
                childrenCategory: ElementCategory.Flow
            ));

            // 4.8.14 The area element
            RegisterElement(new ElementInformation(
                tag: "area",
                category: ElementCategory.Flow | ElementCategory.Palpable,
                parentCategory: ElementCategory.Flow,
                childrenCategory: ElementCategory.Flow,
                attributes: new string[] { "alt", "coords", "shape", "href", "target", "download", "ping", "rel", "referrerpolicy" }
            ));

            // 4.3.2 The article element
            RegisterElement(new ElementInformation(
                tag: "article",
                category: ElementCategory.Flow | ElementCategory.Sectioning | ElementCategory.Palpable,
                parentCategory: ElementCategory.Flow,
                childrenCategory: ElementCategory.Flow
            ));

            // TODO: add
            // 4.3.5 The aside element
            RegisterElement(new ElementInformation(
                tag: "aside",
                category: ElementCategory.Flow | ElementCategory.Sectioning | ElementCategory.Palpable,
                parentCategory: ElementCategory.Flow,
                childrenCategory: ElementCategory.Flow
            ));

            // 4.8.10 The audio element
            RegisterElement(new ElementInformation(
                tag: "audio",
                category: ElementCategory.Flow | ElementCategory.Phrasing | ElementCategory.Embedded | ElementCategory.Interactive | ElementCategory.Palpable,
                parentCategory: ElementCategory.Phrasing,
                childrenCategory: ElementCategory.Flow
            ));

            // 4.5.21 The b element
            RegisterElement(new ElementInformation(
                tag: "b",
                category: ElementCategory.Flow | ElementCategory.Phrasing | ElementCategory.Palpable,
                parentCategory: ElementCategory.Phrasing,
                childrenCategory: ElementCategory.Flow
            ));

            // 4.2.3 The base element
            RegisterElement(new ElementInformation(
                tag: "base",
                category: ElementCategory.Metadata,
                parentCategory: ElementCategory.Flow, // TODO: Head
                childrenCategory: ElementCategory.None,
                attributes: new string[] { "href", "target" }
            ));

            // 4.5.24 The bdi element
            RegisterElement(new ElementInformation(
                tag: "bdi",
                category: ElementCategory.Flow | ElementCategory.Phrasing | ElementCategory.Palpable,
                parentCategory: ElementCategory.Phrasing,
                childrenCategory: ElementCategory.Phrasing
            ));

            // TODO: add
            // 4.5.25 The bdo element
            RegisterElement(new ElementInformation(
                tag: "bdo",
                category: ElementCategory.Flow | ElementCategory.Phrasing | ElementCategory.Palpable,
                parentCategory: ElementCategory.Phrasing,
                childrenCategory: ElementCategory.Phrasing
            ));

            // TODO: add
            // 4.4.4 The blockquote element
            RegisterElement(new ElementInformation(
                tag: "blockquote",
                category: ElementCategory.Flow | ElementCategory.SectioningRoot | ElementCategory.Palpable,
                parentCategory: ElementCategory.Flow,
                childrenCategory: ElementCategory.Flow,
                attributes: new string[] { "cite" }
            ));

            // 4.3.1 The body element
            RegisterElement(new ElementInformation(
                tag: "body",
                category: ElementCategory.SectioningRoot,
                parentCategory: ElementCategory.Phrasing, // TODO: html
                childrenCategory: ElementCategory.Flow,
                attributes: new string[] { "onafterprint", "onbeforeprint", "onebeforeunload", "onhashchange", "onlanguagechange", "onmessage", "onoffline", "ononline", "onpagehide", "onpageshow", "onpopstate", "onrejectionhandled", "onstorage", "onunhandledrejection", "onunload" }
            ));

            // 4.5.27 The br element
            RegisterElement(new ElementInformation(
                tag: "br",
                category: ElementCategory.Flow | ElementCategory.Phrasing,
                parentCategory: ElementCategory.Phrasing,
                childrenCategory: ElementCategory.None,
                attributes: new string[] { "clear" },
                isVoid: true
            ));

            // 4.10.6 The button element
            RegisterElement(new ElementInformation(
                tag: "button",
                category: ElementCategory.Flow | ElementCategory.Phrasing | ElementCategory.Interactive | ElementCategory.Listed | ElementCategory.Labelable | ElementCategory.Submittable | ElementCategory.FormAssociated | ElementCategory.Palpable,
                parentCategory: ElementCategory.Phrasing,
                childrenCategory: ElementCategory.Phrasing,
                attributes: new string[] { "autofocus", "disabled", "form", "formaction", "formenctype", "formmethod", "formnovalidate", "formtarget", "menu", "name", "type", "value" }
            ));

            // 4.12.5 The canvas element
            RegisterElement(new ElementInformation(
                tag: "canvas",
                category: ElementCategory.Flow | ElementCategory.Phrasing | ElementCategory.Embedded | ElementCategory.Palpable,
                parentCategory: ElementCategory.Phrasing,
                childrenCategory: ElementCategory.Flow,
                attributes: new string[] { "width", "height" }
            ));

            // 4.9.2 The caption element
            RegisterElement(new ElementInformation(
                tag: "caption",
                category: ElementCategory.None,
                parentCategory: ElementCategory.Phrasing, // TODO: table
                childrenCategory: ElementCategory.Flow
            ));

            // 4.5.6 The cite element
            RegisterElement(new ElementInformation(
                tag: "cite",
                category: ElementCategory.Flow | ElementCategory.Phrasing | ElementCategory.Palpable,
                parentCategory: ElementCategory.Phrasing,
                childrenCategory: ElementCategory.Phrasing
            ));

            // 4.5.15 The code element
            RegisterElement(new ElementInformation(
                tag: "code",
                category: ElementCategory.Flow | ElementCategory.Phrasing | ElementCategory.Palpable,
                parentCategory: ElementCategory.Phrasing,
                childrenCategory: ElementCategory.Phrasing
            ));

            // 4.9.4 The col element
            RegisterElement(new ElementInformation(
                tag: "col",
                category: ElementCategory.None,
                parentCategory: ElementCategory.Phrasing, // TODO: colgroup
                childrenCategory: ElementCategory.None,
                attributes: new string[] { "span" },
                isVoid: true
            ));

            // 4.9.3 The colgroup element
            RegisterElement(new ElementInformation(
                tag: "colgroup",
                category: ElementCategory.None,
                parentCategory: ElementCategory.Phrasing, // TODO: table
                childrenCategory: ElementCategory.Phrasing, // TODO: col, template
                attributes: new string[] { "span" }
            ));

            // 4.5.13 The data element
            RegisterElement(new ElementInformation(
                tag: "data",
                category: ElementCategory.Flow | ElementCategory.Phrasing | ElementCategory.Palpable,
                parentCategory: ElementCategory.Phrasing,
                childrenCategory: ElementCategory.Phrasing,
                attributes: new string[] { "value" }
            ));

            // 4.10.8 The datalist element
            RegisterElement(new ElementInformation(
                tag: "datalist",
                category: ElementCategory.Flow | ElementCategory.Phrasing,
                parentCategory: ElementCategory.Phrasing,
                childrenCategory: ElementCategory.Phrasing | ElementCategory.ScriptSupporting // TODO: option
            ));

            // 4.4.10 The dd element
            RegisterElement(new ElementInformation(
                tag: "dd",
                category: ElementCategory.None,
                parentCategory: ElementCategory.Phrasing, // TODO: dl, div
                childrenCategory: ElementCategory.Flow
            ));

            // 4.7.2 The del element
            RegisterElement(new ElementInformation(
                tag: "del",
                category: ElementCategory.Flow | ElementCategory.Phrasing,
                parentCategory: ElementCategory.Phrasing,
                childrenCategory: ElementCategory.Flow,
                attributes: new string[] { "cite", "datetime" }
            ));

            // 4.11.1 The details element
            RegisterElement(new ElementInformation(
                tag: "details",
                category: ElementCategory.Flow | ElementCategory.SectioningRoot | ElementCategory.Interactive | ElementCategory.Palpable,
                parentCategory: ElementCategory.Flow,
                childrenCategory: ElementCategory.Flow, // TODO: summary
                attributes: new string[] { "open" }
            ));

            // 4.5.8 The dfn element
            RegisterElement(new ElementInformation(
                tag: "dfn",
                category: ElementCategory.Flow | ElementCategory.Phrasing | ElementCategory.Palpable,
                parentCategory: ElementCategory.Phrasing,
                childrenCategory: ElementCategory.Phrasing
            ));

            // 4.11.7 The dialog element
            RegisterElement(new ElementInformation(
                tag: "dialog",
                category: ElementCategory.Flow | ElementCategory.SectioningRoot,
                parentCategory: ElementCategory.Flow,
                childrenCategory: ElementCategory.Flow,
                attributes: new string[] { "open" }
            ));

            // 4.4.14 The div element
            RegisterElement(new ElementInformation(
                tag: "div",
                category: ElementCategory.Flow | ElementCategory.Palpable,
                parentCategory: ElementCategory.Flow, // TODO: dl
                childrenCategory: ElementCategory.Flow
            ));

            // 4.4.8 The dl element
            RegisterElement(new ElementInformation(
                tag: "dl",
                category: ElementCategory.Flow | ElementCategory.Palpable,
                parentCategory: ElementCategory.Flow,
                childrenCategory: ElementCategory.ScriptSupporting // TODO: dt, dd, div
            ));

            // 4.4.9 The dt element
            RegisterElement(new ElementInformation(
                tag: "dt",
                category: ElementCategory.None,
                parentCategory: ElementCategory.Flow, // TODO: div, dl
                childrenCategory: ElementCategory.Flow
            ));

            // 4.5.2 The em element
            RegisterElement(new ElementInformation(
                tag: "em",
                category: ElementCategory.Flow | ElementCategory.Phrasing | ElementCategory.Palpable,
                parentCategory: ElementCategory.Phrasing,
                childrenCategory: ElementCategory.Phrasing
            ));

            // 4.8.6 The embed element
            RegisterElement(new ElementInformation(
                tag: "embed",
                category: ElementCategory.Flow | ElementCategory.Phrasing | ElementCategory.Embedded | ElementCategory.Interactive | ElementCategory.Palpable,
                parentCategory: ElementCategory.Phrasing,
                childrenCategory: ElementCategory.None,
                attributes: new string[] { "src", "type", "width", "height" },
                isVoid: true
            ));

            // 4.10.16 The fieldset element
            RegisterElement(new ElementInformation(
                tag: "fieldset",
                category: ElementCategory.Flow | ElementCategory.SectioningRoot | ElementCategory.Listed | ElementCategory.FormAssociated | ElementCategory.Palpable,
                parentCategory: ElementCategory.Flow,
                childrenCategory: ElementCategory.Phrasing, // TODO: legend
                attributes: new string[] { "disabled", "form", "name" }
            ));

            // 4.4.12 The figcaption element
            RegisterElement(new ElementInformation(
                tag: "figcaption",
                category: ElementCategory.None,
                parentCategory: ElementCategory.Phrasing, // TODO: figure
                childrenCategory: ElementCategory.Flow
            ));

            // 4.4.11 The figure element
            RegisterElement(new ElementInformation(
                tag: "figure",
                category: ElementCategory.Flow | ElementCategory.SectioningRoot | ElementCategory.Palpable,
                parentCategory: ElementCategory.Flow,
                childrenCategory: ElementCategory.Flow // TODO: flow, figcaption followed by flow, flow followed by figcaption
            ));

            // 4.3.9 The footer element
            RegisterElement(new ElementInformation(
                tag: "footer",
                category: ElementCategory.Flow | ElementCategory.Palpable,
                parentCategory: ElementCategory.Flow,
                childrenCategory: ElementCategory.Flow // TODO: can't have header, footer, main
            ));

            // 4.10.3 The form element
            RegisterElement(new ElementInformation(
                tag: "form",
                category: ElementCategory.Flow | ElementCategory.Palpable,
                parentCategory: ElementCategory.Flow,
                childrenCategory: ElementCategory.Flow, // TODO: can't have form,
                attributes: new string[] { "accept-charset", "action", "autocomplete", "enctype", "method", "name", "novalidate", "target" }
            ));

            // 4.3.6 The h1, h2, h3, h4, h5, and h6 elements
            RegisterElement(new ElementInformation(
                tag: "h1",
                category: ElementCategory.Flow | ElementCategory.Heading | ElementCategory.Palpable,
                parentCategory: ElementCategory.Flow, // TODO: also hgroup
                childrenCategory: ElementCategory.Phrasing
            ));

            // 4.3.6 The h1, h2, h3, h4, h5, and h6 elements
            RegisterElement(new ElementInformation(
                tag: "h2",
                category: ElementCategory.Flow | ElementCategory.Heading | ElementCategory.Palpable,
                parentCategory: ElementCategory.Flow, // TODO: also hgroup
                childrenCategory: ElementCategory.Phrasing
            ));

            // 4.3.6 The h1, h2, h3, h4, h5, and h6 elements
            RegisterElement(new ElementInformation(
                tag: "h3",
                category: ElementCategory.Flow | ElementCategory.Heading | ElementCategory.Palpable,
                parentCategory: ElementCategory.Flow, // TODO: also hgroup
                childrenCategory: ElementCategory.Phrasing
            ));

            // 4.3.6 The h1, h2, h3, h4, h5, and h6 elements
            RegisterElement(new ElementInformation(
                tag: "h4",
                category: ElementCategory.Flow | ElementCategory.Heading | ElementCategory.Palpable,
                parentCategory: ElementCategory.Flow, // TODO: also hgroup
                childrenCategory: ElementCategory.Phrasing
            ));

            // 4.3.6 The h1, h2, h3, h4, h5, and h6 elements
            RegisterElement(new ElementInformation(
                tag: "h5",
                category: ElementCategory.Flow | ElementCategory.Heading | ElementCategory.Palpable,
                parentCategory: ElementCategory.Flow, // TODO: also hgroup
                childrenCategory: ElementCategory.Phrasing
            ));

            // 4.3.6 The h1, h2, h3, h4, h5, and h6 elements
            RegisterElement(new ElementInformation(
                tag: "h6",
                category: ElementCategory.Flow | ElementCategory.Heading | ElementCategory.Palpable,
                parentCategory: ElementCategory.Flow, // TODO: also hgroup
                childrenCategory: ElementCategory.Phrasing
            ));

            // 4.2.1 The head element
            // TODO: omit if empty, or has an element
            RegisterElement(new ElementInformation(
                tag: "head",
                category: ElementCategory.None,
                parentCategory: ElementCategory.Flow, // TODO: only first child of html
                childrenCategory: ElementCategory.Metadata // TODO: one or more, only one title, only one base
            ));

            // 4.3.8 The header element
            RegisterElement(new ElementInformation(
                tag: "header",
                category: ElementCategory.Flow | ElementCategory.Palpable,
                parentCategory: ElementCategory.Flow,
                childrenCategory: ElementCategory.Flow // TODO: can't be header, footer or main
            ));

            // 4.3.7 The hgroup element
            // TODO: add
            RegisterElement(new ElementInformation(
                tag: "hgroup",
                category: ElementCategory.Flow | ElementCategory.Heading | ElementCategory.Palpable,
                parentCategory: ElementCategory.Flow,
                childrenCategory: ElementCategory.Flow // TODO: at least one h1, h2, h3, h4, h5, h6, template
            ));

            // 4.4.2 The hr element
            RegisterElement(new ElementInformation(
                tag: "hr",
                category: ElementCategory.Flow,
                parentCategory: ElementCategory.Flow,
                childrenCategory: ElementCategory.Flow,
                isVoid: true
            ));

            // 4.3.8 The html element
            // TODO: start omitted if first thing is not a comment
            // TODO: end omitted if last thing is not a comment
            RegisterElement(new ElementInformation(
                tag: "html",
                category: ElementCategory.None,
                parentCategory: ElementCategory.None, // First element
                childrenCategory: ElementCategory.Flow, // TODO: must be head or body
                attributes: new string[] { "manifest" }
            ));

            // 4.5.20 The i element
            RegisterElement(new ElementInformation(
                tag: "i",
                category: ElementCategory.Flow | ElementCategory.Phrasing | ElementCategory.Palpable,
                parentCategory: ElementCategory.Phrasing,
                childrenCategory: ElementCategory.Phrasing
            ));

            // 4.8.5 The iframe element
            RegisterElement(new ElementInformation(
                tag: "iframe",
                category: ElementCategory.Flow | ElementCategory.Phrasing | ElementCategory.Embedded | ElementCategory.Interactive | ElementCategory.Palpable,
                parentCategory: ElementCategory.Embedded,
                childrenCategory: ElementCategory.Phrasing, // TODO: no script elements
                attributes: new string[] { "src", "srcdoc", "name", "sanbox", "allowfullscreen", "allowusermedia", "width", "height", "referrerpolicy" }
            ));

            // 4.8.3 The img element
            RegisterElement(new ElementInformation(
                tag: "img",
                category: ElementCategory.Flow | ElementCategory.Phrasing | ElementCategory.Embedded | ElementCategory.FormAssociated | ElementCategory.Interactive | ElementCategory.Palpable, // TODO: Interactive if has usemap
                parentCategory: ElementCategory.Embedded,
                childrenCategory: ElementCategory.None,
                attributes: new string[] { "alt", "src", "srcset", "crossorigin", "usemap", "ismap", "width", "height", "referrerpolicy" },
                requiredAttributes: new string[] { "alt", "src" },
                isVoid: true
            ));

            // 4.7.1 The ins element
            RegisterElement(new ElementInformation(
                tag: "ins",
                category: ElementCategory.Flow | ElementCategory.Phrasing | ElementCategory.Palpable,
                parentCategory: ElementCategory.Phrasing,
                childrenCategory: ElementCategory.Flow, // TODO: transparent
                attributes: new string[] { "cite", "datetime" }
            ));

            // 4.5.18 The kbd element
            RegisterElement(new ElementInformation(
                tag: "kbd",
                category: ElementCategory.Flow | ElementCategory.Phrasing | ElementCategory.Palpable,
                parentCategory: ElementCategory.Phrasing,
                childrenCategory: ElementCategory.Phrasing
            ));

            // 4.10.12 The keygen element
            // TODO: add (WHATWG only)
            RegisterElement(new ElementInformation(
                tag: "keygen",
                category: ElementCategory.Flow | ElementCategory.Phrasing | ElementCategory.Interactive | ElementCategory.FormAssociated | ElementCategory.Palpable,
                parentCategory: ElementCategory.Phrasing,
                childrenCategory: ElementCategory.None,
                supportedStatus: SupportedStatus.Deprecated,
                attributes: new string[] { "autofocus", "challenge", "disabled", "form", "keytype", "name" },
                isVoid: true
            ));

            // 4.10.4 The label element
            RegisterElement(new ElementInformation(
                tag: "label",
                category: ElementCategory.Flow | ElementCategory.Phrasing | ElementCategory.Interactive | ElementCategory.Palpable,
                parentCategory: ElementCategory.Phrasing,
                childrenCategory: ElementCategory.Phrasing, // TODO: can't have label elements,
                attributes: new string[] { "for" }
            ));

            // 4.10.17 The legend element
            RegisterElement(new ElementInformation(
                tag: "legend",
                category: ElementCategory.None,
                parentCategory: ElementCategory.Phrasing, // TODO: fieldset only
                childrenCategory: ElementCategory.Phrasing
            ));

            // 4.4.7 The li element
            RegisterElement(new ElementInformation(
                tag: "li",
                category: ElementCategory.None,
                parentCategory: ElementCategory.Phrasing, // TODO: ol, li, menu only
                childrenCategory: ElementCategory.Flow,
                attributes: new string[] { "value" }
            ));

            // 4.2.4 The link element
            RegisterElement(new ElementInformation(
                tag: "link",
                category: ElementCategory.Metadata | ElementCategory.Phrasing, // TODO: if has itemprop, or rel with body-ok keywords
                parentCategory: ElementCategory.Phrasing, // TODO: ol, li, menu only
                childrenCategory: ElementCategory.Flow,
                attributes: new string[] { "href", "crossorigin", "rel", "as", "media", "hreflang", "type", "sizes", "referrerpolicy", "nonce", "integrity" }
            ));

            // 4.4.13 The main element
            RegisterElement(new ElementInformation(
                tag: "main",
                category: ElementCategory.Flow | ElementCategory.Palpable,
                parentCategory: ElementCategory.Flow,
                childrenCategory: ElementCategory.Flow
            ));

            // 4.8.13 The map element
            RegisterElement(new ElementInformation(
                tag: "map",
                category: ElementCategory.Flow | ElementCategory.Phrasing | ElementCategory.Palpable,
                parentCategory: ElementCategory.Phrasing,
                childrenCategory: ElementCategory.Phrasing, // TODO: transparent
                attributes: new string[] { "name" }
            ));

            // 4.5.23 The mark element
            RegisterElement(new ElementInformation(
                tag: "mark",
                category: ElementCategory.Flow | ElementCategory.Phrasing | ElementCategory.Palpable,
                parentCategory: ElementCategory.Phrasing,
                childrenCategory: ElementCategory.Phrasing
            ));

            // 2.2 The Top-Level <math> Element (MathML)
            // TODO: add
            RegisterElement(new ElementInformation(
                tag: "math",
                category: ElementCategory.Flow | ElementCategory.Phrasing | ElementCategory.Embedded | ElementCategory.Palpable,
                parentCategory: ElementCategory.Phrasing,
                childrenCategory: ElementCategory.Flow // TODO: according to MathML
            ));

            // 4.11.3 The menu element
            RegisterElement(new ElementInformation(
                tag: "menu",
                category: ElementCategory.Flow | ElementCategory.Palpable, // TODO: Palpable if in the toolbar state
                parentCategory: ElementCategory.Flow, // TODO: menu if child of popup menu type and is also popup menu
                                                      // TODO: if type is toolbar, zero or more li elements, script supporting elements and flow elements
                                                      // TODO: if type is popup menu, zero or more menuitem elements, hr elements, script supporting elements and popup menu elements
                childrenCategory: ElementCategory.Flow,
                attributes: new string[] { "type", "label" }
            ));

            // 4.11.4 The menuitem element
            RegisterElement(new ElementInformation(
                tag: "menuitem",
                category: ElementCategory.None,
                parentCategory: ElementCategory.Phrasing, // TODO: only menu in popup menu state
                childrenCategory: ElementCategory.Text,
                attributes: new string[] { "type", "label", "icon", "disabled", "checked", "radiogroup", "default" }
            ));

            // 4.2.5 The meta element
            RegisterElement(new ElementInformation(
                tag: "meta",
                category: ElementCategory.Metadata, // TODO: Flow and Phrasing if has itemprop attribute
                                                    // TODO: If the charset attribute is present, or if the element's http-equiv attribute is in the Encoding declaration state: in a head element.
                                                    // TODO: If the http-equiv attribute is present but not in the Encoding declaration state: in a head element.
                                                    // TODO: If the http-equiv attribute is present but not in the Encoding declaration state: in a noscript element that is a child of a head element.
                                                    // TODO: If the name attribute is present: where metadata content is expected.
                                                    // TODO: If the itemprop attribute is present: where metadata content is expected.
                                                    // TODO: If the itemprop attribute is present: where phrasing content is expected.
                parentCategory: ElementCategory.Phrasing,
                childrenCategory: ElementCategory.None,
                attributes: new string[] { "name", "http-equiv", "content", "charset" },
                isVoid: true
            ));

            // 4.10.15 The meter element
            RegisterElement(new ElementInformation(
                tag: "meter",
                category: ElementCategory.Flow | ElementCategory.Phrasing | ElementCategory.Labelable | ElementCategory.Palpable,
                parentCategory: ElementCategory.Phrasing,
                childrenCategory: ElementCategory.Phrasing, // TODO: can't have meter
                attributes: new string[] { "value", "min", "max", "low", "high", "optimum" }
            ));

            // 4.3.4 The nav element
            RegisterElement(new ElementInformation(
                tag: "nav",
                category: ElementCategory.Flow | ElementCategory.Sectioning | ElementCategory.Palpable,
                parentCategory: ElementCategory.Flow,
                childrenCategory: ElementCategory.Flow // TODO: can't have main
            ));

            // 4.12.2 The noscript element
            RegisterElement(new ElementInformation(
                tag: "noscript",
                category: ElementCategory.Metadata | ElementCategory.Flow | ElementCategory.Palpable,
                parentCategory: ElementCategory.Flow, // TODO: head or Phrasing if has no noscript ancestors
                childrenCategory: ElementCategory.Flow // TODO: zero or more link, style and meta elements
            ));

            // 4.8.7 The object element
            RegisterElement(new ElementInformation(
                tag: "object",
                category: ElementCategory.Flow | ElementCategory.Phrasing | ElementCategory.Embedded | ElementCategory.Interactive | ElementCategory.FormAssociated | ElementCategory.Listed | ElementCategory.Submittable | ElementCategory.Palpable, // TODO: Interactive only if usemap
                parentCategory: ElementCategory.Embedded,
                childrenCategory: ElementCategory.Flow, // TODO: param only
                attributes: new string[] { "data", "type", "typemustmatch", "name", "usemap", "form", "width", "height" }
            ));

            // 4.4.5 The ol element
            RegisterElement(new ElementInformation(
                tag: "ol",
                category: ElementCategory.Flow | ElementCategory.Palpable, // TODO: palpable only if one or more li
                parentCategory: ElementCategory.Flow,
                childrenCategory: ElementCategory.ScriptSupporting, // TODO: also li
                attributes: new string[] { "reversed", "start", "type" }
            ));

            // 4.10.9 The optgroup element
            // TODO: An optgroup element's end tag can be omitted if the optgroup element is immediately followed by another optgroup element, or if there is no more content in the parent element.
            RegisterElement(new ElementInformation(
                tag: "optgroup",
                category: ElementCategory.None,
                parentCategory: ElementCategory.Flow, // TODO: only select
                childrenCategory: ElementCategory.ScriptSupporting, // TODO: also option
                attributes: new string[] { "disabled", "label" }
            ));

            // 4.10.10 The option element
            // TODO: An option element's end tag can be omitted if the option element is immediately followed by another option element, or if it is immediately followed by an optgroup element, or if there is no more content in the parent element.
            RegisterElement(new ElementInformation(
                tag: "option",
                category: ElementCategory.None,
                parentCategory: ElementCategory.Flow, // TODO: only select, datalist and optgroup
                childrenCategory: ElementCategory.Text, // TODO: also None if has label but no value
                attributes: new string[] { "disabled", "label", "selected", "value" }
            ));

            // 4.10.13 The output element
            RegisterElement(new ElementInformation(
                tag: "output",
                category: ElementCategory.Flow | ElementCategory.Phrasing | ElementCategory.Phrasing | ElementCategory.Listed | ElementCategory.Labelable | ElementCategory.Resettable | ElementCategory.FormAssociated | ElementCategory.Palpable,
                parentCategory: ElementCategory.Phrasing,
                childrenCategory: ElementCategory.Phrasing,
                attributes: new string[] { "form", "form", "name" }
            ));

            // 4.4.1 The p element
            // TODO: A p element's end tag can be omitted if the p element is immediately followed by an address, article, aside, blockquote, details, div, dl, fieldset, figcaption, figure, footer, form, h1, h2, h3, h4, h5, h6, header, hgroup, hr, main, menu, nav, ol, p, pre, section, table, or ul element, or if there is no more content in the parent element and the parent element is an HTML element that is not an a, audio, del, ins, map, noscript, or video element, or an autonomous custom element.
            RegisterElement(new ElementInformation(
                tag: "p",
                category: ElementCategory.Flow | ElementCategory.Palpable,
                parentCategory: ElementCategory.Flow,
                childrenCategory: ElementCategory.Phrasing
            ));

            // 4.8.8 The param element
            RegisterElement(new ElementInformation(
                tag: "param",
                category: ElementCategory.Flow | ElementCategory.Palpable,
                parentCategory: ElementCategory.Flow, // TODO: child of any object element, before any flow content
                childrenCategory: ElementCategory.None,
                attributes: new string[] { "name", "value" },
                isVoid: true
            ));

            // 4.8.1 The picture element
            // TODO: add
            RegisterElement(new ElementInformation(
                tag: "picture",
                category: ElementCategory.Flow | ElementCategory.Phrasing | ElementCategory.Palpable,
                parentCategory: ElementCategory.Embedded,
                childrenCategory: ElementCategory.None // TODO: zero or more source elements, followed by one img element, optionally intermixed with script-supporting elements
            ));

            // 4.4.3 The pre element
            RegisterElement(new ElementInformation(
                tag: "pre",
                category: ElementCategory.Flow | ElementCategory.Palpable,
                parentCategory: ElementCategory.Flow,
                childrenCategory: ElementCategory.Phrasing
            ));

            // 4.10.14 The progress element
            RegisterElement(new ElementInformation(
                tag: "progress",
                category: ElementCategory.Flow | ElementCategory.Phrasing | ElementCategory.Labelable | ElementCategory.Palpable,
                parentCategory: ElementCategory.Phrasing,
                childrenCategory: ElementCategory.Phrasing, // TODO: can't be progress,
                attributes: new string[] { "value", "max" }
            ));

            // 4.5.7 The q element
            RegisterElement(new ElementInformation(
                tag: "q",
                category: ElementCategory.Flow | ElementCategory.Phrasing | ElementCategory.Palpable,
                parentCategory: ElementCategory.Phrasing,
                childrenCategory: ElementCategory.Phrasing,
                attributes: new string[] { "cite" }
            ));

            // 4.5.12 The rp element
            RegisterElement(new ElementInformation(
                tag: "rp",
                category: ElementCategory.None,
                parentCategory: ElementCategory.Phrasing, // TODO: child of ruby, and immediately before or after an rt element
                childrenCategory: ElementCategory.Text
            ));

            // 4.5.11 The rt element
            // TODO: An rt element's end tag can be omitted if the rt element is immediately followed by an rt or rp element, or if there is no more content in the parent element.
            RegisterElement(new ElementInformation(
                tag: "rt",
                category: ElementCategory.None,
                parentCategory: ElementCategory.Phrasing, // TODO: child of ruby
                childrenCategory: ElementCategory.Phrasing
            ));

            // The rtc element
            // TODO: The closing tag can be omitted if it is immediately followed by a <rb>, <rtc> or <rt> element opening tag or by its parent closing tag.
            RegisterElement(new ElementInformation(
                tag: "rtc",
                category: ElementCategory.None,
                parentCategory: ElementCategory.Phrasing, // TODO: only child of ruby
                childrenCategory: ElementCategory.Phrasing, // TODO: also rt elements
                supportedStatus: SupportedStatus.Obsolete
            ));

            // 4.5.10 The ruby element
            RegisterElement(new ElementInformation(
                tag: "ruby",
                category: ElementCategory.Flow | ElementCategory.Phrasing | ElementCategory.Palpable,
                parentCategory: ElementCategory.Phrasing,
                childrenCategory: ElementCategory.Phrasing // TODO: also rt, rp, rt
            ));

            // 4.5.5 The s element
            // TODO: add
            RegisterElement(new ElementInformation(
                tag: "s",
                category: ElementCategory.Flow | ElementCategory.Phrasing | ElementCategory.Palpable,
                parentCategory: ElementCategory.Phrasing,
                childrenCategory: ElementCategory.Phrasing
            ));

            // 4.5.17 The samp element
            RegisterElement(new ElementInformation(
                tag: "samp",
                category: ElementCategory.Flow | ElementCategory.Phrasing | ElementCategory.Palpable,
                parentCategory: ElementCategory.Phrasing,
                childrenCategory: ElementCategory.Phrasing
            ));

            // 4.12.1 The script element
            RegisterElement(new ElementInformation(
                tag: "script",
                category: ElementCategory.Metadata | ElementCategory.Flow | ElementCategory.Phrasing | ElementCategory.ScriptSupporting,
                parentCategory: ElementCategory.Metadata | ElementCategory.Phrasing | ElementCategory.ScriptSupporting,
                childrenCategory: ElementCategory.Text,
                attributes: new string[] { "src", "type", "charset", "async", "defer", "crossorigin", "nonce", "integrity" }
            ));

            // 4.3.3 The section element
            RegisterElement(new ElementInformation(
                tag: "section",
                category: ElementCategory.Flow | ElementCategory.Sectioning | ElementCategory.Palpable,
                parentCategory: ElementCategory.Flow,
                childrenCategory: ElementCategory.Flow
            ));

            // 4.10.7 The select element
            RegisterElement(new ElementInformation(
                tag: "select",
                category: ElementCategory.Flow | ElementCategory.Phrasing | ElementCategory.Interactive | ElementCategory.Listed | ElementCategory.Labelable | ElementCategory.Submittable | ElementCategory.Resettable | ElementCategory.FormAssociated | ElementCategory.Palpable,
                parentCategory: ElementCategory.Phrasing,
                childrenCategory: ElementCategory.ScriptSupporting, // TODO: also option, optgroup
                attributes: new string[] { "autocomplete", "autofocus", "disabled", "form", "multiple", "name", "required", "size" }
            ));

            // 4.12.4 The slot element
            // TODO: add
            RegisterElement(new ElementInformation(
                tag: "slot",
                category: ElementCategory.Flow | ElementCategory.Phrasing,
                parentCategory: ElementCategory.Phrasing,
                childrenCategory: ElementCategory.Flow, // TODO: should be Transparent
                attributes: new string[] { "name" }
            ));

            // 4.5.4 The small element
            RegisterElement(new ElementInformation(
                tag: "small",
                category: ElementCategory.Flow | ElementCategory.Phrasing | ElementCategory.Palpable,
                parentCategory: ElementCategory.Phrasing,
                childrenCategory: ElementCategory.Phrasing
            ));

            // 4.8.2 The source element
            RegisterElement(new ElementInformation(
                tag: "source",
                category: ElementCategory.None,
                parentCategory: ElementCategory.Phrasing, // TODO: child of Media, before flow content or track elements OR child of picture, before img
                childrenCategory: ElementCategory.None,
                attributes: new string[] { "src", "type", "srcset", "sizes", "media" },
                isVoid: true
            ));

            // 4.5.26 The span element
            RegisterElement(new ElementInformation(
                tag: "span",
                category: ElementCategory.Flow | ElementCategory.Phrasing | ElementCategory.Palpable,
                parentCategory: ElementCategory.Phrasing,
                childrenCategory: ElementCategory.Phrasing
            ));

            // 4.5.3 The strong element
            RegisterElement(new ElementInformation(
                tag: "strong",
                category: ElementCategory.Flow | ElementCategory.Phrasing | ElementCategory.Palpable,
                parentCategory: ElementCategory.Phrasing,
                childrenCategory: ElementCategory.Phrasing
            ));

            // 4.2.6 The style element
            RegisterElement(new ElementInformation(
                tag: "style",
                category: ElementCategory.Metadata, 
                parentCategory: ElementCategory.Phrasing, // TODO: also in noscript in a head
                childrenCategory: ElementCategory.Text,
                attributes: new string[] { "media", "nonce", "type" }
            ));

            // 4.5.19 The sub and sup elements
            RegisterElement(new ElementInformation(
                tag: "sub",
                category: ElementCategory.Flow | ElementCategory.Phrasing | ElementCategory.Palpable,
                parentCategory: ElementCategory.Phrasing, 
                childrenCategory: ElementCategory.Phrasing
            ));

            // 4.5.19 The sub and sup elements
            RegisterElement(new ElementInformation(
                tag: "sup",
                category: ElementCategory.Flow | ElementCategory.Phrasing | ElementCategory.Palpable,
                parentCategory: ElementCategory.Phrasing,
                childrenCategory: ElementCategory.Phrasing
            ));

            // 4.11.2 The summary element
            RegisterElement(new ElementInformation(
                tag: "summary",
                category: ElementCategory.None,
                parentCategory: ElementCategory.Phrasing, // TODO: first child of details
                childrenCategory: ElementCategory.Phrasing // TODO: or one element of heading
            ));

            // 5.1.2 The 'svg' element
            RegisterElement(new ElementInformation(
                tag: "svg",
                category: ElementCategory.Flow,
                parentCategory: ElementCategory.Flow,
                childrenCategory: ElementCategory.Flow
            ));

            // 4.9.1 The table element
            RegisterElement(new ElementInformation(
                tag: "table",
                category: ElementCategory.Flow | ElementCategory.Palpable,
                parentCategory: ElementCategory.Flow,
                // TODO: Optionally a caption element, followed by zero or more colgroup elements, followed optionally by a thead element, followed by either zero or more tbody elements or one or more tr elements, followed optionally by a tfoot element, optionally intermixed with one or more script-supporting elements.
                childrenCategory: ElementCategory.Flow
            ));

            // 4.9.5 The tbody element
            // TODO: A tbody element's start tag can be omitted if the first thing inside the tbody element is a tr element, and if the element is not immediately preceded by a tbody, thead, or tfoot element whose end tag has been omitted. (It can't be omitted if the element is empty.)
            // TODO: A tbody element's end tag can be omitted if the tbody element is immediately followed by a tbody or tfoot element, or if there is no more content in the parent element.
            RegisterElement(new ElementInformation(
                tag: "tbody",
                category: ElementCategory.None,
                parentCategory: ElementCategory.Flow, // TODO: As a child of a table element, after any caption, colgroup, and thead elements, but only if there are no tr elements that are children of the table element.
                childrenCategory: ElementCategory.Flow // TODO: Zero or more tr and script-supporting elements.
            ));

            // 4.9.9 The td element
            // TODO: A td element's end tag can be omitted if the td element is immediately followed by a td or th element, or if there is no more content in the parent element.
            RegisterElement(new ElementInformation(
                tag: "td",
                category: ElementCategory.SectioningRoot,
                parentCategory: ElementCategory.Flow, // TODO: child of tr only
                childrenCategory: ElementCategory.Flow,
                attributes: new string[] { "colspan", "rowspan", "headers" }
            ));

            // 4.12.3 The template element
            RegisterElement(new ElementInformation(
                tag: "template",
                category: ElementCategory.Metadata | ElementCategory.Flow | ElementCategory.Phrasing | ElementCategory.ScriptSupporting,
                parentCategory: ElementCategory.Metadata | ElementCategory.Phrasing | ElementCategory.ScriptSupporting, // TODO: also child of colgroup that doesn't have a span attribute
                childrenCategory: ElementCategory.None
            ));

            // 4.10.11 The textarea element
            RegisterElement(new ElementInformation(
                tag: "textarea",
                category: ElementCategory.Flow | ElementCategory.Phrasing | ElementCategory.Interactive | ElementCategory.Listed | ElementCategory.Labelable | ElementCategory.Submittable | ElementCategory.Resettable | ElementCategory.FormAssociated | ElementCategory.Palpable,
                parentCategory: ElementCategory.Phrasing,
                childrenCategory: ElementCategory.Text,
                attributes: new string[] { "autocomplete", "autofocus", "cols", "dirame", "disabled", "form", "inputmode", "maxlength", "minlength", "name", "placeholder", "readonly", "required", "rows", "wrap" }
            ));

            // 4.9.7 The tfoot element
            // TODO: A tfoot element's end tag can be omitted if there is no more content in the parent element.
            RegisterElement(new ElementInformation(
                tag: "tfoot",
                category: ElementCategory.None,
                parentCategory: ElementCategory.Flow, // TODO: As a child of a table element, after any caption, colgroup, thead, tbody, and tr elements, but only if there are no other tfoot elements that are children of the table element.
                childrenCategory: ElementCategory.ScriptSupporting // TODO: also zero or more tr elements
            ));

            // 4.9.10 The th element
            // TODO: A th element's end tag can be omitted if the th element is immediately followed by a td or th element, or if there is no more content in the parent element.
            RegisterElement(new ElementInformation(
                tag: "th",
                category: ElementCategory.None,
                parentCategory: ElementCategory.Flow, // TODO: child of tr only.
                childrenCategory: ElementCategory.Flow, // TODO: no header, footer, sectioning or heading content
                attributes: new string[] { "colspan", "rowspan", "headers", "scope", "abbr" }
            ));

            // 4.9.6 The thead element
            // TODO: A thead element's end tag can be omitted if the thead element is immediately followed by a tbody or tfoot element.
            RegisterElement(new ElementInformation(
                tag: "thead",
                category: ElementCategory.None,
                parentCategory: ElementCategory.Flow, // TODO: As a child of a table element, after any caption, and colgroup elements and before any tbody, tfoot, and tr elements, but only if there are no other thead elements that are children of the table element.
                childrenCategory: ElementCategory.ScriptSupporting // TODO: also zero or more tr elements
            ));

            // 4.5.14 The time element
            RegisterElement(new ElementInformation(
                tag: "time",
                category: ElementCategory.Flow | ElementCategory.Phrasing | ElementCategory.ScriptSupporting,
                parentCategory: ElementCategory.Phrasing,
                childrenCategory: ElementCategory.Flow, // TODO: phrasing if datetime, otherwise text
                attributes: new string[] { "datetime" }
            ));

            // 4.2.2 The title element
            RegisterElement(new ElementInformation(
                tag: "title",
                category: ElementCategory.Metadata,
                parentCategory: ElementCategory.Phrasing, // TODO: only head with no other title elements
                childrenCategory: ElementCategory.Text // TODO: can't be whitespace
            ));

            // 4.9.8 The tr element
            // TODO: A tr element's end tag can be omitted if the tr element is immediately followed by another tr element, or if there is no more content in the parent element.
            RegisterElement(new ElementInformation(
                tag: "tr",
                category: ElementCategory.None,
                // TODO: As a child of a thead element.
                // TODO: As a child of a tbody element.
                // TODO: As a child of a tfoot element.
                // TODO: As a child of a table element, after any caption, colgroup, and thead elements, but only if there are no tbody elements that are children of the table element.
                parentCategory: ElementCategory.Phrasing,
                childrenCategory: ElementCategory.ScriptSupporting // TODO: also zero or more td elements
            ));

            // 4.8.11 The track element
            RegisterElement(new ElementInformation(
                tag: "track",
                category: ElementCategory.None,
                parentCategory: ElementCategory.Phrasing, // TODO: child of media element only
                childrenCategory: ElementCategory.None,
                attributes: new string[] { "kind", "src", "srclang", "label", "default" },
                isVoid: true
            ));

            // 4.5.22 The u element
            RegisterElement(new ElementInformation(
                tag: "u",
                category: ElementCategory.Flow | ElementCategory.Phrasing | ElementCategory.Palpable,
                parentCategory: ElementCategory.Phrasing,
                childrenCategory: ElementCategory.Phrasing
            ));

            // 4.4.6 The ul element
            RegisterElement(new ElementInformation(
                tag: "ul",
                category: ElementCategory.Flow | ElementCategory.Palpable, // TODO: Palpable if has one or more li elements
                parentCategory: ElementCategory.Flow,
                childrenCategory: ElementCategory.ScriptSupporting // TODO: also zero or more li elements
            ));

            // 4.5.16 The var element
            RegisterElement(new ElementInformation(
                tag: "var",
                category: ElementCategory.Flow | ElementCategory.Phrasing | ElementCategory.Palpable,
                parentCategory: ElementCategory.Phrasing,
                childrenCategory: ElementCategory.Phrasing
            ));

            // 4.8.9 The video element
            RegisterElement(new ElementInformation(
                tag: "video",
                category: ElementCategory.Flow | ElementCategory.Phrasing | ElementCategory.Embedded | ElementCategory.Palpable, // TODO: interactive if has controls attribute
                parentCategory: ElementCategory.Embedded,
                // TODO: If the element has a src attribute: zero or more track elements, then transparent, but with no media element descendants.
                // TODO: If the element does not have a src attribute: zero or more source elements, then zero or more track elements, then transparent, but with no media element descendants.
                childrenCategory: ElementCategory.Flow,
                attributes: new string[] { "src", "crossorigin", "poster", "preload", "autoplay", "playsinline", "loop", "muted", "controls", "width", "height" }
            ));

            // 4.5.28 The wbr element
            RegisterElement(new ElementInformation(
                tag: "wbr",
                category: ElementCategory.Flow | ElementCategory.Phrasing,
                parentCategory: ElementCategory.Phrasing,
                childrenCategory: ElementCategory.Text
            ));
        }
    }
}
