// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

void Printsumm(int[,] matrix)
{
    int size = matrix.GetLength(1);
    double[] summ = new double[size];
    //int summ = 0;
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            summ[j] = summ[j] + matrix[i, j];
        }
        double arithmeticMean = Math.Round(summ[j] / matrix.GetLength(0), 2);
        if (j < matrix.GetLength(1) - 1) Console.Write($"{arithmeticMean}; ");
        else Console.WriteLine($"{arithmeticMean}. ");
    }
}

int[,] createMatrixRndInt = CreateMatrixRndInt(3, 4, 0, 10);
PrintMatrix(createMatrixRndInt);
Printsumm(createMatrixRndInt);
