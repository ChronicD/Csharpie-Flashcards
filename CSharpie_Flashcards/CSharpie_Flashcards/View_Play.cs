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


            Console.WriteLine("╒═════════════════════════════════════════════════════════════════════════════════════╕");
            Console.WriteLine(" ");
            Console.WriteLine("\t" + question + "\n");
            for (int i = 1; i < testAns.Count; i++)
            {
                Console.WriteLine("\t" + Convert.ToString(i) + ". " + testAns[i]);
            }
            Console.WriteLine(" ");
            Console.WriteLine("      Please select the number that is the correct answer or press Q  to quit.");
            Console.WriteLine(" ");
            Console.WriteLine("╘═════════════════════════════════════════════════════════════════════════════════════╛");


            int answer;
            answer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You entered " + answer);
            Console.ReadKey();
            


            

            


        }
    }
}
