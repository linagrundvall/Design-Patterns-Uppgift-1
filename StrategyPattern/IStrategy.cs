using Design_Patterns_Assignment.StrategyPattern.MessageHandlers;
using Design_Patterns_Assignment.StrategyPattern.Messages;

namespace Design_Patterns_Assignment.StrategyPattern
{
    internal interface IStrategy
    {
        IMessageHandler MessageHandler { get; set; }
        IMessage Email { get; set; }
        IMessage SMS { get; set; }
        IMessage FacebookMessage { get; set; }

        void Run();
    }
}