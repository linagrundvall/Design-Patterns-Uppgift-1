using Design_Patterns_Assignment.StrategyPattern.MessageHandlers;
using Design_Patterns_Assignment.StrategyPattern.Messages;
using System;

namespace Design_Patterns_Assignment.StrategyPattern
{
    internal class Strategy : IStrategy
    {
        public IMessageHandler MessageHandler { get; set; }
        public IMessage Email { get; set; }
        public IMessage SMS { get; set; }
        public IMessage FacebookMessage { get; set; }

        public Strategy(IMessageHandler messageHandler, IEmail email, ISMS sms, IFacebookMessage facebookMessage)
        {
            MessageHandler = messageHandler;
            Email = email;
            SMS = sms;
            FacebookMessage = facebookMessage;
        }

        public void Run()
        {
            Console.WriteLine("Strategy");
            Console.WriteLine("Please write your message:");
            var message = Console.ReadLine();

            Console.WriteLine("Select an action");
            Console.WriteLine("1. Send message via Email");
            Console.WriteLine("2. Send message via SMS");
            Console.WriteLine("3. Send message via Facebook Message");

            while (true)
            {
                var userInput = Console.ReadKey(intercept: true).Key;
                switch (userInput)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        MessageHandler.Message = Email;
                        MessageHandler.Send(message);
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        MessageHandler.Message = SMS;
                        MessageHandler.Send(message);
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        MessageHandler.Message = FacebookMessage;
                        MessageHandler.Send(message);
                        break;
                    default:
                        Console.Write("That is not a valid choice");
                        break;
                }
            }
        }
    }
}