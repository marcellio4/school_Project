namespace Decorator
{
    public class Ham : PizzaDecorator
    {
        private IPizza _pizza;
        public Ham(IPizza pizza)
        {
            _pizza = pizza;
        }

        public override string Description { get; set; }
        public override decimal Price { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}