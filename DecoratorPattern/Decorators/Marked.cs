using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.DecoratorPattern.Decorators
{
    public class Marked : WordDecorator, IWord
    {
        public Marked(IWord word, string textInput) : base(word, textInput)
        { 
            Description = "The word in marked"; 
        }
     }
}
