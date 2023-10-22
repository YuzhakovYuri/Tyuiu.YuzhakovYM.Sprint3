using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.YuzhakovYM.Sprint3.Task3.V27.Lib;

namespace Tyuiu.YuzhakovYM.Sprint3.Task3.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidConvertStringToInt()
        {
            DataService ds = new DataService();
            string value = "!bt, g567kid f!";

            int wait = 567;
            int res = ds.ConvertStringToInt(value);
            Assert.AreEqual(wait, res);
        }
    }
}
