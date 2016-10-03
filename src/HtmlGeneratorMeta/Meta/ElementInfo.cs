using System.Collections.Generic;

namespace HtmlGenerator.Meta
{
    public class ElementInfo
    {
        public string Name { get; }
        public bool IsVoid { get; }
        public List<string> Attributes { get; }

        public ElementInfo(string name, bool isVoid, params string[] attributes)
        {
            Name = name;
            IsVoid = isVoid;
            Attributes = new List<string>(attributes);
        }
    }
}
