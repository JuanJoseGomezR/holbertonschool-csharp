using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            string str = "sopo";
            var comp = Str.UniqueChar(str);
            Assert.AreEqual(0, comp);
        }
        [Test]
        public void Test2()
        {
            string str = "";
            var comp = Str.UniqueChar(str);
            Assert.AreEqual(-1, comp);
        }
        [Test]
        public void Test3()
        {
            string str = "aaiiee";
            var comp = Str.UniqueChar(str);
            Assert.AreEqual(-1, comp);
        }
        [Test]
        public void Test4()
        {
            string str = "sstroo";
            var comp = Str.UniqueChar(str);
            Assert.AreEqual(2, comp);
        }
    }
}