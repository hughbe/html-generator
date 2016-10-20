using System;
using System.Text;

namespace HtmlGenerator
{
    public class HtmlText : HtmlNode, IEquatable<HtmlText>
    {
        public HtmlText(string text)
        {
            Requires.NotNull(text, nameof(text));
            Text = text;
        }

        public override HtmlObjectType ObjectType => HtmlObjectType.Text;

        public string Text { get; }

        public override bool Equals(object obj) => Equals(obj as HtmlText);

        public bool Equals(HtmlText other) => other != null && Text == other.Text;

        public override int GetHashCode() => Text.GetHashCode();

        public override void Serialize(StringBuilder builder, HtmlSerializeOptions serializeOptions) => builder.Append(Text);

        public static implicit operator HtmlText(string text) => new HtmlText(text);
    }
}
