using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SmirnovIA.Sprint2.Task7.V8.Lib;

namespace Tyuiu.SmirnovIA.Sprint2.Task7.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 5;
            double  y = 4;
            var res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(true, res);

        }
    }
}
