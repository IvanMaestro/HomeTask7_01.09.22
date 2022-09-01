// Задача 50. Напишите программу, 
// которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента 
// или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

Console.WriteLine("Введите номер строки: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца: ");
int b = Convert.ToInt32(Console.ReadLine());

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

bool SearchElement(int ax, int bx, int[,]matr)
{
    return ax > matr.GetLength(0) || bx > matr.GetLength(1);
}

int[,] matrix = CreateMatrixRndInt(3,4,-10,10);
PrintMatrix(matrix);
Console.WriteLine();
bool result = SearchElement(a,b,matrix);
Console.WriteLine(result? "Такого элемента в массиве нет!":$"Элемент найден: {matrix[a-1,b-1]}");
