using System;
using vectori;
class Program
    {
        static void Main()
    	{
        	double[] vector1 = new double[] { 1.0, 2.0};
            double[] vector2 = new double[] { -3.0, -4.0};
        
        	Console.WriteLine("{0}", VectorMath.Add(vector1, vector2));
    	}
    }