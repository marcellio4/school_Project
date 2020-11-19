namespace Decorator
{
    public class RomaTomatoes : PizzaDecorator
    {
        private IPizza _pizza;
        public RomaTomatoes(IPizza pizza)
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