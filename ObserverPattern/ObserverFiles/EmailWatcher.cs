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
        public void Check(string email)
        {
            Console.WriteLine(email);
        }
    }
}