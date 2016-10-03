using System.Text;

namespace HtmlGenerator
{
    public class HtmlAttribute : SerializableHtmlObject
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
        
        public string Name { get; }
        public string Value { get; private set; }

        public bool IsVoid => Value == null;

        public void RemoveFromParent()
        {
            if (Parent == null)
            {
                return;
            }
            Parent._attributes.Remove(this);
            Parent = null;
        }

        public void SetValue(string value)
        {
            Requires.NotNull(value, nameof(value));
            Value = value;
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
