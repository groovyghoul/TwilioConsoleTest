using System;

namespace TwilioConsole
{
    public class Prompter : IPrompter
    {
        public string Prompt(string prompt)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("{0}: ", prompt);
            Console.ForegroundColor = ConsoleColor.White;
            var enteredText = Console.ReadLine();
            return enteredText;
        }
    }
}
