using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.StrategyPattern.Messages
{
    internal interface IMessage
    {
        public void Send(string message);
    }
}
