using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PolyantsevEI.Sprint4.Task3.V17.Lib;

namespace Tyuiu.PolyantsevEI.Sprint4.Task3.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Valid()
        {
            DataService ds = new DataService();
            int[,] arr = new int[5, 5] { { 6, 4, 2, 2, 1 }, { 3, 6, 5, 4, 1 }, { 5, 2, 3, 1, 6 }, { 8, 8, 4, 5, 3 }, { 7, 4, 5, 1, 6 } };
            int wait = 13;
            int res = ds.Calculate(arr);
            Assert.AreEqual(wait, res);
        }
    }
}
