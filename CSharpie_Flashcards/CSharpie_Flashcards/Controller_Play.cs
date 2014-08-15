using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpie_Flashcards
{
    class Controller_Play
    {
        public void Game()
        {
            //Model_Play playGame = new Model_Play();
            //playGame.Game();

            View_Play viewPlay = new View_Play();
            viewPlay.RenderGame();
        }

    }
}
