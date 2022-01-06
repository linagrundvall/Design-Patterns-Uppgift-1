using Design_Patterns_Assignment.StrategyPattern.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.StrategyPattern.MessageHandlers
{
    interface IMessageHandler
    {
        IMessage Message { get; set; }
        void Send(string message);
    }
}
