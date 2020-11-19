using System;

namespace observer
{
    public class SMSUsers : IObserver
    {
        private ISubject _subject;
        private string _name;
        public SMSUsers(ISubject subject, string s)
        {
            _subject = subject;
            _name = s;
        }

        public void Update(string desc)
        {
            Console.WriteLine($"{_name}: {desc}");
        }

        public void Subscribe()
        {
            Console.WriteLine($"Subscribing {_name} to {_subject.SubjectDetails()} ...");
            Console.WriteLine("Subscribed successfully.");
        }

        public void UnSubscribe()
        {
           Console.WriteLine($"Unsubscribing {_name} to {_subject.SubjectDetails()} ...");
           Console.WriteLine("Unsubscribed successfully.");
        }
    }
}