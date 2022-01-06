using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.DecoratorPattern.Decorators
{
    public class Inserted : WordDecorator, IWord
    {
        public Inserted(IWord word, string textInput) : base(word, textInput)
        {
            Description = "The word in inserted";
        }
    }
}
