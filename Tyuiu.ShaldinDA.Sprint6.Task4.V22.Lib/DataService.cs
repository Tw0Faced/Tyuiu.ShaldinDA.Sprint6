using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ShaldinDA.Sprint6.Task4.V22.Lib
{
    public class DataService : ISprint6Task4V22
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                y = Math.Round(Math.Sin(i) + (Math.Cos(2 * i))/(2) - 1.5 * i, 2);
                valueArray[count] = y;
                count++;
            }
            return valueArray;
        }
    }
}
