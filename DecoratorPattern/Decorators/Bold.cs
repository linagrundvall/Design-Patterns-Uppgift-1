using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.DecoratorPattern.Decorators
{
    internal class Bold : WordDecorator, IWord
    {
        public Bold(IWord word) : base(word)
        {
            Description = "bold";

            //textInput = "<b>" + textInput + "</b>";
        }


    }
}
