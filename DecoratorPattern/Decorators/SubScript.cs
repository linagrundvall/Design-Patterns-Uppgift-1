namespace Design_Patterns_Assignment.DecoratorPattern.Decorators
{
    public class SubScript : WordDecorator, ISubScript
    {
        public SubScript(IWord word, string textInput) : base(word, textInput)
        { 
            Description = "The word in SubScript"; 
            Tag = "<sub>" + textInput + "</sub>";
        }
     }
}
