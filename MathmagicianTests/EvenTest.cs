using System;
using Mathmagician;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathmagicianTests
{
    [TestClass]
    public class EvenTest
    {
        [TestMethod]
        public void EnsureICanCreateClassInstance()
        {
            EvenNumbers even = EvenNumbers();
            Assert.IsNotNull(even);

        }


    }
}
