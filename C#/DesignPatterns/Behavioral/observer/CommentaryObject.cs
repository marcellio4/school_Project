using System;
using System.Collections.Generic;

namespace observer
{
    public class CommentaryObject : ISubject, ICommentary
    {
        private List<IObserver> _observers;
        private string _name;
        public CommentaryObject(List<IObserver> observers, string s)
        {
            _observers = observers;
            _name = s;
        }

        public void SubscribeObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void UnSubscribeObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (IObserver observer in _observers)
            {
                observer.Update(Description);
            }
        }

        public string SubjectDetails()
        {
            return _name;
        }

        public string Description { get; set; }
    }
}