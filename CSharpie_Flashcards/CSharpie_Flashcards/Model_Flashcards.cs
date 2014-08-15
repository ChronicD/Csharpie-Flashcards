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
        DatabaseManager db = new DatabaseManager();
        List<string> allQuestions = new List<string>();

        public Model_Flashcards()
        {
            allQuestions = db.Load();
        }

        public List<string> PrepRow()
        {
            string oneRow = allQuestions[0];
            allQuestions.RemoveAt(0);

            //DL - when refactoring change this to a linq expression
            string[] words = oneRow.Split(',');
            CorrectAnswer = words[0];

            for (int i = 1; i < words.Length; i++)
            {
                StoringQuestion.Add(words[i].Replace("\"", String.Empty).Trim(' '));
            }
            return StoringQuestion;
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
