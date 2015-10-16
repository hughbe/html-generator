using System;

namespace HtmlGenerator
{
    public class HtmlAttribute
    {
        public string Name { get; }
        public string Value { get; }
        public bool IsVoid { get; }
        
        protected HtmlAttribute(HtmlAttribute attribute) : this(attribute.Name, attribute.Value, attribute.IsVoid)
        {
        }
         
        internal HtmlAttribute(string name, string value, bool isVoid)
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
            IsVoid = isVoid;
        }

        public string Serialize()
        {
            string attribute;
            if (IsVoid || Value == null) //No attribute content
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