using System;
using System.Text;

public static class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Console.Write("Specify the size of the matrix(number of rows,and at the same time columns,i.e. 1 value): ");
            int size = int.Parse(Console.ReadLine());

            var matrix1 = new Matrix(size);
            Console.WriteLine("Enter the elements of the first matrix:");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write($"Element [{i},{j}]: ");
                    matrix1[i, j] = int.Parse(Console.ReadLine());
                }
            }

            var matrix2 = new Matrix(size);
            Console.WriteLine("Enter the elements of the second matrix:");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write($"Element [{i},{j}]: ");
                    matrix2[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Select the operation to be performed (addition: +, subtraction: -):");
            char operation = Console.ReadLine()[0];
            Matrix result = null;

            switch (operation)
            {
                case '+':
                    result = matrix1 + matrix2;
                    break;
                case '-':
                    result = matrix1 - matrix2;
                    break;
                default:
                    Console.WriteLine("Unknown operation");
                    break;
            }

            if (result != null)
            {
                Console.WriteLine("Result:");
                Console.WriteLine(result.ToString());
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}
