using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSharpie_Flashcards
{
    class DatabaseManager
    {
        public List<string> dataFromCSV = new List<string>();
        public DatabaseManager()
        {
            using (StreamReader reader = File.OpenText("CS_Flashcards_data.csv"))
            {
                List<string> lines = new List<string>();
                var aLine = String.Empty;
                while ((aLine = reader.ReadLine()) != null)
                {
                    lines.Add(aLine);
                }
                dataFromCSV = lines;
            }


        }
        //public void Save(List<string>)
        //{
        //    using (StreamWriter writer = File.AppendText("todo.csv"))
        //    {
        //        writer.WriteLine(line);
        //    }
        //}

        //internal static void Delete(int indexNum)
        //{
        //    throw new NotImplementedException();
        //}

        //public List<string> Load(int indexNum)
        //{

        //}

        public string Print(int indexNum)
        {
            try
            {
                return dataFromCSV[indexNum];
            }
            catch (Exception)
            {

                return "No data at this address in the database";
            }

        }


        internal void Delete(int indexNum)
        {
            dataFromCSV.RemoveAt(indexNum);
        }
    }
}
