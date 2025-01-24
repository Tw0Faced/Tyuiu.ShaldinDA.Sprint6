using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ShaldinDA.Sprint6.Task7.V12.Lib
{
    public class DataService : ISprint6Task7V12
    {
        public int[,] GetMatrix(string path)
        {
            string[] lines = File.ReadAllLines(path);
            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;
            int[,] result = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] values = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    result[i, j] = int.Parse(values[j]);
                    if (j == 8 && result[i, j] != 10)
                    {
                        result[i, j] = 0;
                    }
                }
            }

            return result;
        }

    }
}
