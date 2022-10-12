using Lib;

Console.Write("Введите количество строк, столбцов: ");
int[] arg = Parser.GetUserInput(",");
double[,] matrix = Arrays.Create2DArrayDouble(arg[0], arg[1]);
Arrays.PrintArray(matrix);