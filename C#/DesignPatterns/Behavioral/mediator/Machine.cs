using System;

namespace mediator
{
    public class Machine : IColleague
    {
        private Button _button;
        public IMachineMediator Mediator { get; set; }

        public void Start()
        {
            var button = new Button();
            _button = button;
        }

        public void Wash() => _button.Press();
    }
}