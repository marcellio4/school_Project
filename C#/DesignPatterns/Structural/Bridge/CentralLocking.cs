using System;

namespace Bridge
{
    public class CentralLocking : IProduct
    {
        public CentralLocking(string name)
        {
            ProductName = name;
        }

        public string ProductName { get; set; }

        public void Produce()
        {
            Console.WriteLine(ProductName);
        }

        public override string ToString()
        {
            return base.ToString(); // REPLACE
        }
    }
}