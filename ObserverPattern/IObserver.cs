using Design_Patterns_Assignment.ObserverPattern.ObserverFiles;
using Design_Patterns_Assignment.ObserverPattern.SubjectFiles;
using System;

namespace Design_Patterns_Assignment.ObserverPattern
{
    internal interface IObserver
    {
        IEmail Email { get; set; }
        IEmailWatcher EmailWatcher { get; set; }

        void Run();
        void Update(DateTime Time);
    }
}