using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.YuzhakovYM.Sprint3.Task5.V27.Lib;

namespace Tyuiu.YuzhakovYM.Sprint3.Task5.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataService ds = new DataService();

            int x = 2;
            int startValue1 = 1;
            int startValue2 = 1;
            int stopValue1 = 3;
            int stopValue2 = 10;

            double wait = -1495.954;
            double res = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);

            Assert.AreEqual(wait, res);
        }
    }
}
