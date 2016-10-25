using System.Text;

namespace HtmlGenerator
{
    public abstract class HtmlObject
    {
        public HtmlElement Parent { get; internal set; }
        public abstract HtmlObjectType ObjectType { get; }

        public override string ToString() => Serialize();

        public string Serialize() => Serialize(HtmlSerializeOptions.None);

        public string Serialize(HtmlSerializeOptions serializeOptions)
        {
            StringBuilder stringBuilder = new StringBuilder();
            Serialize(stringBuilder, 0, serializeOptions);
            return stringBuilder.ToString();
        }

        public abstract void Serialize(StringBuilder builder, int depth, HtmlSerializeOptions serializeOptions);

        protected static void AddDepth(StringBuilder builder, int depth) => builder.Append(' ', depth * 2);

        internal HtmlObject _previous;
        internal HtmlObject _next;
    }
}
