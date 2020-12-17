using System.Runtime.InteropServices;
using System.Reflection;
using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            bool str = Str.IsPalindrome("Racecar");
            Assert.IsTrue(str);
        }
        [Test]
        public void Test2()
        {
            bool str = Str.IsPalindrome("A man, a plan, a canal: Panama.");
            Assert.IsTrue(str);
        }
        [Test]
        public void Test3()
        {
            bool str = Str.IsPalindrome("");
            Assert.IsTrue(str);
        }
        [Test]
        public void Test4()
        {
            bool str = Str.IsPalindrome("ojefeg");
            Assert.IsFalse(str);
        }
    }
}