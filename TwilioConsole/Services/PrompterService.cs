using System;
using TwilioConsole.Interfaces;

namespace TwilioConsole.Services
{
    public class PrompterService : IPrompterService
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
