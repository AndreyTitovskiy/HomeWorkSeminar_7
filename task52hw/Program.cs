// // Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.WriteLine("Введите количество сторк: ");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columns2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимальное значение в массиве: ");
int minimum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение в массиве: ");
int maximum = Convert.ToInt32(Console.ReadLine());

int[,] array2d = CreateMatrixRndInt(rows2, columns2, minimum, maximum);
PrintMatrix(array2d);
Console.WriteLine();

int[] columnSums = new int[columns2];
for (int j = 0; j < columns2; j++)
{
    for (int i = 0; i < rows2; i++)
    {
        columnSums[j] += array2d[i, j];
    }
}

double[] avarageColumns = new double[columns2];
double[] roundedAvarageColumns = new double[columns2];
for (int i = 0; i < columns2; i++)
{
    avarageColumns[i] = (double)columnSums[i] / rows2;
    roundedAvarageColumns[i] = Math.Round(avarageColumns[i], 1);
}
Console.WriteLine($"Среднее арифметическое каждого столбца: ");
Console.Write($"   ");
PrintArray(roundedAvarageColumns);


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matr = new int[rows, columns];
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
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j],5} ");
        }
        Console.WriteLine();
    }
}

void PrintArray(double[] arr, string sep = "; ")
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}{sep} ");
        else Console.Write($"{arr[i]}");
    }
}
