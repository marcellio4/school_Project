using System;
using System.ComponentModel.DataAnnotations;

namespace worksheet_nine_behavioural_design_patterns
{
    public class Originator
    {
        private string _lastUndoSavepoint;
        public double X { get; set; }
        public double Y { get; set; }
        private CareTaker _careTaker;

        public Originator(double x, double y, CareTaker careTaker)
        {
            CreateSavePoint("INITIAL");
            X = x;
            Y = y;
            _careTaker = careTaker;
        }

        public void CreateSavePoint(string savepointName)
        {
            Console.WriteLine($"Saving state...{savepointName}");
        }

        public void Undo()
        {
        }

        public void Undo(string savepointName)
        {
            Console.WriteLine($"Undo at ...{savepointName}");
        }

        public void UndoAll()
        {
            _careTaker.ClearSavePoints();
        }

        private void OriginatorState(string savepointName)
        {
            _careTaker.Memento(savepointName);
        }

        public override string ToString() => $"X: {X}, Y: {Y}";

        public void CreateSavepoint(string save1)
        {
            Console.WriteLine($"Saving state...{save1}");
        }
    }
}