using Design_Patterns_Assignment.ObserverPattern.SubjectFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.ObserverPattern.ObserverFiles
{
    class EmailWatcher : IEmailWatcher
    {
        public IEmail Email { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        IEmailWatcher IObserver.EmailWatcher { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Run()
        {
            throw new NotImplementedException();
        }

        public void Update(DateTime time)
            {
                Console.WriteLine($"The current time is {time}");
            }
    }
}
