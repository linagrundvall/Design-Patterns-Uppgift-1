namespace Design_Patterns_Assignment.StrategyPattern.Messages
{
    internal interface IEmail : IMessage
    {
        void Send(string message);
    }
}