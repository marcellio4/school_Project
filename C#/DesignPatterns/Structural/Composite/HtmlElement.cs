using System;

namespace Composite
{
    public class HtmlElement: HtmlTag
    {
        public HtmlElement(string s)
        {
            TagBody = s;
        }
    }
}