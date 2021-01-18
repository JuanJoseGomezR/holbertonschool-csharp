using System;

namespace _12_dot_product
{
    ///<summary> vectors class</summary>
    class VectorMath
    {
        ///<summary>dot product of two vectors</summary>
        public static double DotProduct(double[] vector1, double[] vector2)
        {
            if (vector1.Length == 2 && vector2.Length == 2)
		{
			return vector1[0] * vector2[0] + vector1[1] * vector2[1];
		}
		else if (vector1.Length == 3 && vector2.Length == 3)
		{
			return vector1[0] * vector2[0] + vector1[1] * vector2[1] + vector1[2] * vector2[2];
		}
		return -1;
        }
    }
}
