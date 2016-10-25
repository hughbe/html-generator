using System;
using System.Text;
using HtmlGenerator.Extensions;

namespace HtmlGenerator
{
    public class HtmlAttribute : HtmlObject, IEquatable<HtmlAttribute>
    {
        public HtmlAttribute(string name)
        {
            Requires.NotNullOrWhitespace(name, nameof(name));
            Name = name.ToAsciiLower();
        }

        public HtmlAttribute(string name, string value) : this(name)
        {
            SetValue(value);
        }

        public override HtmlObjectType ObjectType => HtmlObjectType.Attribute;

        public string Name { get; }
        public string Value { get; private set; }

        public bool IsVoid => Value == null;

        public void RemoveFromParent()
        {
            if (Parent == null)
            {
                return;
            }

            Parent.RemoveAttribute(this);
        }

        public void SetValue(string value)
        {
            Requires.NotNull(value, nameof(value));
            Value = value;
        }

        public override bool Equals(object obj) => Equals(obj as HtmlAttribute);

        public bool Equals(HtmlAttribute attribute)
        {
            if (attribute == null)
            {
                return false;
            }

            return (Name == attribute.Name) && (Value == attribute.Value);
        }

        public override int GetHashCode() => IsVoid ? Name.GetHashCode() : Name.GetHashCode() ^ Value.GetHashCode();

        public override void Serialize(StringBuilder builder, int depth, HtmlSerializeOptions serializeOptions)
        {
            int extraLength = IsVoid ? 0 : 3 + Value.Length;
            builder.EnsureCapacity(builder.Capacity + Name.Length + extraLength);
            builder.Append(Name);
            if (!IsVoid)
            {
                builder.Append('=');
                builder.Append('"');
                builder.Append(Value);
                builder.Append('"');
            }
        }
    }
}
