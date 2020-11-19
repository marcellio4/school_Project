using System.Collections.Generic;

namespace Decorator
{
    public class SimplyVegPizza : IPizza
    {
        private List<IPizza> _pizzas = new List<IPizza>();
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set; }
        
        public void AddPizza(IPizza pizza)
        {
            _pizzas.Add(pizza);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}