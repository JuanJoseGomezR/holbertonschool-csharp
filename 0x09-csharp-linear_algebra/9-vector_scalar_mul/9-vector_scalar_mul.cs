using System;

namespace _9_vector_scalar_mul
{
    ///<summary>multiply vector by scalar</summary>
    class VectorMath
    {
        ///<summary>multiply vector by scalar</summary>
        public static double[] Multiply(double[] vector, double scalar)
        {
            double[] fail = {-1};
            
            if (vector.Length > 2)
            {
                return fail;
            }
            double[] result = new double[vector.Length];
            for (int i = 0; i < vector.Length; i++)
            {
                result[i] = vector[i] * scalar;
            }
            return result;
        }
    }
