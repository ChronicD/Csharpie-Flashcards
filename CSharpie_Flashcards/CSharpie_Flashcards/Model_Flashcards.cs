using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpie_Flashcards
{
    public class Model_Flashcards
    {
        public string CorrectAnswer = String.Empty;
        List<string> StoringQuestion = new List<string>();
        public void PrepData()
        {
            //DatabaseQuestions Read = new DatabaseQuestions;
            string OneQuestion = Read.load();

            //DL - when refactoring change this to a linq expression
            string[] words = OneQuestion.Split(',');
            CorrectAnswer = words[0];

            for (int i = 1; i < words.Length; i++)
            {
                StoringQuestion.Add(words[i].Replace("\"", String.Empty).Trim(' '));
            }
        }

        public bool Compare(string answer)
        {
            if (answer == CorrectAnswer)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }

}
