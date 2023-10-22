using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.YuzhakovYM.Sprint3.Task1.V9.Lib
{
    public class DataService : ISprint3Task1V9
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double multiSeries = 1;
            while (startValue <= stopValue)
            {
                multiSeries *= Math.Pow((300 / (Math.Cos(value) + Math.Pow(value, startValue))), startValue);
                startValue++;
            }
            return Math.Round(multiSeries, 3);
        }
    }
}
