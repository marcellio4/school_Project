using System.Collections.Generic;

namespace Decorator
{
    public class SimplyNonVegPizza : IPizza
    {
        public string Description { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}