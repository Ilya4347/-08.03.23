/*Задача 47. 
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

int rows = ReadInt("Введите количество строк m: ");
int colums = ReadInt("Введите количество столбцов n: ");
double[,] numbers = new double[rows, colums];
FillArray2D(numbers);
PrintArray2D(numbers);

void FillArray2D(double[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            array[m, n] = new Random().Next(-100, 100) / 10.0;
        }
    }
}
void PrintArray2D(double[,] array)
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