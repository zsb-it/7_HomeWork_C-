// Задача 50. Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента
// или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

Console.WriteLine("Введите позицию элемента");
Console.Write("Строка: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Столбец: ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    var matrix = new int[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3}, ");
            else Console.WriteLine($"{matrix[i, j],3} ");
        };
    }
}

void CheckPosition(int[,] matrix)
{
    int i = row-1;
    int j = column-1;
    if (i > matrix.GetLength(0)-1 || j > matrix.GetLength(1)-1)
        Console.WriteLine($"  {row}, {column} -> такого элемента в массиве нет");
    else Console.WriteLine($"  {row}, {column} -> элемент {matrix[i, j]}");
}

int[,] createMatrixRndInt = CreateMatrixRndInt(5, 5, 0, 10);
PrintMatrix(createMatrixRndInt);
Console.WriteLine("");
CheckPosition(createMatrixRndInt);