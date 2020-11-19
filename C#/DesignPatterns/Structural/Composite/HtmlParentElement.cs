using System;
using System.Collections.Generic;

namespace Composite
{
    public class HtmlParentElement: HtmlTag
    {
        public HtmlParentElement(string body)
        {
            TagBody = body;
        }
    }
}