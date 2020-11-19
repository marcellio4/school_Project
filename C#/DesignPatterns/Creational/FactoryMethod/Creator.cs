using System;

namespace QuestionThree
{
    public class Creator : ICreator
    {
        private ConcreteCreator _concreteCreator;
        public IProduct FactoryMethod(string s) // some type of argument - you might change this
        {
            throw new NotImplementedException();
        }

        public ConcreteProduct FactoryMethod()
        {
            return _concreteCreator.FactoryMethod();
        }
    }
}