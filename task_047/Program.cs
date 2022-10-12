// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

using static System.Console;

WriteLine("Введите размерности m, n");
int[] arg = GetUserInput(",");
double[,] matrix = Create2DArray(arg[0], arg[1]);
Print2DArray(matrix);


double[,] Create2DArray(int rows, int columns, int minValue = -100, int maxValue = 100)
{
    double[,] result = new double[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = Math.Round(Convert.ToDouble(rnd.Next(minValue, maxValue - 1)) + rnd.NextDouble(), 1);
        }
    }

    return result;
}

void Print2DArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (inArray[i, j] >= 0) Write(" ");
            Write($"{inArray[i, j]}\t");
        }
        WriteLine();
    }
}

int[] GetUserInput(string separator = " ")
{
    return Console.ReadLine()!.Split(separator, StringSplitOptions.RemoveEmptyEntries)
                              .Select(item => int.Parse(item))
                              .ToArray();
}