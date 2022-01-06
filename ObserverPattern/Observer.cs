using Design_Patterns_Assignment.ObserverPattern.ObserverFiles;
using Design_Patterns_Assignment.ObserverPattern.SubjectFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.ObserverPattern
{
    class Observer
    {
        public static IEmail Email { get; set; }
        public static IEmailWatcher EmailWatcher { get; set; }

        public Observer(IEmail email, IEmailWatcher emailWatcher)
        {
            Email = email;
            EmailWatcher = emailWatcher;
        }

        internal static void Run()
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

    }
}
