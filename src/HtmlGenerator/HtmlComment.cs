using System;
using System.Text;

namespace HtmlGenerator
{
    public class HtmlComment : HtmlNode, IEquatable<HtmlComment>
    {
        public HtmlComment(string comment)
        {
            Requires.NotNull(comment, nameof(comment));
            Comment = comment;
        }

        public override HtmlObjectType ObjectType => HtmlObjectType.Comment;

        public string Comment { get; }

        public override bool Equals(object obj) => Equals(obj as HtmlComment);

        public bool Equals(HtmlComment other) => other != null && Comment == other.Comment;

        public override int GetHashCode() => Comment.GetHashCode();

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
