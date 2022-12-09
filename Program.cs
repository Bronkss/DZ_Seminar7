Console.WriteLine("введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов: ");
int colums = Convert.ToInt32(Console.ReadLine());
double[,] matrix = new double[rows, colums];
FillArray(matrix);
PrintArray(matrix);

void FillArray(double[,] mtr)
{
    for (int i = 0; i < mtr.GetLength(0); i++)
    {
        for (int j = 0; j < mtr.GetLength(1); j++)
        {
            mtr[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}



// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов: ");
int colums = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[rows, colums];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine("Введите число, которое хотите проверить: ");
int numbers = Convert.ToInt32(Console.ReadLine());
CheckNumbers(numbers);

int  CheckNumbers(int element)
{
    element = numbers;
    foreach (int elemen in matrix)
    {
        if (element == matrix[0, 0])
        {
            Console.WriteLine("Такой елемент существует");

        }
        else
        {
            System.Console.WriteLine("Такого элемента нет");
        }
    }
    return element;
}


void FillArray(int[,] mtr)
{
    for (int i = 0; i < mtr.GetLength(0); i++)
    {
        for (int j = 0; j < mtr.GetLength(1); j++)
        {
            mtr[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов: ");
int colums = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[rows, colums];
FillArray(numbers);
PrintArray(numbers);
System.Console.WriteLine();
double result = 0;
Average(result);

double Average(double avarage)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        avarage = result;
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            avarage = (avarage + numbers[i, j]);
        }
        avarage = avarage / colums;
        Console.Write(avarage + "; ");
    }
    return result;
}

void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}
