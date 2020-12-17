using NUnit.Framework;

namespace Text.Tests
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            string str = "hola Porque No";
            int result = Str.CamelCase(str);
            Assert.AreEqual(3, result);
        }
        [Test]
        public void Test2()
        {
            string str = "hola";
            int result = Str.CamelCase(str);
            Assert.AreEqual(1, result);
        }
        [Test]
        public void Test3()
        {
            string str = "";
            int result = Str.CamelCase(str);
            Assert.AreEqual(0, result);
        }
        [Test]
        public void Test4()
        {
            string str = "hola Porque";
            int result = Str.CamelCase(str);
            Assert.AreEqual(2, result);
        }
    }
}