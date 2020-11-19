using System;

namespace strategy
{
    public class LowerTextFormatter : ITextFormatter
    {
        public string Format(string text)
        {
           return text.ToLower();
        }
    }
}