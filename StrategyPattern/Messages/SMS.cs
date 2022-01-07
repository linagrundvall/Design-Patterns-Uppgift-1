using System;

namespace Design_Patterns_Assignment.StrategyPattern.Messages
{
    internal class SMS : ISMS
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending \"{message}\" as a sms.");
        }
    }
}