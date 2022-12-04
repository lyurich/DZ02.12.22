// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

/*
Console.WriteLine("Введите количество строк массива: ");
int row = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов массива: ");
int colums = int.Parse(Console.ReadLine()!);

double[,] array = GetArray(row, colums, -100, 100);
PrintArray(array);

double[,] GetArray(int m, int n, int minValue, int maxValue)
{
    Random rnd = new Random();
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i,j] = Convert.ToDouble(rnd.Next(minValue, maxValue + 1)/10.0);

        }
    }
    return result;
}

void PrintArray(double[,] array)
{
    for  (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[  ");
        for  (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]}  ");
        }
        Console.WriteLine("]");
    }
}
*/



// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

/*
Console.WriteLine("Введите количество строк массива: ");
int row = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов массива: ");
int colums = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(row, colums, -10, 10 );

PrintArray(array);

Console.WriteLine("Введите координату строки: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату столбца: ");
int b = int.Parse(Console.ReadLine()!);

FindPositionArray(array);

void FindPositionArray(int[,] array){
if (a>row || b>colums)
 Console.WriteLine("Такого элемента нет!");
 else
 {
 int c = array[a,b];
 Console.WriteLine($"Такой элемент существует и равен: {c}");
 }
}


int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[  ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]}  ");
        }
        Console.WriteLine("]");
    }
}
*/


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("Введите количество строк массива: ");
int row = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов массива: ");
int colums = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(row, colums, -10, 10);
PrintArray(array);
SrArifmColums(array);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[  ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}    ");
        }
        Console.WriteLine("]");
    }
}

void SrArifmColums(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double srArifm = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            srArifm += array[i, j];
        }
        Console.Write($" {(float)srArifm / row:f2}");
    }
    Console.WriteLine();
}