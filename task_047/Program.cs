using Lib;

Console.Write("Введите размерности m, n: ");
int[] arg = Parser.GetUserInput(",");
double[,] matrix = Arrays.Create2DArrayDouble(arg[0], arg[1]);
Arrays.Print2DArray(matrix);