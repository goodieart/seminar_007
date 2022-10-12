using Lib;
using static System.Console;

Write("Введите количество строк, столбцов: ");
int[] arg = Parser.GetUserInput(",");

int[,] matrix = Arrays.Create2DArrayInt32(arg[0], arg[1]);
Arrays.PrintArray(matrix);

Write("Введите строку, столбец: ");
arg = Parser.GetUserInput(",");

if (arg[0] >= matrix.GetLength(0)
    || arg[0] < 0
    || arg[1] >= matrix.GetLength(1)
    || arg[1] < 0)
{
    WriteLine($"Элемент с индексами [{arg[0]}, {arg[1]}] отсутствует в массиве");
    return;
}
else WriteLine(matrix[arg[0], arg[1]]);