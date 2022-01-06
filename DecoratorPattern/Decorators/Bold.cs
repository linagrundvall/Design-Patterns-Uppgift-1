using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.DecoratorPattern.Decorators
{
    internal class Bold : WordDecorator, IBold
    {
        public Bold(IWord word, string textInput) : base(word, textInput)
        {       
            Description = "bold";
            Tag = "<b>" + textInput + "</b>";
        }
    }
}
