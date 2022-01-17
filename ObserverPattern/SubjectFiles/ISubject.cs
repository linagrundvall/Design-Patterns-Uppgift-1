using Design_Patterns_Assignment.ObserverPattern.ObserverFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.ObserverPattern.SubjectFiles
{
    interface ISubject
    {
        List<IWatcher> Observers { get; set; }
        void RegisterObserver(IWatcher observer);
        void UnRegisterObserver(IWatcher observer);
        void NotifyObservers();
    }
}
