﻿using System;
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

        [TestCase(3,2)]
        [TestCase(3, 3)]
        public void SecondEx_FirstNumberIsBiggerOrEqual_ReturnsFirstNumber(int firstNumber, int secondNumber)
        {
            var secEx = new Conditions();

            var result = secEx.WhitchIsBigger(firstNumber, secondNumber);

            Assert.That(result, Is.EqualTo(firstNumber));
        }
        [TestCase(1,2)]
        public void SecondEx_SecondNumberIsBigger_ReturnsSecondNumber(int firstNumber, int secondNumber)
        {
            var secEx = new Conditions();

            var result = secEx.WhitchIsBigger(firstNumber, secondNumber);

            Assert.That(result, Is.EqualTo(secondNumber));
        }
        [Test]
        public void ThirdEx_HightIsBiggerThanWidth_RetunPortrait()
        {
            var thirdEx = new Conditions();
            var result = thirdEx.LandscapeOrPortrait(20,10);
            Assert.That(result, Does.Contain("Portrait"));
        }
        [Test]
        public void ThirdEx_HightIsLowerThanWidth_RetunLandscape()
        {
            var thirdEx = new Conditions();
            var result = thirdEx.LandscapeOrPortrait(5, 10);
            Assert.That(result, Does.Contain("Landscape"));
        }

        [Test]
        public void HowManyPoints_GivenNumberIsGreaterThanZero_ReturnsNumberOfPoints()
        {
            var result = Conditions.HowManyPoints(40);
            Assert.That(result, Is.EqualTo(8));
        }

        [TestCase(0)]
        [TestCase(-4)]
        public void HowManyPoints_GivenNumberIsLessOrEqualZero_ReturnsZero(int number) 
        {
            var result = Conditions.HowManyPoints(number);
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void FourthEx_VelocityUnderSpeedLimit_ResultOk()
        {
            var fourthEx = new Conditions();
            var result = fourthEx.WhatsWrongPoliceman(50, 40);
            Assert.That(result, Does.Contain("Ok"));
        }

        [Test]
        public void FourthEx_VelocityOverSpeedLimitAndPointUnderTwelve_ResultPoint()
        {
            var fourthEx = new Conditions();
            var result = fourthEx.WhatsWrongPoliceman(50, 60);
            Assert.That(result, Does.Contain("2"));
        }
        [Test]
        public void FourthEx_VelocityOverSpeedLimitAndPointOverTwelve_ResultPoint()
        {
            var fourthEx = new Conditions();
            var result = fourthEx.WhatsWrongPoliceman(50, 110);
            Assert.That(result, Does.Contain("License Suspended"));
        }
    }
}
