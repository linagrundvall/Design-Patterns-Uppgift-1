using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.ObserverPattern.ObserverFiles
{
    class EmailWatcher : IEmailWatcher
    {
            public void Update(DateTime time)
            {
                Console.WriteLine($"The current time is {time}");
            }
    }
}
