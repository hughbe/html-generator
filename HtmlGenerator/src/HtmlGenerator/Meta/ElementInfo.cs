using System.Collections.Generic;

namespace HtmlGenerator.Meta
{
    public class ElementInfo
    {
        public string Name { get; }
        public bool IsVoid { get; }
        public List<HtmlAttribute> Attributes { get; }

        internal ElementInfo(string name, bool isVoid, params HtmlAttribute[] attributes)
        {
            Name = name;
            IsVoid = isVoid;
            Attributes = new List<HtmlAttribute>(attributes);

            Attributes.Add(BaseAttribute.AccessKey);
            
            Attributes.Add(BaseAttribute.Class);
            Attributes.Add(BaseAttribute.ContentEditable);
            Attributes.Add(BaseAttribute.ContextMenu);

            Attributes.Add(BaseAttribute.Dir);

            Attributes.Add(BaseAttribute.Hidden);

            Attributes.Add(BaseAttribute.Id);

            Attributes.Add(BaseAttribute.Lang);

            Attributes.Add(BaseAttribute.SpellCheck);

            Attributes.Add(BaseAttribute.Style);

            Attributes.Add(BaseAttribute.TabIndex);
        }
    }
}
