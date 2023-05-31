// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5   7   -2   -0,2

//  1  -3,3   8   -9,9

//  8   7,8  -7,1   9

Console.WriteLine("Введите количество сторк: ");
int rowsUser = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columnsUser = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимальное значение в массиве: ");
double minimum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение в массиве: ");
double maximum = Convert.ToInt32(Console.ReadLine());

double[,] array2d = CreateMatrixRnd(rowsUser, columnsUser, minimum, maximum);
PrintMatrix(array2d);


double[,] CreateMatrixRnd(int rows, int columns, double min, double max)
{
    double[,] matr = new double[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            double num = rnd.NextDouble()*(max - min) + min;
            matr[i, j] = Math.Round(num, 1);
        }
        
    }
    return matr;
}

void PrintMatrix(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j], 5} "); 
        }
        Console.WriteLine();
    }
}
