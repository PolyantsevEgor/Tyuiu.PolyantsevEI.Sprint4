using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PolyantsevEI.Sprint4.Task4.V15.Lib;

namespace Tyuiu.PolyantsevEI.Sprint4.Task4.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            Assert.AreEqual(40, ds.Calculate(new int[5, 5] { { 6, 4, 2, 2, 1 }, { 3, 6, 5, 4, 1 }, { 5, 2, 3, 1, 6 }, { 8, 8, 4, 5, 3 }, { 7, 4, 5, 1, 6 } }));
        }
    }
}
