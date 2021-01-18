class Program
    {
        static void Main()
        {
            double[,] matrix = {
                {2, 3},
                {-1, 4}
            };

            var lol = MatrixMath.MultiplyScalar(matrix, 2.0);

            for (int i = 0; i < lol.GetLength(0); i++)
            {
            for (int j = 0; j < lol.GetLength(1); j++)
            {
                Console.Write(lol[i,j] + "\t");
            }
            Console.WriteLine();
            }
        }
    }