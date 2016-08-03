using HtmlGenerator;

namespace WebsiteGenerator
{
    internal class Demo
    {
        public void SendError(string errorMessage, string errorDescription)
        {
            var html = new HtmlDocument();

            var head = html.Head;
            var body = html.Body;

            head.AddChild(Tag
                .Title
                .WithInnerText(errorMessage));

            head.AddChild(Tag
               .Link
               .WithRel("stylesheet")
               .WithHref("css/styles.css"));

            body.AddChild(Tag
                .H1
                .WithInnerText(errorMessage));

            body.AddChild(Tag.Hr);

            body.AddChild(Tag
                .P
                .WithInnerText(errorDescription));
        }
    }
}
