using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpie_Flashcards
{
    class View_Play
    {
        

        public void RenderGame()
        {
            
            List<string> testAns = new List<string>();

            testAns.Add("Question");
            testAns.Add("ans1");
            testAns.Add("ans2");
            testAns.Add("ans3");

            string question = testAns[0];

            Console.Clear();
            Console.WriteLine(question);


            for (int i = 1; i < testAns.Count; i++)
            {
                Console.WriteLine(Convert.ToString(i)+". "+ testAns[i]);
            }

            Console.WriteLine("Please select the number that is the correct answer or press Q  to quit.");


        }
    }
}
