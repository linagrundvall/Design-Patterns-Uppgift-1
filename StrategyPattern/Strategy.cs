using Design_Patterns_Assignment.StrategyPattern.MessageHandlers;
using Design_Patterns_Assignment.StrategyPattern.Messages;
using System;

namespace Design_Patterns_Assignment.StrategyPattern
{
    internal class Strategy
    {
        public static IMessageHandler MessageHandler { get; set; }
        public static IMessage Email { get; set; }
        public static IMessage SMS { get; set; }
        public static IMessage FacebookMessage { get; set; }

        public Strategy(IMessageHandler messageHandler, IMessage email, IMessage sms, IMessage facebookMessage)
        {
            MessageHandler = messageHandler;
            Email = email;
            SMS = sms;
            FacebookMessage = facebookMessage;
        }

        internal static void Run()
        {
            // Refactor this code so that it uses the strategy Pattern
            Console.WriteLine("Strategy");
            var message = "This is the message";

            Console.WriteLine("Select an action");
            Console.WriteLine("1. Send message");
            Console.WriteLine("2. Via Email");
            Console.WriteLine("3. Via SMS");
            Console.WriteLine("4. Via Facebook Message");

            while (true)
            {
                var userInput = Console.ReadKey(intercept: true).Key;
                switch (userInput)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        Console.WriteLine("Sending message");
                        MessageHandler.Send(message);
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        Console.WriteLine("Sending via Email");
                        MessageHandler.Message = Email;
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        Console.WriteLine("Sending via SMS");
                        MessageHandler.Message = SMS;
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        Console.WriteLine("Sending via Facebook Message");
                        MessageHandler.Message = FacebookMessage;
                        break;
                    default:
                        Console.Write("That is not a valid choice");
                        break;
                }

            }

            //MessageHandler.SendEmail(message);
            //MessageHandler.SendSMS(message);
            //MessageHandler.SendFacebookMessage(message);

            // What i want to happen to happen is
            //
            // Change type of message to send to sms etc.
            // send message            
        }
    }
}