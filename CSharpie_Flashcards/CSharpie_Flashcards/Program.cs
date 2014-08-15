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

            Console.WriteLine("╒════════════════════════════════╕");
            Console.WriteLine("│                                │");
            Console.WriteLine("│      Welcome to C# Anki        │");
            Console.WriteLine("│                                │");
            Console.WriteLine("│    Press any key to Play Anki  │");
            Console.WriteLine("│    Press Q or q to Quit Anki   │");
            Console.WriteLine("│                                │");
            Console.WriteLine("╘════════════════════════════════╛");
            
            
            do
            {
                choiceMain = Convert.ToString(Console.ReadKey());
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
