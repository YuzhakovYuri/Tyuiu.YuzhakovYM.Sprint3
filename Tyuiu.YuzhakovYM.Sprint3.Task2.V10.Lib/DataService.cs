using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.YuzhakovYM.Sprint3.Task2.V10.Lib
{
    public class DataService : ISprint3Task2V10
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double multiSeries = 1.0;
            do
            {
                multiSeries *= Math.Pow(value, startValue) + 1.0 / (startValue + 1.0);
                startValue++;
            } while (startValue <= stopValue);
            return Math.Round(multiSeries,3);
        }
    }
}
