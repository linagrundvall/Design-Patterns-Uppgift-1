namespace Design_Patterns_Assignment.StrategyPattern.Messages
{
    internal interface ISMS : IMessage
    {
        void Send(string message);
    }
}