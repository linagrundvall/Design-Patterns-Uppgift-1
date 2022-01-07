using Design_Patterns_Assignment.StrategyPattern.Messages;

namespace Design_Patterns_Assignment.StrategyPattern.MessageHandlers
{
    internal interface IMessageHandler
    {
        IMessage Message { get; set; }
        void Send(string message);
    }
}