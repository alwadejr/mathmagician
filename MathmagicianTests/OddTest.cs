using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mathmagician;

namespace MathmagicianTests
{
    [TestClass]
    public class OddTest
    {
        [TestMethod]
        public void OddEnsuerICanCreateClassInstance()
        {
            OddNumbers odd = new OddNumbers();
            Assert.IsNotNull(odd);
        }

        [TestMethod]
        public void OddShouldPrintFirstNumber()
        {
            OddNumbers odd = new OddNumbers();
            int expected = 1;
            int actual = odd.GetFirst();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OddShouldPrintNextNumber()
        {
            OddNumbers odd = new OddNumbers();
            int input = 1;
            int expected = 3;
            int actual = odd.GetNext(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OddPrintOfSequenceOfNumbers()
        {
            OddNumbers odd = new OddNumbers();
            int length = 8;
            string expected = "1 3 5 7 9 11 13 15";
            string actual = odd.ToString(odd.GetSequence(length));
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OddShouldPrintAVariableSequenceOfNumbers()
        {
            OddNumbers nats = new OddNumbers();
            int input = 8;
            int[] expected = new int[] { 1, 3, 5, 7, 9, 11, 13, 15 };
            int[] actual = nats.GetSequence(input);
            CollectionAssert.AreEqual(expected, actual);

        }
    }
}