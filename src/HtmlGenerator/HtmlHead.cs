namespace HtmlGenerator
{
    public class HtmlHead : HtmlElement
    {
        public HtmlHead(string title = null) : base("head")
        {
            if (title != null)
            {
                Title = Add(Tags.Title.WithContent(title));
            }
        }

        public HtmlElement Title { get; set; }
    }
}
