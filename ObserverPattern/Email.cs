using System;
using System.Collections.Generic;

namespace Design_Patterns_Assignment.ObserverPattern
{
    internal class Email
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

        public void notifyObservers()
        {
            foreach (var observer in Observers)
            {
                observer.Update(Time);
            }
        }

        public void UpdateTime()
        {
            Time = DateTime.Now;
            notifyObservers();
        }



        internal static string Check()
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