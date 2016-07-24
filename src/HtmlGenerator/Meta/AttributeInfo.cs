namespace HtmlGenerator.Meta
{
    public class AttributeInfo
    {
        public string Name { get; }
        public bool IsVoid { get; }

        public bool IsGlobal { get; }

        internal AttributeInfo(string name, bool isVoid, bool isGlobal)
        {
            Name = name ?? "";
            IsVoid = isVoid;
            IsGlobal = isGlobal;
        }
    }
}
