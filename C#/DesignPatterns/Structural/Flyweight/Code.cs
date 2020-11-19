using System;

namespace Flyweight
{
    public class Code
    {
        public Code(string code)
        {
            Console.WriteLine(code);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}