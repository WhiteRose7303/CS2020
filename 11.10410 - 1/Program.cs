using System;

namespace _11._10410___1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[,] matrix = MakeMatrix(4, 6);
            PrintMatrix(matrix);

        }

        public static int[,] MakeMatrix(int rows, int coloums)
        {
            Random rnd = new Random();
            int[,] matrix = new int[rows, coloums];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(0, 9);
                }
            }
            return matrix;
        }

        public static void PrintMatrix(int[,] mat)
        {
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write(mat[i, j]);
                    
                }
                Console.WriteLine();
            }
        }
    }
}