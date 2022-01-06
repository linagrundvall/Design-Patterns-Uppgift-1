using System;
using Design_Patterns_Assignment.DecoratorPattern.Decorators;

namespace Design_Patterns_Assignment.DecoratorPattern
{
    internal class Decorator : IDecorator
    {
        public IWord Word { get; set; }

        public Decorator(IRegularWord regularWord)
        {
            Word = regularWord;
        }

        public void Run()
        {
            var newWord = Word;

            Console.WriteLine("Decorator");
            Console.WriteLine("Please enter the text that you want decorated");
            string textInput = Console.ReadLine();
            
            Console.WriteLine();
            Console.WriteLine("Bold");
            Console.WriteLine("Deleted");
            Console.WriteLine("Emphasized");
            Console.WriteLine("Important");
            Console.WriteLine("Inserted");
            Console.WriteLine("Italic");
            Console.WriteLine("Marked");
            Console.WriteLine("Smaller");
            Console.WriteLine("SubScript");
            Console.WriteLine("SuperScript");
            Console.WriteLine();
            Console.WriteLine("Type the tags you want separated by space");
            Console.WriteLine("Type Done when you are done");

            while (true)
            {
                var userInput = Console.ReadLine().ToLower();
                var splitUserInput = userInput.Split(" ");

                foreach (var input in splitUserInput)
                {
                    switch (input)
                    {
                        case "bold":
                            Word = new Bold(Word, textInput);
                            break;
                        case "deleted":
                            Word = new Deleted(Word, textInput);
                            break;
                        case "emphasized":
                            Word = new Emphasized(Word, textInput);
                            break;
                        case "important":
                            Word = new Important(Word, textInput);
                            break;
                        case "inserted":
                            Word = new Inserted(Word, textInput);
                            break;
                        case "italic":
                            Word = new Italic(Word, textInput);
                            break;
                        case "marked":
                            Word = new Marked(Word, textInput);
                            break;
                        case "smaller":
                            Word = new Smaller(Word, textInput);
                            break;
                        case "subscript":
                            Word = new SubScript(Word, textInput);
                            break;
                        case "superscript":
                            Word = new SuperScript(Word, textInput);
                            break;
                        case "done":
                            Console.WriteLine($"Your chosen tags are: \n{ Word.GetTag()}");
                            Word = newWord;
                            break;
                        default:
                            Console.Write("That is not a valid choice");
                            break;
                    }
                }
            }
        }
    }
}