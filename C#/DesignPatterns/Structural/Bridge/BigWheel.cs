using System;

namespace Bridge
{
    internal class BigWheel : Car
    {
        private IProduct _product;
        private string _v;

        public BigWheel(IProduct product, string v) : base(product, v)
        {
            _product = product;
            _v = v;
        }

        public override void ProduceProduct()
        {
            Console.WriteLine(_product.ProductName);
        }

        public override void Assemble()
        {
            Console.WriteLine(_v);
        }

        public override string ToString()
        {
            return base.ToString(); // REPLACE
        }
    }
}