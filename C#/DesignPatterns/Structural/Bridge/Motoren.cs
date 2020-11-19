using System;

namespace Bridge
{
    public class Motoren : Car
    {
        private IProduct _product;
        private string _name;

        public Motoren(IProduct product, string v) : base(product, v)
        {
            _product = product;
            _name = v;
        }

        public override void Assemble()
        {
            Console.WriteLine(_product.ProductName);
        }

        public override void ProduceProduct()
        {
            Console.WriteLine(_name);
        }

        public override string ToString()
        {
            return base.ToString(); // REPLACE
        }
    }
}