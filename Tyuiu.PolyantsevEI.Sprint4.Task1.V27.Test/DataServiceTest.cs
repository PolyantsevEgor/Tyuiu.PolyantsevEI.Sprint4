using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PolyantsevEI.Sprint4.Task1.V27.Lib;

namespace Tyuiu.PolyantsevEI.Sprint4.Task1.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[] array = new int[] { 8, 1, 4, 4, 1, 2, 3, 5, 1, 5 };
            int wait = 256;
            int res = ds.Calculate(array);
            Assert.AreEqual(wait, res);
        }
    }
}
