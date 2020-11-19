using System;

namespace visitor
{
    public class HtmlParentElement : HtmlTag
    {
        public HtmlParentElement(string tagName)
        {
            TagName = tagName;
        }

        public override string TagName { get; set; }
        public override string StartTag { get; set; }
        public override string EndTag { get; set; }

        public override void AddChildTag(HtmlTag htmlTag)
        {
            GetChildren().Add(htmlTag);
        }

        public override void RemoveChildTag(HtmlTag htmlTag)
        {
            GetChildren().Remove(htmlTag);
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override void GenerateHtml()
        {
            Console.WriteLine(StartTag);
            foreach (HtmlTag element in GetChildren())
            {
                if (element.TagName == "<body>")
                {
                    element.GenerateHtml(); 
                }
                else
                {
                    Console.WriteLine(element.StartTag + element.TagBody + element.EndTag);
                }
            }
            Console.WriteLine(EndTag);
        }
    }
}