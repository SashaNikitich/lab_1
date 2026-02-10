
namespace lab_1
{
    public class Program
    {
        public static void Main()
        {
            try
            {
                Matrix matrixA = new Matrix(new[,] { { 15, 4, 10 }, { 52, 67, 69 } });
                Matrix matrixB = new Matrix(new[,] { { 42, 56, 11 }, { 9, 1, 1 } });

                Matrix matrixC = matrixA.Xor(matrixB); ;

                Console.WriteLine("Result Matrix (XOR):");
                matrixC.PrintMatrix();

                double[] averages = matrixC.GetAverage();
                Console.WriteLine("\nColumn Averages:");
                for (int i = 0; i < averages.Length; i++)
                {
                    Console.WriteLine($"Col {i}: {averages[i]:F2}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}