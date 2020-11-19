using System;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;
using System.Threading;

namespace mediator
{
    public class DenimMediator : IMachineMediator
    {
        private const int DrumSpeed = 1400;
        private const int Temperature = 30;
        private Machine Machine { get; set; }
        private Heater Heater { get; set; }
        private Motor Motor { get; set; }
        private Sensor Sensor { get; set; }
        private SoilRemoval SoilRemoval { get; set; }
        private Valve Valve { get; set; }

        public DenimMediator(Machine machine, Heater heater, Motor motor, Sensor sensor,
            SoilRemoval soilRemoval, Valve valve)
        {
            Machine = machine;
            Heater = heater;
            Sensor = sensor;
            SoilRemoval = soilRemoval;
            Motor = motor;
            Valve = valve;
            Console.WriteLine($"............... Setting up for DENIM program ...............");
        }

        public void Start() => Wash();

        public void Wash()
        {
            Open();
            Console.WriteLine("Filling water...");
            Closed();
            Console.WriteLine("Heater is on...");
            if (CheckTemperature(Temperature))
            {
                Console.WriteLine($"Temperature reached {Temperature} C");
                On();
                Motor.StartMotor();
                Motor.RotateDrum(DrumSpeed);
                Console.WriteLine("Adding detergent");
                SoilRemoval.Medium();
                Console.WriteLine("Adding softener");
            }
            else
            {
                Off();
            }
        }

        public void Open() => Valve.Open();

        public void Closed() => Valve.Closed();

        public void On() => Heater.On(Temperature);

        public void Off() => Heater.Off();

        public bool CheckTemperature(int temp) => Sensor.CheckTemperature(temp);
    }
}