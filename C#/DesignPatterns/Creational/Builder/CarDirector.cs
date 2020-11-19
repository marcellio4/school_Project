namespace QuestionTwo
{
    public class CarDirector : ICarDirector
    {
        private ICarBuilder _carBuilder = null;
        public CarDirector(ICarBuilder cb)
        {
            _carBuilder = cb;
        }

        public void Build()
        {
            _carBuilder.GetCar();
        }
    }
}