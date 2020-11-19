using System.Collections.Generic;

namespace visitor
{
    public abstract class HtmlTag : IElement
    {
        public abstract string TagName { get; set; }

        public abstract string StartTag { get; set; }

        public abstract string EndTag { get; set; }
        
        private List<HtmlTag> _children = new List<HtmlTag>();

        public string TagBody { get; set; }

        public virtual void AddChildTag(HtmlTag htmlTag)
        {
            _children.Add(htmlTag);
        }

        public virtual void RemoveChildTag(HtmlTag htmlTag)
        {
            _children.Remove(htmlTag);
        }

        public virtual List<HtmlTag> GetChildren()
        {
            return _children;
        }

        public abstract void GenerateHtml();

        public abstract void Accept(IVisitor style);
    }
}