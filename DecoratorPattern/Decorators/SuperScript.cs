using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.DecoratorPattern.Decorators
{
    public class SuperScript : WordDecorator, ISuperScript
    {
        public SuperScript(IWord word, string textInput) : base(word, textInput)
        {
            Description = "The word in SuperScript";
            Tag = "<sup>" + textInput + "</sup>";
        }
    }
}
