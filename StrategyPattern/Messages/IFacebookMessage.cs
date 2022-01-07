namespace Design_Patterns_Assignment.StrategyPattern.Messages
{
    internal interface IFacebookMessage : IMessage
    {
        void Send(string message);
    }
}