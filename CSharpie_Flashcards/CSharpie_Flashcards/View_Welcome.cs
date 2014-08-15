using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpie_Flashcards
{
    class View_Welcome
    {
        public bool quit = false;
        public void WelcomePage()
        {
             bool quit = false;
            string choiceMain;
            Console.WriteLine("Welcome to C# Anki\n");

            Console.WriteLine("Press P or p to Play Anki");
            Console.WriteLine("Press Q or q to Quit Anki");

            do
            {

                choiceMain = Console.ReadLine();
                Console.WriteLine("You entered " + choiceMain);


                if (choiceMain == "Q" || choiceMain == "q")
                {
                    quit = false;
                }
                
            } while (quit == true);

        }
    }
}
