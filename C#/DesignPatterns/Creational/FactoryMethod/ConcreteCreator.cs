namespace QuestionThree
{
    public class ConcreteCreator : ICreator
    {
        public ConcreteProduct FactoryMethod()
        {
            return new ConcreteProduct();
        }
        
        // any additional code that is required
    }
}