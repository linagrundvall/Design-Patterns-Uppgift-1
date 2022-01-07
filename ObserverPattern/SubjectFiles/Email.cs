using Design_Patterns_Assignment.ObserverPattern.ObserverFiles;
using System;
using System.Collections.Generic;

namespace Design_Patterns_Assignment.ObserverPattern.SubjectFiles
{
    internal class Email : IEmail
    {
        public List<IObserver> Observers { get; set; }
        public DateTime Time { get; set; }

        public Email()
        {
            Observers = new();
        }

        public void RegisterObserver(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void UnRegisterObserver(IObserver observer)
        {
            Observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in Observers)
            {
                observer.Update(Time);
            }
        }

        public void UpdateTime()
        {
            Time = DateTime.Now;
            NotifyObservers();
        }

        internal string Check()
        {
            var evenMinute = DateTime.Now.Minute % 2;
            if (evenMinute==0)
            {
                return "this is the email";
            }
            return null;
        }
    }
}