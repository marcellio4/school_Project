using System;
using System.Collections.Generic;
using observer;

namespace observer
{
    public static class TestObserver
    {
        public static void Main(string[] args)
        {
            ISubject subject = new CommentaryObject(new List<IObserver>(), "Football Match [2019MAR24]");
            IObserver observer = new SMSUsers(subject, "Adam Warner [Manchester]");
            observer.Subscribe();
            subject.SubscribeObserver(observer);

            Console.WriteLine();

            IObserver observer2 = new SMSUsers(subject, "Tim Ronney [London]");
            observer2.Subscribe();
            subject.SubscribeObserver(observer2);

            ICommentary cObject = subject as ICommentary;
            cObject.Description = "Welcome to live football match";
            subject.NotifyObservers();
            
            Console.WriteLine();
            
            cObject.Description = "Current score 0-0";
            subject.NotifyObservers();

            Console.WriteLine();

            observer2.UnSubscribe();
            subject.UnSubscribeObserver(observer2);

            Console.WriteLine();

            cObject.Description = "It's a goal!!";
            subject.NotifyObservers();
            
            Console.WriteLine();
            
            cObject.Description = "Current score 1-0";
            subject.NotifyObservers();

            Console.WriteLine();

            IObserver observer3 = new SMSUsers(subject, "Marie [Paris]");
            observer3.Subscribe();
            subject.SubscribeObserver(observer3);

            Console.WriteLine();

            cObject.Description = "It's another goal!!";
            subject.NotifyObservers();
            
            Console.WriteLine();
            
            cObject.Description = "Half-time score 2-0";
            subject.NotifyObservers();
        }
    }
}