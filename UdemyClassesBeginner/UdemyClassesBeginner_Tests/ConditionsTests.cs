using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using UdemyClassesBeginner;

namespace UdemyClassesBeginner_Tests
{
    [TestFixture]
    class ConditionsTests
    {
        [Test]
        public void FirstEx_GivenNumberBetweenOneAndTen_ReturnsValid()
        {
            var firstEx = new Conditions();

            var result = firstEx.ValidTest(1);

            Assert.That(result, Does.Contain("Valid"));
        }
        [TestCase(0)]
        [TestCase(11)]
        public void FirstEx_GivenNumberUnderOneAndOverTen_ReturnsValid(int num)
        {
            var firstEx = new Conditions();

            var result = firstEx.ValidTest(num);

            Assert.That(result, Does.Contain("Invalid"));
        }
    }
}
