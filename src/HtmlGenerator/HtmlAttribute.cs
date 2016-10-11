using System;
using System.Text;

namespace HtmlGenerator
{
    public class HtmlAttribute : SerializableHtmlObject, IEquatable<HtmlAttribute>
    {
        public HtmlAttribute(string name)
        {
            Requires.NotNullOrWhitespace(name, nameof(name));
            Name = name;
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

        public override int GetHashCode() => IsVoid ? Name.GetHashCode() : Name.GetHashCode() ^ Value.GetHashCode();

        public override bool Equals(object obj) => Equals(obj as HtmlAttribute);
        
        public bool Equals(HtmlAttribute attribute)
        {
            if (attribute == null)
            {
                return false;
            }
            return Name == attribute.Name && Value == attribute.Value;
        }

        internal override void Serialize(StringBuilder builder, HtmlSerializeOptions serializeType)
        {
            int extraLength = IsVoid ? 0 : (3 + Value.Length);
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
