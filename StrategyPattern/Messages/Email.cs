using System;

namespace Design_Patterns_Assignment.StrategyPattern.Messages
{
    internal class Email : IEmail, IMessage
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending \"{message}\" as an email.");
        }
    }
}
