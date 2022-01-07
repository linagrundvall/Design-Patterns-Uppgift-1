using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.StrategyPattern.Messages
{
    internal class Email : IEmail, IMessage
    {
        public void Send(string message)
        {
            Console.WriteLine($"sending \"{message}\" as an email");
        }

        //internal static void SendEmail(string message)
        //{
        //    Console.WriteLine($"sending \"{message}\" as an email");
        //}
    }
}
