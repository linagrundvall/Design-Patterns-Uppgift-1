using System;

namespace Design_Patterns_Assignment.StrategyPattern.Messages
{
    internal class FacebookMessage : IFacebookMessage
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending \"{message}\" as a facebookmessage.");
        }
    }
}
