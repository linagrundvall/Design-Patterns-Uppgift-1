using Design_Patterns_Assignment;

using System;
using Design_Patterns_Assignment.DecoratorPattern.Decorators;
using Design_Patterns_Assignment.DecoratorPattern;

namespace Design_Patterns_Assignment.DecoratorPattern
{
    internal class Decorator : IDecorator
    {
        public static IWord Word { get; set; }

        public Decorator(IRegularWord regularWord)
        {
            Word = regularWord;
        }

        internal static void Run()
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

                switch (userInput)
                {
                    case "bold":
                        Console.WriteLine("Bold");
                        Word = new Bold(Word, textInput);
                        break;
                    case "deleted":
                        Console.WriteLine("The word in Deleted");
                        Word = new Deleted(Word, textInput);
                        break;
                    case "emphasized":
                        Console.WriteLine("The word in Emphasized");
                        Word = new Emphasized(Word, textInput);
                        break;
                    case "important":
                        Console.WriteLine("The word in Important");
                        Word = new Important(Word, textInput);
                        break;
                    case "inserted":
                        Console.WriteLine("The word in Inserted");
                        Word = new Inserted(Word, textInput);
                        break;
                    case "italic":
                        Console.WriteLine("The word in Italic");
                        Word = new Italic(Word, textInput);
                        break;
                    case "marked":
                        Console.WriteLine("The word in Marked");
                        Word = new Marked(Word, textInput);
                        break;
                    case "smaller":
                        Console.WriteLine("The word in Smaller");
                        Word = new Smaller(Word, textInput);
                        break;
                    case "subScript":
                        Console.WriteLine("The word in SubScript");
                        Word = new SubScript(Word, textInput);
                        break;
                    case "superScript":
                        Console.WriteLine("The word in SuperScript");
                        Word = new SuperScript(Word, textInput);
                        break;
                    case "done":
                        Console.WriteLine($"Your chosen tags are: + {Word.GetTag()}");
                        Word = newWord;
                        break;
                    default:
                        Console.Write("That is not a valid choice");
                        break;
                }

            //string tagSelection = Console.ReadLine();
            //string result = HTMLGenerator.TagProcessor(tagSelection, textInput);
            //Console.WriteLine(result);
            //Console.WriteLine();

            }
        }
    }
}