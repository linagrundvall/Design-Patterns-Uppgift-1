using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.StrategyPattern.Messages
{
    internal class Email : IMessage, IEmail
    {
        public void Send(string message)
        {
            Console.WriteLine($"sending \"{message}\" as an email");
        }
    }
}
