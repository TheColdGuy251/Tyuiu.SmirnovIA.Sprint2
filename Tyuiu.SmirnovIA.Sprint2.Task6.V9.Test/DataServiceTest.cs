using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SmirnovIA.Sprint2.Task6.V9.Lib;

namespace Tyuiu.SmirnovIA.Sprint2.Task6.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            Assert.AreEqual("4 Января", ds.FindDateOfNextDay(1, 3));
            Assert.AreEqual("14 Февраля", ds.FindDateOfNextDay(2, 13));
            Assert.AreEqual("6 Марта", ds.FindDateOfNextDay(3, 5));
            Assert.AreEqual("26 Апреля", ds.FindDateOfNextDay(4, 25));
            Assert.AreEqual("2 Мая", ds.FindDateOfNextDay(5, 1));
            Assert.AreEqual("30 Июня", ds.FindDateOfNextDay(6, 29));
            Assert.AreEqual("7 Июля", ds.FindDateOfNextDay(7, 6));
            Assert.AreEqual("10 Августа", ds.FindDateOfNextDay(8, 9));
            Assert.AreEqual("28 Сентября", ds.FindDateOfNextDay(9, 27));
            Assert.AreEqual("14 Октября", ds.FindDateOfNextDay(10, 13));
            Assert.AreEqual("12 Ноября", ds.FindDateOfNextDay(11, 11));
            Assert.AreEqual("6 Декабря", ds.FindDateOfNextDay(12, 5));

            Assert.ThrowsException<ArgumentException>(() => ds.FindDateOfNextDay(13, 3));
            Assert.ThrowsException<ArgumentException>(() => ds.FindDateOfNextDay(5, 31));
        }
    }
}
