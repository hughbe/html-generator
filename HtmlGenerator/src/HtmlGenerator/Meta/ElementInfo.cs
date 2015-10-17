using System.Collections.ObjectModel;

namespace HtmlGenerator.Meta
{
    public class ElementInfo
    {
        public string Name { get; }
        public bool IsVoid { get; }
        public Collection<HtmlAttribute> Attributes { get; }

        internal ElementInfo(string name, bool isVoid, params HtmlAttribute[] attributes)
        {
            Name = name;
            IsVoid = isVoid;
            Attributes = new Collection<HtmlAttribute>(attributes);
        }
    }
}
