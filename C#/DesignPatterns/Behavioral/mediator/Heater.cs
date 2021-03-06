using System;

namespace mediator
{
    public class Heater : IColleague
    {
        public IMachineMediator Mediator { get; set; }

        public void On(int temp) => Console.WriteLine($"Temperature is set to {temp}");
        public void Off() => Console.WriteLine("Heater is off...");
    }
}