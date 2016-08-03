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
            Attributes = new List<HtmlAttribute>(attributes)
            {
                BaseAttribute.AccessKey,
                BaseAttribute.Class,
                BaseAttribute.ContentEditable,
                BaseAttribute.ContextMenu,
                BaseAttribute.Dir,
                BaseAttribute.Hidden,
                BaseAttribute.Id,
                BaseAttribute.Lang,
                BaseAttribute.SpellCheck,
                BaseAttribute.Style,
                BaseAttribute.TabIndex
            };
        }
    }
}
