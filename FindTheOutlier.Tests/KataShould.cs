using NUnit.Framework;

namespace FindTheOutlier.Tests
{
    [TestFixture]
    public class KataShould
    {
        [TestCase(3, new[]{2,6,8,-10,3})]
        [TestCase(2, new[]{1,2,3})]
        public void Return_expected_for_input(int expected,int[] input)
        {

            Assert.AreEqual(expected,Kata.Find(input));
        }
    }
}
