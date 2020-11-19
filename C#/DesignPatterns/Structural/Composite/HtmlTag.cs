using System;
using System.Collections.Generic;

namespace Composite
{
    public abstract class HtmlTag
    {
        public string StartTag { get; set; }
        public string EndTag { get; set; }
        public string TagBody { get; set; }

        private List<HtmlTag> children = new List<HtmlTag>();

        public void AddChildTag(HtmlTag htmlTag)
        {
            children.Add(htmlTag);
        }

        public void RemoveChildTag(HtmlTag htmlTag)
        {
            children.Remove(htmlTag);
        }

        public void GenerateHtml()
        {
            Console.WriteLine(StartTag);
            foreach (HtmlTag element in children)
            {
                if (element.TagBody == "<body>")
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