// Задача 47. Задайте двумерный массив 
// размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] CreateMatrixRndInt(int row, int col, int min, int max)
{
    double[,] matr = new double[row, col];
    Random rnd = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = Math.Round(rnd.NextDouble()*(max-min)+min, 1);
        }
    }
    return matr;
}

void PrintMatrix(double[,] matrx)
{

    for (int i = 0; i < matrx.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrx.GetLength(1); j++)
        {

            if (j < matrx.GetLength(1) - 1) Console.Write($"{matrx[i, j],4} ");
            else Console.Write($"{matrx[i, j],4} ");

        }
        Console.WriteLine("]");
    }
}

double[,] matrix = CreateMatrixRndInt(3, 4, -10, 10);
PrintMatrix(matrix);





