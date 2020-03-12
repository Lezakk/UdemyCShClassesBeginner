using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using UdemyClassesBeginner;

namespace UdemyClassesBeginner_Tests
{
    [TestFixture]
    class IterationTests
    {
        [TestCase(10,3)]
        [TestCase(100, 33)]
        public void IterationFirstEx_CountHowManyNumbersWithoutRemainerInRange_ReturnsNumer(int range, int resultNum)
        {
            var firstEx = new Iteration();
            var result = firstEx.HowManyNumbersBetween(range);
            Assert.That(result, Is.EqualTo(resultNum));
        }
    }
}
