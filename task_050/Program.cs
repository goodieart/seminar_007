using Lib;
using static System.Console;

int[,] matrix = Arrays.Create2DArrayInt32(4, 3);

Arrays.Print2DArray(matrix);

Write("Введите строку, столбец: ");
int[] arg = Parser.GetUserInput(",");

if (arg[0] >= matrix.GetLength(0)
    || arg[0] < 0
    || arg[1] >= matrix.GetLength(1)
    || arg[1] < 0)
{
    WriteLine($"Элемент с индексами [{arg[0]}, {arg[1]}] отсутствует в массиве");
    return;
}
else
{
    WriteLine(matrix[arg[0], arg[1]]);
}