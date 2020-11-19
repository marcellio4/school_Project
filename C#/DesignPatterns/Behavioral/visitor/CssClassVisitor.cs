namespace visitor
{
    public class CssClassVisitor : IVisitor
    {
        public void Visit(HtmlElement element)
        {
            element.StartTag = element.StartTag + " class='visitor'>";
        }

        public void Visit(HtmlParentElement parentElement)
        {
            parentElement.StartTag = parentElement.StartTag + " class='visitor'>";
        }
    }
}