using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.ObserverPattern
{
    class EmailWatcher
    {
        internal static void Run()
        {

            // Refactor this code so that it uses the Observer Pattern
            Console.WriteLine("Observer");
            var email = "";
            while (string.IsNullOrEmpty(email))
            {
                email=Email.Check();
            }            
            Console.WriteLine(email);
            Console.WriteLine();
        }
            void Update(DateTime time)
            {
                Console.WriteLine($"The current time is {time}");
            }
    }
}
