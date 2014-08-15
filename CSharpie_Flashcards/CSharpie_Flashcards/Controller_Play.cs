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
            Model_Flashcards fc = new Model_Flashcards();
            var list = fc.PrepRow();

            View_Play viewPlay = new View_Play();
            viewPlay.RenderGame(list);
        }

    }
}
