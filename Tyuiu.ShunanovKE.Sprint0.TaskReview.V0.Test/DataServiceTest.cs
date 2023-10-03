using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShunanovKE.Sprint0.TaskReview.V0.Lib;
namespace Tyuiu.ShunanovKE.Sprint0.TaskReview.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalc()
        {
            int x = 5;
            int y = 2;
            int z = 1;

            Assert.AreEqual(DataService.Calc(x, y, z), 40);
        }
    }
}
