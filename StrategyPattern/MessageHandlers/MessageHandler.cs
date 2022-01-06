using Design_Patterns_Assignment.StrategyPattern.Messages;
using System;

namespace Design_Patterns_Assignment.StrategyPattern.MessageHandlers
{
    internal class MessageHandler
    {
        public IMessage Message { get; set; }
        public void Send(string message)
        {
            Message.Send(message);
        }

        //internal static void SendEmail(string message)
        //{
        //    Console.WriteLine($"sending \"{message}\" as an email");
        //}

        //internal static void SendSMS(string message)
        //{
        //    Console.WriteLine($"sending \"{message}\" as a sms");
        //}

        //internal static void SendFacebookMessage(string message)
        //{
        //    Console.WriteLine($"sending \"{message}\" as a facebookmessage");
        //}
    }
}