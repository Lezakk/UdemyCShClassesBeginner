using System;
using System.Collections.Generic;
using System.Text;
using UdemyClassesBeginner;
using NUnit.Framework;

namespace UdemyClassesBeginner_Tests
{
    [TestFixture]
    class TextTests
    {
        [TestCase("1-2-3-4-5")]
        [TestCase("9-8-7-6-5")]
        public void Text_Consecutive_WhenConsecutiveStringPassed_ReturnsMessageConsecutive(string consecutiveText)
        {
            var text = new Text();
            var result = text.Consecutive(consecutiveText);
            Assert.That(result, Does.Contain("Consecutive"));
        }
        [TestCase("1-2-2-4-5")]
        [TestCase("9-10-7-6-5")]
        public void Text_Consecutive_WhenNotConsecutiveStringPassed_ReturnsMessageNotConsecutive(string consecutiveText)
        {
            var text = new Text();
            var result = text.Consecutive(consecutiveText);
            Assert.That(result, Does.Contain("Not Consecutive"));
        }

        [TestCase("1-2-3-4-5")]
        public void Text_HyphenNumbers_WhenThereAreNotDuplicates_ReturnsGood(string numbers)
        {
            var text = new Text();
            var result = text.HyphenNumbers(numbers);
            Assert.That(result, Does.Contain("Good"));
        }
        [TestCase("1-2-2-4-5")]
        public void Text_HyphenNumbers_WhenThereAreDuplicates_ReturnsDuplicates(string numbers)
        {
            var text = new Text();
            var result = text.HyphenNumbers(numbers);
            Assert.That(result, Does.Contain("Duplicates"));
        }
        [TestCase("")]
        public void Text_HyphenNumbers_WhenThereAreNotImput_ReturnsDuplicates(string numbers)
        {
            var text = new Text();
            var result = text.HyphenNumbers(numbers);
            Assert.That(result, Does.Contain("Exit"));
        }
        [TestCase("19:00")]
        [TestCase("21:37")]
        [TestCase("04:20")]
        public void Text_ValidTime_WhenCorrectTimeFormatPassed_ReturnOk(string time)
        {
            var text = new Text();
            var result = text.ValidTime(time);
            Assert.That(result, Does.Contain("Ok"));
        }
        [TestCase("24:00")]
        [TestCase("45:37")]
        [TestCase("04:70")]
        [TestCase("")]
        public void Text_ValidTime_WhenIncorrectTimeFormatOrNullPassed_ReturnInvalidTime(string time)
        {
            var text = new Text();
            var result = text.ValidTime(time);
            Assert.That(result, Does.Contain("Invalid Time"));
        }
    }
}
