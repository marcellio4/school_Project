using System.Net.Http.Headers;

namespace Bridge
{
    public abstract class Car
    {
        public Car(IProduct product, string carType)
        {
        }
        
        public abstract void Assemble();
        public abstract void ProduceProduct();

        public override string ToString()
        {
            return base.ToString(); // REPLACE
        }
    }
}