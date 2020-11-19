using System;

namespace QuestionThree
{
    public static class Driver
    {
        public static void Main(string[] args)
        {
            
            // An array of creators

            ICreator[] creators = new ICreator[1];
 
            creators[0] = new ConcreteCreator();
 
            // Iterate over creators and create products

            foreach (ICreator creator in creators)
            {
                ConcreteProduct product = creator.FactoryMethod();
                Console.WriteLine("Created {0}",
                    product.GetType().Name);
            }
 
            // Wait for user

            Console.ReadKey();
        }
    }
}