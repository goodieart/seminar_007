using Lib;
using static System.Console;

Write("Введите количество строк, столбцов: ");
int[] arg = Parser.GetUserInput(",");

int[,] matrix = Arrays.Create2DArrayInt32(arg[0], arg[1]);
Arrays.PrintArray(matrix);

WriteLine();
double[] avg = Arrays.AverageByColumns(matrix);
Arrays.PrintArray(avg);
WriteLine();