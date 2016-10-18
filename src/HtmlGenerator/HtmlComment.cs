using System;
using System.Text;

namespace HtmlGenerator
{
    public class HtmlComment : HtmlElement, IEquatable<HtmlComment>
    {
        public HtmlComment(string comment) : base("comment", isVoid: true)
        {
            Requires.NotNull(comment, nameof(comment));
            Comment = comment;
        }

        public string Comment { get; }

        public override bool Equals(object obj) => Equals(obj as HtmlComment);

        public bool Equals(HtmlComment other) => other != null && Comment == other.Comment;

        public override int GetHashCode() => Comment.GetHashCode();

        public override HtmlObjectType ObjectType => HtmlObjectType.Comment;

        internal override void Serialize(StringBuilder builder, HtmlSerializeOptions serializeType)
        {
            builder.Append('<');
            builder.Append('!');
            builder.Append('-', 2);
            builder.Append(Comment);
            builder.Append('-', 2);
            builder.Append('>');
        }
    }
}
