using ConsoleApp1;

//namespace Make_the_small_words_big_

namespace Solution
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class KataTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("THE qck brwn FOX jmps vr THE lzy DOG", Kata.SmallWordHelper("The quick brown fox jumps over the lazy dog"));
            Assert.AreEqual("I'M jst A smll wrd frm A smll wrd fmly", Kata.SmallWordHelper("I'm just a small word from a small word family"));
        }
    }
}