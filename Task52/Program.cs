// Задача 52. Задайте двумерный массив 
// из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



int[,] CreateMatrixRndInt(int row, int col, int min, int max)
{
    int[,] matr = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matr;
}

void PrintMatrix(int[,] matr)
{

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matr.GetLength(1); j++)
        {

            if (j < matr.GetLength(1) - 1) Console.Write($"{matr[i, j],4} ");
            else Console.Write($"{matr[i, j],4} ");

        }
        Console.WriteLine("]");
    }
}

void ArithmeticMean(int[,] matr)
{
    Console.Write("[");
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        double summ = 0;
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            summ += matr[i, j];
        }
        double res = Math.Round(summ / matr.GetLength(0), 1);
        Console.Write($"{res,4} ");
    }
    Console.WriteLine("]");
}

int[,] matrix = CreateMatrixRndInt(3, 4, -10, 10);
PrintMatrix(matrix);
Console.WriteLine();
ArithmeticMean(matrix);


