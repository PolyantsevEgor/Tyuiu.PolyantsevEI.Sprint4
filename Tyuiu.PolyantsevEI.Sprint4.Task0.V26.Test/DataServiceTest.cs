using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PolyantsevEI.Sprint4.Task0.V26.Lib;

namespace Tyuiu.PolyantsevEI.Sprint4.Task0.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumOddArrEl()
        {
            DataService ds = new DataService();
            int[] array = new int[] { 9, 3, 7, 1, 5, 5, 3, 2, 1, 7 };
            int res = ds.GetSumOddArrEl(array);
            int wait = 41;
            Assert.AreEqual(wait, res);
        }
    }
}
