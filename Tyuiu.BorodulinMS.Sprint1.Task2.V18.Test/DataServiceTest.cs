using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BorodulinMS.Sprint1.Task2.V18.Lib;

namespace Tyuiu.BorodulinMS.Sprint1.Task2.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int a = 1;
            int b = 2;
            int c = 3;
            var res = ds.CalculateSideSquareParallelepiped(a, b, c);
            Assert.AreEqual(18, res);
        }
    }
}
