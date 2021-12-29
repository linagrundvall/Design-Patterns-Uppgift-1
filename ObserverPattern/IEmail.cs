using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.ObserverPattern
{
    interface IEmail : ISubject
    {
        DateTime Time { get; set; }
        void UpdateTime();
    }
}
