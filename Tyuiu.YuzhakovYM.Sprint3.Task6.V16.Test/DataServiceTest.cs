using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.YuzhakovYM.Sprint3.Task6.V16.Lib;

namespace Tyuiu.YuzhakovYM.Sprint3.Task6.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();

            int startValue = 5;
            int stopValue = 16;
            int res = ds.GetSumTheDivisors(startValue, stopValue);
            int wait = 42;

            Assert.AreEqual(wait, res);
        }
    }
}
