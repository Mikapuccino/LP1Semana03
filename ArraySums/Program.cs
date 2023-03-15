using System;

namespace ArraySums
{
    class Program
    {
        static void Main(string[] args)
        {
            // Asks user to input the length of the matrix
            Console.WriteLine("Input length of matrix: ");
            int mLength = int.Parse(Console.ReadLine);

            // Asks user to input the height of the matrix
            Console.WriteLine("Input height of matrix: ");
            int mHeight = int.Parse(Console.ReadLine);

            // Initializes matrix with specified dimensions
            float[,] matrix = new float [mLength, mHeight];

            // For every position of the matrix it will ask the user for a value
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    // User inputs a value that is stored in the
                    // specified position
                    Console.WriteLine($"Input value for [{i}, {j}]: ");
                    matrix[i, j] = float.Parse(Console.ReadLine);
                }
            }
        }
    }
}
