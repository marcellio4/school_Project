using System;

namespace mediator
{
    public class Sensor
    {
        public bool CheckTemperature(int temp) => ( temp == 40 || temp == 30);
    }
}