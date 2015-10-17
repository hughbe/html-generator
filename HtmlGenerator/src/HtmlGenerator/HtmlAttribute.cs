using System;

namespace HtmlGenerator
{
    public class HtmlAttribute
    {
        public string ProperName { get; }
        public string Name { get; }
        public string Value { get; }

        public bool IsVoid { get; }
        public bool IsGlobal { get; }
        
        protected internal HtmlAttribute(HtmlAttribute attribute) : this(attribute.Name, attribute.ProperName, attribute.Value, attribute.IsVoid, attribute.IsGlobal)
        {
        }
         
        protected internal HtmlAttribute(string name, string properName, string value, bool isVoid, bool isGlobal)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (name.Length == 0)
            {
                throw new ArgumentException("The attribute's name must not be an empty string", nameof(name));
            }

            if (string.IsNullOrWhiteSpace(properName))
            {
                properName = name;
            }
            properName.Replace(" ", "").Replace("-", "");
            
            Name = name;
            ProperName = properName;
            Value = value;
            IsVoid = isVoid;
            IsGlobal = isGlobal;
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