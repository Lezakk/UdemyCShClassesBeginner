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
    }
}
