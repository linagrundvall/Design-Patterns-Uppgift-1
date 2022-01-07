using Design_Patterns_Assignment.StrategyPattern.Messages;
using System;

namespace Design_Patterns_Assignment.StrategyPattern.MessageHandlers
{
    internal class MessageHandler : IMessageHandler
    {
        public IMessage Message { get; set; }
        //public IMessage Email { get; set; }
        //public IMessage SMS { get; set; }
        //public IMessage FacebookMessage { get; set; }
        public void Send(string message)
        {
            Message.Send(message);
        }
    }
}