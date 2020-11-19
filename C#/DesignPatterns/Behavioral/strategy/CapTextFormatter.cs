using System;

namespace strategy
{
    public class CapTextFormatter : ITextFormatter
    {
        public string Format(string text)
        { 
            return text.ToUpper();
        }
    }
}