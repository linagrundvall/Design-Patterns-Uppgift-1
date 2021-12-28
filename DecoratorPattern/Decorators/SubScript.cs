using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.DecoratorPattern.Decorators
{
    public class SubScript : WordDecorator, IWord
    {
        public SubScript(IWord word) : base(word) 
        { 
            Description = "The word in SubScript"; 
        }
     }
}
