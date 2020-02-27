using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing.Tests
{
    [TestClass]
    public class BMITest
    {
        [TestMethod]
        public void TestBMI()
        {
            string name = "John";
            int height = 173;
            int weight = 75;
            Person person = new Testing.Person(name, height, weight);
            int expected = 25;

            int result = (int)person.GetBodyMassIndex(person);

            Assert.AreEqual(expected, result);
        }
    }
}
