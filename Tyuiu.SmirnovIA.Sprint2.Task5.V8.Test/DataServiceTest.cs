using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SmirnovIA.Sprint2.Task5.V8.Lib;

namespace Tyuiu.SmirnovIA.Sprint2.Task5.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int m = 2;
            int n = 15;
            var res = ds.FindDateOfPreviousDay(m, n);
            Assert.AreEqual(14, res);
        }
    }
}
