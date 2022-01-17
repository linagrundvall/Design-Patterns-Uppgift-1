using Design_Patterns_Assignment.ObserverPattern.ObserverFiles;
using System;
using System.Collections.Generic;

namespace Design_Patterns_Assignment.ObserverPattern.SubjectFiles
{
    class Email : IEmail
    {
        public List<IWatcher> Observers { get; set; }
        public DateTime Time { get; set; }
        public string NewEmail { get; set; }

        public Email()
        {
            Observers = new();
        }

        public void RegisterObserver(IWatcher observer)
        {
            Observers.Add(observer);
        }

        public void UnRegisterObserver(IWatcher observer)
        {
            Observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in Observers)
            {
                observer.Check(NewEmail);
            }
        }

        public void UpdateTime()
        {
            Time = DateTime.Now;
            //NotifyObservers();
        }

        public void Check()
        {
            var evenMinute = DateTime.Now.Minute % 2;
            if (evenMinute==0)
            {
                Console.WriteLine("This is the email.");
                NotifyObservers();
            }
            Console.WriteLine("No new emails.");
        }

    }
}