using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PolyantsevEI.Sprint4.Task7.V18.Lib;

namespace Tyuiu.PolyantsevEI.Sprint4.Task7.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            string str = "145258749635789";
            int[,] res = { { 1, 4, 5, 2, 5, }, { 8, 7, 4, 9, 6, }, { 3, 5, 7, 8, 9, } };
            Assert.AreEqual(ds.Calculate(3, 5, str), 12288);
        }
    }
}
