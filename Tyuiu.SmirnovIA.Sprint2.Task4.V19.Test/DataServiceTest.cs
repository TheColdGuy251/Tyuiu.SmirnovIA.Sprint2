﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SmirnovIA.Sprint2.Task4.V19.Lib;

namespace Tyuiu.SmirnovIA.Sprint2.Task4.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 8;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(6.062, res);
        }
    }
}
