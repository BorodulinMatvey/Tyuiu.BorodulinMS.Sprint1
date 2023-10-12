using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BorodulinMS.Sprint1.Task3.V12.Lib;

namespace Tyuiu.BorodulinMS.Sprint1.Task3.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 2;
            double b = 2;
            var res = ds.TriangleArea(a, b);
            Assert.AreEqual(2, res);
        }
    }
}
