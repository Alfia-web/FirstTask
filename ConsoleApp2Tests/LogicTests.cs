using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp2.Program;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Program.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void ReallyHappy()
        {
            int number = 123060;
            string message = Logic.HappyOrNot(number);

            Assert.AreEqual("The number " + number + " is happy!", message);
        }

        [TestMethod()]
        public void NotHappy()
        {
            int number = 123064;
            string message = Logic.HappyOrNot(number);

            Assert.AreEqual("The number " + number + " is not happy!", message);
        }

        [TestMethod()]
        public void NeverHappy1()
        {
            int number = 1;
            string message = Logic.HappyOrNot(number);

            Assert.AreEqual("The number " + number + " will never be happy :(!", message);
        }

        [TestMethod()]
        public void NeverHappy12()
        {
            int number = 12;
            string message = Logic.HappyOrNot(number);

            Assert.AreEqual("The number " + number + " will never be happy :(!", message);
        }

        [TestMethod()]
        public void NeverHappy123()
        {
            int number = 123;
            string message = Logic.HappyOrNot(number);

            Assert.AreEqual("The number " + number + " will never be happy :(!", message);
        }

        [TestMethod()]
        public void NeverHappy1234()
        {
            int number = 1234;
            string message = Logic.HappyOrNot(number);

            Assert.AreEqual("The number " + number + " will never be happy :(!", message);
        }

        [TestMethod()]
        public void NeverHappy12345()
        {
            int number = 12345;
            string message = Logic.HappyOrNot(number);

            Assert.AreEqual("The number " + number + " will never be happy :(!", message);
        }

        [TestMethod()]
        public void NeverHappy1234567()
        {
            int number = 1234567;
            string message = Logic.HappyOrNot(number);

            Assert.AreEqual("The number " + number + " will never be happy :(!", message);
        }

        [TestMethod()]
        public void Negative()
        {
            int number = -123456;
            string message = Logic.HappyOrNot(number);

            Assert.AreEqual("The number " + number + " will never be happy :(!", message);
        }
    }
}