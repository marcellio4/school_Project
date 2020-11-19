using System.Linq;

namespace visitor
{
    public class StyleVisitor : IVisitor
    {
        public void Visit(HtmlElement element)
        {
            element.StartTag = element.TagName.Remove(element.StartTag.Length - 1) + " style='width:46px;' ";
        }

        public void Visit(HtmlParentElement parentElement)
        {
            parentElement.StartTag = parentElement.TagName.Remove(parentElement.StartTag.Length - 1) + " style='width:58px;' ";
        }
    }
}