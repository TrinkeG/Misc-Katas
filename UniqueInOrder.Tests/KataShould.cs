using NUnit.Framework;

namespace UniqueInOrder.Tests
{
    [TestFixture]
    public class KataShould
    {

        [Test]
        public void return_empty_string_for_empty_input()
        {
            Assert.AreEqual("", Kata.UniqueInOrder(""));
        }

        [Test]
        public void return_single_characters_for_character_input()
        {
            Assert.AreEqual("ABCDAB", Kata.UniqueInOrder("AAAABBBCCDAABBB"));
        }
    }
}
