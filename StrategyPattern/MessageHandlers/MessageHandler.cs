using Design_Patterns_Assignment.StrategyPattern.Messages;

namespace Design_Patterns_Assignment.StrategyPattern.MessageHandlers
{
    internal class MessageHandler : IMessageHandler
    {
        public IMessage Message { get; set; }
        public void Send(string message)
        {
            Message.Send(message);
        }
    }
}