﻿using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ShaldinDA.Sprint6.Task1.V23.Lib
{
    public class DataService : ISprint6Task1V23
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
                y = Math.Round(Math.Sin(i) + (2 * i)/(3.0) - Math.Cos(i) * (4 * i), 2);
                valueArray[count] = y;
                count++;
            }
            return valueArray;
        }
    }
}
