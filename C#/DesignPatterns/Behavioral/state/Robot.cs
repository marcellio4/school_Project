using System;

namespace state
{
    public class Robot : IRoboticState
    {
        private enum State
        {
            On,
            Cook,
            Walk,
            Off
        };

        private State RoboticState { get; set; }

        public Robot() => RoboticState = State.On;

        public void Walk()
        {
            if (!OkayToProceed("walk")) return;
            Console.WriteLine("Walking...");
            RoboticState = State.Walk;
        }

        public void Cook()
        {
            if (!OkayToProceed("cook")) return;
            Console.WriteLine("Cooking...");
            RoboticState = State.Cook;
        }

        public void Off()
        {
            if (!OkayToProceed("off")) return;
            Console.WriteLine("Robot is switched off");
            RoboticState = State.Off;
        }

        public void On()
        {
            Console.WriteLine("Robot is switched on");
            RoboticState = State.On;
        }

        private bool OkayToProceed(string state)
        {
            bool flag = true;
            if (RoboticState == State.Off)
            {
                Console.WriteLine($"Cannot {state} at Off state.");
                flag = false;
            }

            return flag;
        }
    }
}