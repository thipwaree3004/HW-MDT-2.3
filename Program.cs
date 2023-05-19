using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Enter '+' or '-' to perform matrix operation, or any other character to exit: ");
            char operation = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (operation == '+' || operation == '-')
            {
                Console.Write("Enter the size of the matrix: ");
                int size = int.Parse(Console.ReadLine());

                Console.Write("Enter a real number as the matrix element: ");
                double element = double.Parse(Console.ReadLine());

                double[,] matrix = CreateMatrix(size, element);

                double result = PerformMatrixOperation(matrix, operation);
                Console.WriteLine("Result of the matrix operation: " + result);
            }
            else
            {
                break;
            }
        }
    }

    static double[,] CreateMatrix(int size, double element)
    {
        double[,] matrix = new double[size, size];
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                matrix[i, j] = element;
            }
        }
        return matrix;
    }

    static double PerformMatrixOperation(double[,] matrix, char operation)
    {
        int size = matrix.GetLength(0);
        double result = 0;

        if (operation == '+')
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    result += matrix[i, j];
                }
            }
        }
        else if (operation == '-')
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    result -= matrix[i, j];
                }
            }
        }

        return result;
    }
}

