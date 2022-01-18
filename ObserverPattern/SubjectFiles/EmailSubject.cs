using Design_Patterns_Assignment.ObserverPattern.ObserverFiles;
using System;
using System.Collections.Generic;

namespace Design_Patterns_Assignment.ObserverPattern.SubjectFiles
{
    class EmailSubject : IEmailSubject
    {
        public List<IWatcher> Observers { get; set; }
        public DateTime Time { get; set; }
        public string NewEmail { get; set; }

        public EmailSubject()
        {
            Observers = new();
        }

        public void RegisterObserver(IWatcher observer)
        {
            Observers.Add(observer);
            Console.WriteLine("You are now registered.");
        }

        public void UnRegisterObserver(IWatcher observer)
        {
            Observers.Remove(observer);
            Console.WriteLine("You have unregistered.");
        }

        public void NotifyObservers()
        {
            foreach (var observer in Observers)
            {
                observer.Check(NewEmail);
            }
        }

        public void Check()
        {
            var evenMinute = DateTime.Now.Minute % 2;
            if (evenMinute == 0)
            {
                Console.WriteLine("This is the email.");
                NotifyObservers();
            }
            Console.WriteLine("No new emails.");
        }
    }
}