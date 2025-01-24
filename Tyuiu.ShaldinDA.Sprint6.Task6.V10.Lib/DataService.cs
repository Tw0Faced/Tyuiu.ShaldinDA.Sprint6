using System.Text;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ShaldinDA.Sprint6.Task6.V10.Lib
{
    public class DataService : ISprint6Task6V10
    {
        public string CollectTextFromFile(string path)
        {
            Console.WriteLine(path);
            string[] lines = File.ReadAllLines(path);
            StringBuilder result = new StringBuilder();
            foreach (string line in lines)
            {
                string[] words = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                foreach (string word in words)
                {
                    if (word.Contains("w"))
                    {
                        result.Append(word + " ");
                    }
                }
            }

            return result.ToString().Trim();
        }

    }
}
