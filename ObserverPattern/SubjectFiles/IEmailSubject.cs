using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.ObserverPattern.SubjectFiles
{
    interface IEmailSubject : ISubject
    {
        DateTime Time { get; set; }
        void UpdateTime();
        string NewEmail { get; set; }
        void Check();
    }
}
