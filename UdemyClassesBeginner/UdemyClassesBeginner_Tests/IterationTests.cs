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

        [TestCase(5,120)]
        [TestCase(3,6)]
        public void IterationThirdEx_Fractional_ReturnsFractionalOfGivenNumer(int num, int fracResult)
        {
            var thirdEx = new Iteration();
            var result = thirdEx.Fractional(num);
            Assert.That(result, Is.EqualTo(fracResult));
        }
    }
}
