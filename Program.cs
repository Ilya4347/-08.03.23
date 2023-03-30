/*Задача 47. 
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9

int rows = ReadInt("Введите количество строк m: ");
int colums = ReadInt("Введите количество столбцов n: ");
double[,] numbers = new double[rows, colums];
FillArray(numbers);
PrintArray(numbers);

void FillArray(double[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            array[m, n] = new Random().Next(-100, 100) / 10.0;
        }
    }
}
void PrintArray(double[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            Console.Write(array[m, n] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
*/

/*Задача 50. Напишите программу, которая на вход принимает два числа(строка, столбец), проверяя есть ли такая позиция в двумерном массиве и возвращает сообщение о том, что оно найдено, а также какое число стоит на этом месте или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

i = 1, j = 3 -> Такой элемент есть: 3
i = 4, j = 2 -> такого элемента в массиве нет

int rows = ReadInt("Введите строку i: ");
int colums = ReadInt("Введите столбец j: ");
int[,] numbers = new int[3, 4];
FillArray(numbers);
PrintArray(numbers);

if (rows < numbers.GetLength(0) && colums < numbers.GetLength(1)) Console.WriteLine(numbers[rows, colums]);
else Console.WriteLine($"{rows}{colums} -> такого числа в массиве нет");

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
*/