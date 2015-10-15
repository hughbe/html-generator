using System;

namespace HtmlGenerator
{
    public struct HtmlAttribute
    {
        public string Name { get; }
        public string Value { get; }
        public bool IsVoidAttribute { get; }

        internal HtmlAttribute(string name, string value, bool isVoidAttribute)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (name.Length == 0)
            {
                throw new ArgumentException("The attribute's name must not be an empty string", nameof(name));
            }
            
            Name = name;
            Value = value;
            IsVoidAttribute = isVoidAttribute;
        }

        public string Serialize()
        {
            var attribute = "";
            if (IsVoidAttribute || Value == null) //No attribute content
            {
                attribute = Name;
            }
            else
            {
                attribute = Name + "=" + "\"" + Value + "\"";
            }
            return attribute;
        }

        public override string ToString() => Serialize();
    }
}
