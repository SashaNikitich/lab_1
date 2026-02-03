using System;

namespace lab_1
{
    public class MatrixOperations
    {
        public static void Main()
        {
            try
            {
                int[,] matrixA = { { 15, 4, 10 }, { 52, 67, 69 } };
                int[,] matrixB = { { 42, 56, 11 }, { 9, 1, 1 } };

                int[,] matrixC = Xor(matrixA, matrixB);
                PrintMatrix(matrixC);
                
                double[] average = GetAverage(matrixC);
                for (int i = 0; i < average.Length; i++)
                {
                    Console.WriteLine($"col {i}: {average[i]:F2}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static int[,] Xor(int[,] a, int[,] b)
        {
            if (a == null || b == null) throw new ArgumentNullException("Matrix can't be null.");
            if (a.GetLength(0) != b.GetLength(0) || a.GetLength(1) != b.GetLength(1))
                throw new ArgumentException("Matrices must have the same dimensions.");

            int rows = a.GetLength(0);
            int cols = a.GetLength(1);
            int[,] result = new int[rows, cols];

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    result[i, j] = a[i, j] ^ b[i, j];

            return result;
        }

        public static double[] GetAverage(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            double[] averages = new double[cols];

            for (int j = 0; j < cols; j++)
            {
                double sum = 0;
                for (int i = 0; i < rows; i++) sum += matrix[i, j];
                averages[j] = sum / rows;
            }
            return averages;
        }

        public static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write(matrix[i, j].ToString().PadLeft(4));
                Console.WriteLine();
            }
        }
    }
}