using System;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Security.Cryptography;
using System.Buffers;
using System.Collections.Generic;
using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            List<int> list = new List<int>(new int[]{1, 2, 9, 3, 4});
            
            int bigg = Operations.Max(list);

            Assert.AreEqual(9, bigg);
        }
        [Test]
        public void Test2()
        {
            List<int> list = new List<int>(new int[]{});

            int bigg = Operations.Max(list);

            Assert.AreEqual(0, bigg);
        }
        [Test]
        public void Test3()
        {
            List<int> list = null;

            int bigg = Operations.Max(list);
            
            Assert.AreEqual(0, bigg);
        }
    }
}