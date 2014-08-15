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
            List<string> exampleDataToView = new List<string>();
            //{ "What is the ground speed of a migrating Swallow", "A", "African or European?", "That's easy, it's blue", "Brave Sir Robin" }
            string[] blah = new string[] { "What is the ground speed of a migrating Swallow", "A", "African or European?", "That's easy, it's blue", "Brave Sir Robin" };
            exampleDataToView.AddRange(blah);
            
            Console.WriteLine(exampleDataToView);
		}


	}
}
