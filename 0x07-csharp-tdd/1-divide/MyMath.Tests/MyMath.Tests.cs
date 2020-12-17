using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
		///divide by null
		[Test]
		public void Test1()
		{
			int[,] matrix = new int[2, 2] { { 8, 4 }, { 2, 6 } };
			int zero = 0;

			int[,] output = MyMath.Matrix.Divide(matrix, zero);

			Assert.AreEqual(null, output);
		}
		///matrix test
		[Test]
		public void Test2()
		{
			int[,] matrix = new int[2, 2] { { 8, 2 }, { 2, 6 } };
			int num = 0;

			int[,] output = MyMath.Matrix.Divide(matrix, num);

			Assert.AreEqual(null, output);
		}
		
	   ///matrix test
      [Test]
		public void Test3()
		{
			int[,] matrix = new int[2, 2] { { 8, 4 }, { 4, 10 } };
			int num = 2;

			int[,] output = MyMath.Matrix.Divide(matrix, num);

			Assert.AreEqual(new int[2, 2] { { 4, 2 }, { 2, 5 } }, output);
		}
		///matrix test
		[Test]
		public void Test4()
		{
			int[,] matrix = null;
			int num = 2;

			int[,] output = MyMath.Matrix.Divide(matrix, num);

			Assert.AreEqual(null, output);
		}
    }
}