using System.Text;

namespace HtmlGenerator
{
    public abstract class HtmlObject
    {
        public HtmlElement Parent { get; internal set; }

        internal HtmlObject _previous;
        internal HtmlObject _next;
    }

    public abstract class SerializableHtmlObject : HtmlObject
    {
        public override string ToString() => Serialize();

        public string Serialize() => Serialize(HtmlSerializeOptions.None);

        public string Serialize(HtmlSerializeOptions serializeType)
        {
            StringBuilder stringBuilder = new StringBuilder();
            Serialize(stringBuilder, serializeType);
            return stringBuilder.ToString();
        }

        internal abstract void Serialize(StringBuilder builder, HtmlSerializeOptions serializeType);
    }
}
