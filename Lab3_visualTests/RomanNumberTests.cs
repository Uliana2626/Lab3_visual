using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab3_visual;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_visual.Tests
{
    [TestClass()]
    public class RomanNumberTests
    {
        [TestMethod()]
        public void RomanNumberTest1()
        {
            RomanNumber a;
            Assert.ThrowsException<RomanNumberException>(()=>a = new(0));
        }

        [TestMethod()]
        public void RomanNumberTest2()
        {
            RomanNumber a;
            Assert.ThrowsException<RomanNumberException>(() => a = new(5000));
        }

        [TestMethod()]
        public void RomanNumberTestSum()
        {
            RomanNumber a = new(1);
            RomanNumber b = new(1);
            RomanNumber expect = new(2);
            Assert.AreEqual(expect.ToString(), (a + b).ToString());
        }

        [TestMethod()]
        public void RomanNumberTestSum1()
        {
            RomanNumber a = new(3999);
            RomanNumber b = new(1000);
            Assert.ThrowsException<RomanNumberException>(() => a + b);
        }

        [TestMethod()]
        public void RomanNumberTestSub()
        {
            RomanNumber a = new(1001);
            RomanNumber b = new(1);
            RomanNumber expect = new(1000);
            Assert.AreEqual(expect.ToString(), (a - b).ToString());
        }

        [TestMethod()]
        public void RomanNumberTestSub1()
        {
            RomanNumber a = new(1001);
            RomanNumber b = new(1);
            Assert.ThrowsException<RomanNumberException>(() => b - a);
        }

        [TestMethod()]
        public void RomanNumberTestMul()
        {
            RomanNumber a = new(54);
            RomanNumber b = new(1);
            RomanNumber expect = new(54);
            Assert.AreEqual(expect.ToString(), (a * b).ToString());
        }

        [TestMethod()]
        public void RomanNumberTestMul1()
        {
            RomanNumber a = new(54);
            RomanNumber b = new(165);
            Assert.ThrowsException<RomanNumberException>(() => a * b);
        }

        [TestMethod()]
        public void RomanNumberTestDiv()
        {
            RomanNumber a = new(554);
            RomanNumber b = new(2);
            RomanNumber expect = new(277);
            Assert.AreEqual(expect.ToString(), (a / b).ToString());
        }

        [TestMethod()]
        public void RomanNumberTestDiv1()
        {
            RomanNumber a = new(23);
            RomanNumber b = new(548);
            Assert.ThrowsException<RomanNumberException>(() => a / b);
        }

        [TestMethod()]
        public void ToStringTest()
        {
            RomanNumber a = new(6);
            String expect = "VI";
            Assert.AreEqual(a.ToString(), expect);
        }

        [TestMethod()]
        public void CloneTest()
        {
            RomanNumber a = new(6);
            Assert.AreEqual(a.ToString(), a.Clone().ToString());
        }

        [TestMethod()]
        public void CompareToTest()
        {
            RomanNumber a = new(2223);
            RomanNumber b = new(548);
            Assert.IsTrue(a.CompareTo(b) > 0);
        }
    }
}