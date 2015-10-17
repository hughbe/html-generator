namespace HtmlGenerator.Meta
{
    public class AttributeInfo
    {
        public string Name { get; }
        public bool IsVoid { get; }

        internal AttributeInfo(string name, bool isVoid)
        {
            Name = name ?? "";
            IsVoid = isVoid;
        }
    }
}
