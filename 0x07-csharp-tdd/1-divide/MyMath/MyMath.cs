using System;

namespace MyMath
{
    ///<summary>new class matrix</summary>
    public class Matrix
    {
        ///<summary>Divides elements of a matrix by num</summary>
        public static int[,] Divide(int[,] matrix, int num)
        {
            if (num == 0)
            {
                Console.WriteLine("Num cannot be 0");
                return (null);
            }
            if (matrix == null)
            {
                return (null);
            }
            int mat_Height = matrix.GetLength(0);
            int mat_Width = matrix.GetLength(1);
            int[,] newmatrix = new int[mat_Height, mat_Width];
            for (int x = 0; x < mat_Height; x++)
            {
                for (int y = 0; y < mat_Width; y++)
                {
                    newmatrix[x, y] = matrix[x,y] / num;
                }
            }
            return (newmatrix);
        }
    }
}