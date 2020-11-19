using System.Runtime.CompilerServices;
using System.Text;

namespace QuestionTwo
{
    public class SedanCarBuilder : ICarBuilder
    {
        private Car _car = new MyCar("Sedan");
        public ICar GetCar()
        {
            _car.Brakes = "Four-wheel disc brakes: two ventilated. Electronic brake distribution";
            _car.Engine = "3.5L Duramax V 6 DOHC";
            _car.Power = "285 hp @ 6,500 rpm; 253 ft lb of torque @ 4,000 rpm";
            _car.Seats = "Front seat centre armrest.Rear seat centre armrest.Split-folding rear seats";
            _car.Windows = "Laminated side windows.Fixed rear window with defroster";
            _car.BodyStyle = "External dimensions: overall length (inches): 202.9, overall width (inches): 76.2, overall height (inches): 60.7, wheelbase (inches): 112.9, front track (inches): 65.3, rear track (inches): 65.5 and curb to curb turning circle (feet): 39.5";
            _car.FuelType = "Petrol 19 MPG city, 29 MPG motorway, 23 MPG combined and 437 mi. range";
            return _car;
        }
    }
}