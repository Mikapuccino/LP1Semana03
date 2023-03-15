using System;

namespace ArraySums
{
    class Program
    {
        static void Main(string[] args)
        {
            // Asks user to input the length of the matrix
            Console.WriteLine("Input length of matrix: ");
            int mLength = int.Parse(Console.ReadLine());

            // Asks user to input the height of the matrix
            Console.WriteLine("Input height of matrix: ");
            int mHeight = int.Parse(Console.ReadLine());

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
                    matrix[i, j] = float.Parse(Console.ReadLine());
                }
            }

            // Initialize additional variables
            float lineSum = 0;
            float columnSum = 0;

            // For every line of the matrix, it will sum every value
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    lineSum += matrix[i, j];
                }
                // Writes sum of every element of the line and resets
                // the variable for the next line
                Console.WriteLine($"Sum of line {i + 1} = {lineSum}");
                lineSum = 0;
            }

            // For every column of the matrix, it will sum every value
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    columnSum += matrix[i, j];
                }
                // Writes sum of every element of the column and resets
                // the variable for the next column
                Console.WriteLine($"Sum of column {j + 1} = {columnSum}");
                columnSum = 0;
            }
        }
    }
}
