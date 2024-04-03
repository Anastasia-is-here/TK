using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TK;
namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod()
        {
            MainWindow window = new MainWindow();

            Assert.AreEqual(window.mark("1", "2", "3"), "2\n(неудовлетворительно)");
            Assert.AreEqual(window.mark("10", "10", "2"), "3\n(удовлетворительно)");
            Assert.AreEqual(window.mark("20", "10", "12"), "4\n(хорошо)");
            Assert.AreEqual(window.mark("22", "38", "20"),  "5\n(отлично)");

            Assert.AreEqual(window.mark("-1", "1", "1"), "ошибка");
            Assert.AreEqual(window.mark("1", "-1", "1"), "ошибка");
            Assert.AreEqual(window.mark("1", "1", "-1"), "ошибка");

            Assert.AreEqual(window.mark("", "", ""), "ошибка");
            Assert.AreEqual(window.mark("", "1", "1"), "ошибка");
            Assert.AreEqual(window.mark("1", "", "1"), "ошибка");
            Assert.AreEqual(window.mark("1", "1", ""), "ошибка");

            Assert.AreEqual(window.mark("99", "1", "1"), "ошибка");
            Assert.AreEqual(window.mark("1", "99", "1"), "ошибка");
            Assert.AreEqual(window.mark("1", "1", "99"), "ошибка");

            Assert.AreEqual(window.mark("один", "1", "1"), "ошибка");
            Assert.AreEqual(window.mark("1", "два", "1"), "ошибка");
            Assert.AreEqual(window.mark("1", "1", "три"), "ошибка");
        }
    }
}
