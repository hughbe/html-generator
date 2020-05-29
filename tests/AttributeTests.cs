using Xunit;

namespace HtmlGenerator.Tests
{
    public class AttributeTests
    {
        [Fact]
        public void AttributeConstructors()
        {
            VerifyAttribute(Attribute.Accept("value"), "accept", "value");
            VerifyAttribute(Attribute.AcceptCharset("value"), "accept-charset", "value");
            VerifyAttribute(Attribute.AccessKey("value"), "accesskey", "value");
            VerifyAttribute(Attribute.Action("value"), "action", "value");
            VerifyAttribute(Attribute.Align, "align", null);
            VerifyAttribute(Attribute.AllowFullScreen, "allowfullscreen", null);
            VerifyAttribute(Attribute.Alt("value"), "alt", "value");
            VerifyAttribute(Attribute.Async("value"), "async", "value");
            VerifyAttribute(Attribute.AutoComplete("value"), "autocomplete", "value");
            VerifyAttribute(Attribute.AutoFocus, "autofocus", null);
            VerifyAttribute(Attribute.AutoPlay("value"), "autoplay", "value");
            VerifyAttribute(Attribute.AutoSave("value"), "autosave", "value");

            VerifyAttribute(Attribute.BgColor("value"), "bgcolor", "value");
            VerifyAttribute(Attribute.Border("value"), "border", "value");

            VerifyAttribute(Attribute.CellPadding("value"), "cellpadding", "value");
            VerifyAttribute(Attribute.CellSpacing("value"), "cellspacing", "value");
            VerifyAttribute(Attribute.Charset("value"), "charset", "value");
            VerifyAttribute(Attribute.Checked, "checked", null);
            VerifyAttribute(Attribute.Cite("value"), "cite", "value");
            VerifyAttribute(Attribute.Class("value"), "class", "value");
            VerifyAttribute(Attribute.Color("value"), "color", "value");
            VerifyAttribute(Attribute.Cols("value"), "cols", "value");
            VerifyAttribute(Attribute.ColSpan("value"), "colspan", "value");
            VerifyAttribute(Attribute.Command("value"), "command", "value");
            VerifyAttribute(Attribute.Compact("value"), "compact", "value");
            VerifyAttribute(Attribute.Content("value"), "content", "value");
            VerifyAttribute(Attribute.ContentEditable("value"), "contenteditable", "value");
            VerifyAttribute(Attribute.ContextMenu("value"), "contextmenu", "value");
            VerifyAttribute(Attribute.Controls, "controls", null);
            VerifyAttribute(Attribute.Coords("value"), "coords", "value");
            VerifyAttribute(Attribute.CrossOrigin("value"), "crossorigin", "value");

            VerifyAttribute(Attribute.Data("value"), "data", "value");
            VerifyAttribute(Attribute.DateTime("value"), "datetime", "value");
            VerifyAttribute(Attribute.Default, "default", null);
            VerifyAttribute(Attribute.DefaultStyle("value"), "default-style", "value");
            VerifyAttribute(Attribute.Defer("value"), "defer", "value");
            VerifyAttribute(Attribute.Dir("value"), "dir", "value");
            VerifyAttribute(Attribute.Disabled, "disabled", null);
            VerifyAttribute(Attribute.Download("value"), "download", "value");
            VerifyAttribute(Attribute.Draggable("value"), "draggable", "value");
            VerifyAttribute(Attribute.DropZone("value"), "dropzone", "value");

            VerifyAttribute(Attribute.EncType("value"), "enctype", "value");

            VerifyAttribute(Attribute.For("value"), "for", "value");
            VerifyAttribute(Attribute.Form("value"), "form", "value");
            VerifyAttribute(Attribute.FormAction("value"), "formaction", "value");
            VerifyAttribute(Attribute.FormEncType("value"), "formenctype", "value");
            VerifyAttribute(Attribute.FormMethod("value"), "formmethod", "value");
            VerifyAttribute(Attribute.FormNoValidate, "formnovalidate", null);
            VerifyAttribute(Attribute.FormTarget("value"), "formtarget", "value");

            VerifyAttribute(Attribute.Headers("value"), "headers", "value");
            VerifyAttribute(Attribute.Height("value"), "height", "value");
            VerifyAttribute(Attribute.Hidden("value"), "hidden", "value");
            VerifyAttribute(Attribute.High("value"), "high", "value");
            VerifyAttribute(Attribute.Href("value"), "href", "value");
            VerifyAttribute(Attribute.HrefLang("value"), "hreflang", "value");
            VerifyAttribute(Attribute.HttpEquiv("value"), "http-equiv", "value");

            VerifyAttribute(Attribute.Icon("value"), "icon", "value");
            VerifyAttribute(Attribute.Id("value"), "id", "value");
            VerifyAttribute(Attribute.InputMode("value"), "inputmode", "value");
            VerifyAttribute(Attribute.Integrity("value"), "integrity", "value");
            VerifyAttribute(Attribute.IsMap("value"), "ismap", "value");

            VerifyAttribute(Attribute.Kind("value"), "kind", "value");

            VerifyAttribute(Attribute.Label("value"), "label", "value");
            VerifyAttribute(Attribute.Lang("value"), "lang", "value");
            VerifyAttribute(Attribute.List("value"), "list", "value");
            VerifyAttribute(Attribute.LongDesc("value"), "longdesc", "value");
            VerifyAttribute(Attribute.Loop("value"), "loop", "value");
            VerifyAttribute(Attribute.Low("value"), "low", "value");


            VerifyAttribute(Attribute.Max("value"), "max", "value");
            VerifyAttribute(Attribute.MaxLength("value"), "maxlength", "value");
            VerifyAttribute(Attribute.Media("value"), "media", "value");
            VerifyAttribute(Attribute.Method("value"), "method", "value");
            VerifyAttribute(Attribute.Min("value"), "min", "value");
            VerifyAttribute(Attribute.MinLength("value"), "minlength", "value");
            VerifyAttribute(Attribute.Multiple, "multiple", null);
            VerifyAttribute(Attribute.Muted("value"), "muted", "value");

            VerifyAttribute(Attribute.Name("value"), "name", "value");
            VerifyAttribute(Attribute.NoValidate, "novalidate", null);
            VerifyAttribute(Attribute.NoWrap("value"), "nowrap", "value");

            VerifyAttribute(Attribute.Open("value"), "open", "value");
            VerifyAttribute(Attribute.Optimum("value"), "optimum", "value");

            VerifyAttribute(Attribute.Pattern("value"), "pattern", "value");
            VerifyAttribute(Attribute.Ping("value"), "ping", "value");
            VerifyAttribute(Attribute.Placeholder("value"), "placeholder", "value");
            VerifyAttribute(Attribute.Poster("value"), "poster", "value");
            VerifyAttribute(Attribute.Preload("value"), "preload", "value");

            VerifyAttribute(Attribute.RadioGroup("value"), "radiogroup", "value");
            VerifyAttribute(Attribute.Readonly, "readonly", null);
            VerifyAttribute(Attribute.Refresh("value"), "refresh", "value");
            VerifyAttribute(Attribute.Rel("value"), "rel", "value");
            VerifyAttribute(Attribute.Required, "required", null);
            VerifyAttribute(Attribute.Reversed("value"), "reversed", "value");
            VerifyAttribute(Attribute.Rows("value"), "rows", "value");
            VerifyAttribute(Attribute.RowSpan("value"), "rowspan", "value");

            VerifyAttribute(Attribute.Sandbox, "sandbox", null);
            VerifyAttribute(Attribute.Scope("value"), "scope", "value");
            VerifyAttribute(Attribute.Scoped, "scoped", null);
            VerifyAttribute(Attribute.Seamless, "seamless", null);
            VerifyAttribute(Attribute.Selected, "selected", null);
            VerifyAttribute(Attribute.SelectionDirection("value"), "selectiondirection", "value");
            VerifyAttribute(Attribute.Shape("value"), "shape", "value");
            VerifyAttribute(Attribute.Size("value"), "size", "value");
            VerifyAttribute(Attribute.Sizes("value"), "sizes", "value");
            VerifyAttribute(Attribute.Span("value"), "span", "value");
            VerifyAttribute(Attribute.SpellCheck("value"), "spellcheck", "value");
            VerifyAttribute(Attribute.Src("value"), "src", "value");
            VerifyAttribute(Attribute.SrcDoc("value"), "srcdoc", "value");
            VerifyAttribute(Attribute.SrcLang("value"), "srclang", "value");
            VerifyAttribute(Attribute.SrcSet("value"), "srcset", "value");
            VerifyAttribute(Attribute.Start("value"), "start", "value");
            VerifyAttribute(Attribute.Step("value"), "step", "value");
            VerifyAttribute(Attribute.Style("value"), "style", "value");

            VerifyAttribute(Attribute.TabIndex("value"), "tabindex", "value");
            VerifyAttribute(Attribute.Target("value"), "target", "value");
            VerifyAttribute(Attribute.Text("value"), "text", "value");
            VerifyAttribute(Attribute.Title("value"), "title", "value");
            VerifyAttribute(Attribute.Translate("value"), "translate", "value");
            VerifyAttribute(Attribute.Type("value"), "type", "value");
            VerifyAttribute(Attribute.TypeMustMatch, "typemustmatch", null);

            VerifyAttribute(Attribute.UseMap("value"), "usemap", "value");

            VerifyAttribute(Attribute.Value("value"), "value", "value");
            VerifyAttribute(Attribute.Volume("value"), "volume", "value");

            VerifyAttribute(Attribute.Width("value"), "width", "value");
            VerifyAttribute(Attribute.Wrap("value"), "wrap", "value");

            VerifyAttribute(Attribute.Xmls("value"), "xmls", "value");
        }

        private static void VerifyAttribute(HtmlAttribute attribute, string name, string value)
        {
            Assert.Equal(name, attribute.Name);
            Assert.Equal(value, attribute.Value);
            Assert.Equal(value == null, attribute.IsVoid);
            Assert.Null(attribute.Parent);
        }
    }
}
