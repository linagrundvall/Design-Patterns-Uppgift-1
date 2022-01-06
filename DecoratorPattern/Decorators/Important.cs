namespace Design_Patterns_Assignment.DecoratorPattern.Decorators
{
    public class Important : WordDecorator, IImportant
    {
        public Important(IWord word, string textInput) : base(word, textInput)
        {
            Description = "The word in important";
            Tag = "<strong>" + textInput + "</strong>";
        }
    }
}
