namespace Lib;
using static System.Console;

public class Arrays
{
    /// <summary>
    /// Метод создает двумерный массив с вещественными числами
    /// </summary>
    /// <param name = "rows">Количество строк в результирующем массиве</param>
    /// <param name = "columns">Количество столбцов в результирующем массиве</param>
    /// <param name = "minValue">Минимально возможное значение при заполнении массива</param>
    /// <param name = "maxValue">Максимально возможное значение при заполнении массива</param>
    /// <returns>Новый массив, заполненный случайными вещественными числами</returns>
    public static double[,] Create2DArrayDouble(int rows, int columns, int minValue = -100, int maxValue = 100)
    {
        double[,] result = new double[rows, columns];
        Random rnd = new Random();

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                result[i, j] = Convert.ToDouble(rnd.Next(minValue, maxValue)) + rnd.NextDouble();
            }
        }

        return result;
    }
    /// <summary>
    /// Метод создает двумерный массив с целыми числами
    /// </summary>
    /// <param name = "rows">Количество строк в результирующем массиве</param>
    /// <param name = "columns">Количество столбцов в результирующем массиве</param>
    /// <param name = "minValue">Минимально возможное значение при заполнении массива</param>
    /// <param name = "maxValue">Максимально возможное значение при заполнении массива</param>
    /// <returns>Новый массив, заполненный случайными целыми числами</returns>
    public static int[,] Create2DArrayInt32(int rows, int columns, int minValue = -100, int maxValue = 100)
    {
        int[,] result = new int[rows, columns];
        Random rnd = new Random();

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                result[i, j] = rnd.Next(minValue, maxValue + 1);
            }
        }

        return result;
    }
    /// <summary>
    /// Метод выводит на экран содержимое переданного двумерного массива с вещественными числами
    /// </summary>
    /// <param name = "inArray">Массив, содержимое которого следует вывести на экран</param>
    public static void PrintArray(double[,] inArray)
    {
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            for (int j = 0; j < inArray.GetLength(1); j++)
            {
                if (inArray[i, j] >= 0) Write(" ");
                Write($"{inArray[i, j]:f1}\t");
            }
            WriteLine();
        }
    }
    /// <summary>
    /// Метод выводит на экран содержимое переданного двумерного массива с целыми числами
    /// </summary>
    /// <param name = "inArray">Массив, содержимое которого следует вывести на экран</param>
    public static void PrintArray(int[,] inArray)
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
    /// <summary>
    /// Метод выводит на экран содержимое переданного одномерного массива с вещественными числами
    /// </summary>
    /// <param name = "inArray">Массив, содержимое которого следует вывести на экран</param>
    public static void PrintArray(double[] inArray)
    {
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            if (inArray[i] >= 0) Write(" ");
            Write($"{inArray[i]:f1}\t");
        }
    }
    /// <summary>
    /// Метод вычисляет средние арифметические среди элементов каждого столбца исходного массива
    /// </summary>
    /// <param name = "inArray">Массив, на основании колонок которого следует вычислить средние арифметические</param>
    /// <returns>Новый массив, заполненный средними арифметическими по каждому столбцу исходного массива</returns>
    public static double[] AverageByColumns(int[,] inArray)
    {
        double[] result = new double[inArray.GetLength(1)];
        double columnSum = 0;

        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            columnSum = 0;
            for (int i = 0; i < inArray.GetLength(0); i++)
            {
                columnSum += inArray[i, j];
            }
            result[j] = columnSum / inArray.GetLength(0);
        }
        return result;
    }
}

public class Parser
{
    /// <summary>
    /// Метод возвращает ввод пользователя, преобразованный в целочисленный массив
    /// </summary>
    /// <param name = "separator">Строковый разделитель; символы между ними в исходной строке будут
    /// преобразованы в элементы результирующего массива</param>
    /// <returns>Новый массив, заполненный преобразованными строковыми значениями в целочисленный тип</returns>
    public static int[] GetUserInput(string separator = " ")
    {
        return Console.ReadLine()!.Split(separator, StringSplitOptions.RemoveEmptyEntries)
                                  .Select(item => int.Parse(item))
                                  .ToArray();
    }
}