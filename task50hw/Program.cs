// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет

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
            Console.Write($"{matr[i, j], 5} "); 
        }
        Console.WriteLine();
    }
}


Console.WriteLine("Введите количество сторк: ");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columns2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимальное значение в массиве: ");
int minimum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение в массиве: ");
int maximum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите позицию искомого элемента -> сторка: ");
int rowsUser = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите позицию искомого элемента -> столбец: ");
int columnsUser = Convert.ToInt32(Console.ReadLine());

int[,] array2d = CreateMatrixRndInt(rows2, columns2, minimum, maximum);
PrintMatrix(array2d);
if (rowsUser < 0) rowsUser *= -1;
if (columnsUser < 0) columnsUser *= -1;
if (rowsUser > rows2 || columnsUser > columns2) Console.WriteLine($"Элемента с позицией: {rowsUser}, {columnsUser} - Нет");
else Console.WriteLine($"Искомый элемент -> {array2d[rowsUser, columnsUser]}");


