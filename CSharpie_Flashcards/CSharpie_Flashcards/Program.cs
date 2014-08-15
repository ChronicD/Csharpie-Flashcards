using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpie_Flashcards
{
	class Program
	{
        static void Main(string[] args)
        {
            bool quit = false;
            string choiceMain;
            Console.WriteLine("Welcome to C# Anki\n");

            Console.WriteLine("Press any key to Play Anki");
            Console.WriteLine("Press Q or q to Quit Anki");

            do
            {
                choiceMain = Console.ReadLine();
                //Console.WriteLine("You entered " + choiceMain);
                if (choiceMain == "Q" || choiceMain == "q")
                {
                    quit = false;
                }
                else
                {
                    Controller_Play playgame = new Controller_Play();
                    playgame.Game();
                }

            } while (quit == true);
        }
	}
}
