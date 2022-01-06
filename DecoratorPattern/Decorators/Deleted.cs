namespace Design_Patterns_Assignment.DecoratorPattern.Decorators
{
    internal class Deleted : WordDecorator, IDeleted
    {
        public Deleted(IWord word, string textInput) : base(word, textInput)
        {
            Description = "The word in deleted";
            Tag = "<del>" + textInput + "</del>";
        }
    }
}
