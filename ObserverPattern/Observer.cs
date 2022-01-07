using Design_Patterns_Assignment.ObserverPattern.ObserverFiles;
using Design_Patterns_Assignment.ObserverPattern.SubjectFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.ObserverPattern
{
    internal class Observer : IObserver
    {
        public IEmail Email { get; set; }
        public IEmailWatcher EmailWatcher { get; set; }

        public Observer(IEmail email, IEmailWatcher emailWatcher)
        {
            Email = email;
            EmailWatcher = emailWatcher;
        }

        public void Run()
        {
            Console.WriteLine("Observer");

            //Register Observer
            Email.RegisterObserver(EmailWatcher);

            // Menu

            //Main Game Loop





            //var email = "";

            //while (string.IsNullOrEmpty(email))
            //{
            //    email = Email.Check();
            //}
            //Console.WriteLine(email);
            //Console.WriteLine();
        }

        public void Update(DateTime Time)
        {
            throw new NotImplementedException();
        }
    }
}
