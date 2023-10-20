using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.YuzhakovYM.Sprint3.Task0.V29.Lib
{
    public class DataService : ISprint3Task0V29
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sum = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                double term = Math.Pow(value, i * 2) + 1.0 / (i + 1);
                sum += term * Math.Cos(value);
            }
            return Math.Round(sum, 3);

        }
    }
}
