// Задача 47. Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Ограничения массива установил (-10; 10).
// Не смог разобраться, как устанавливать эти ограничения для вещественных чисел
// с помощью min max в самом массиве, поэтому закоментировал min и max.
// В данном коде ограничения устанавливаются при помощи множителя 10 в строке 23.
// Но при помощи этого множителя границы ограничения симметричны
// Например (-10;10 или -5;5). А вот как сделать границы, например (-2;10)?

double[,] CreateMatrixRndInt(int rows, int columns) //, double min, double max)
{
    var matrix = new double[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round((rnd.NextDouble() * 2 - 1) * 10, 1);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {       
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.WriteLine($"{matrix[i, j],4} ");
        }
    }
}

double[,] array2D = CreateMatrixRndInt(3, 4); //, -100, 100);

PrintMatrix(array2D);