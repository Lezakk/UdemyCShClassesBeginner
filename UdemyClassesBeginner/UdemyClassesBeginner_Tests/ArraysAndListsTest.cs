using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using UdemyClassesBeginner;

namespace UdemyClassesBeginner_Tests
{
    [TestFixture]
    class ArraysAndListsTest
    {
        [Test]
        public void SixThFacebook_WhenOnlyOneFriendLikePost_ReturnNameLikesYourPost()
        {
            List<string> list = new List<string> { "Tom" };
            var facebook = new ArraysAndLists();
            var result = facebook.Facebook(list);
            Assert.That(result, Does.Contain(String.Format("{0} likes your post.", list[0])));

        }
        [Test]
        public void SixThFacebook_WhenNoOneLikePost_ReturnsNothing()
        {
            List<string> list = new List<string>();
            var facebook = new ArraysAndLists();
            var result = facebook.Facebook(list);
            Assert.That(result, Does.Contain(""));

        }
        [Test]
        public void SixThFacebook_WhenOnlyTwoFriendLikePost_ReturnNamesLikeYourPost()
        {
            List<string> list = new List<string> { "Tom", "Jerry" };
            var facebook = new ArraysAndLists();
            var result = facebook.Facebook(list);
            Assert.That(result, Does.Contain(String.Format("{0} and {1} like your post.", list[0], list[1])));

        }
        [Test]
        public void SixThFacebook_WhenTwoAndMoreFriendLikePost_ReturnNamesNumOfOthersLikeYourPost()
        {
            List<string> list = new List<string> { "Tom", "Jerry", "Ben", "Kate" };
            var facebook = new ArraysAndLists();
            var result = facebook.Facebook(list);
            Assert.That(result, Does.Contain(String.Format("{0}, {1} and {2} others like your post.", list[0], list[1], list.Count - 2)));

        }

        [Test]
        public void ReverseString_ReverseGivenString_ReturnReversedString()
        {
            var reverse = new ArraysAndLists();
            var result = reverse.ReverseString("Pomarancza");
            Assert.That(result, Does.Contain("azcnaramoP"));
        }
    }
}
