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
            //MessageHandler.Message = Email;
        }

        public void Run()
        {
            Console.WriteLine("Strategy");
            Console.WriteLine("Please write your message:");
            //var message = Console.ReadLine();
            var message = "Hej";

            Console.WriteLine("Select an action");
            Console.WriteLine("1. Send message via Email");
            Console.WriteLine("2. Send message via SMS");
            Console.WriteLine("3. Send message via Facebook Message");

            while (true)
            {
                var userInput = Console.ReadKey(intercept: true).Key;
                switch (userInput)
                {
                    //case ConsoleKey.D1:
                    //case ConsoleKey.NumPad1:
                    //    Console.WriteLine("Sending message");
                    //    MessageHandler.Send(message);
                    //    break;
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        Console.WriteLine("Sending message via Email");
                        MessageHandler.Message = Email;
                        MessageHandler.Send(message);
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        Console.WriteLine("Sending message via SMS");
                        MessageHandler.Message = SMS;
                        MessageHandler.Send(message);
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        Console.WriteLine("Sending message via Facebook Message");
                        MessageHandler.Message = FacebookMessage;
                        MessageHandler.Send(message);
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