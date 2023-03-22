/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/

/*Console.WriteLine("Введите число a: ");
Console.WriteLine("Введите число b: ");
int a = int.Parse(Console.ReadLine()!); 
int b = int.Parse(Console.ReadLine()!);
if(a>b) 
    Console.WriteLine("a - максимальное число, b - минимальное число");
    else Console.WriteLine("b - максимальное число, a - минимальное число");*/


/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/


/*Console.WriteLine("Введите число a: ");
Console.WriteLine("Введите число b: ");
Console.WriteLine("Введите число c: ");
int a = int.Parse(Console.ReadLine()!); 
int b = int.Parse(Console.ReadLine()!);
int c = int.Parse(Console.ReadLine()!);
int max = a;
if(b>max) max = b;
if(c>max) max = c;
    Console.Write("max = ");
    Console.WriteLine(max);*/
   

/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка(number%2==0)).

4 -> да
-3 -> нет
7 -> нет*/

/*Console.WriteLine("Введите число ");
int number = int.Parse(Console.ReadLine()!); 
if(number%2==0) Console.WriteLine("число является четным");
 else Console.WriteLine("число является нечетным");*/


 /*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8*/   

/*Console.WriteLine("Введите число ");
int n = int.Parse(Console.ReadLine()!); 
int a = 1;
while (a<=n){
    if(a%2==0) Console.WriteLine(a + "");
    a++;}
*/ 

/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 */

/*Console.WriteLine("Введите число ");
string number = Console.ReadLine()!;
if (number.Length == 3){
Console.WriteLine ($"{number}={number[1]}");
}
else {
Console.WriteLine ("Введено неверное число");
}*/

/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6*/

/*Console.WriteLine("Введите число ");
string number = Console.ReadLine()!;
if (number.Length >= 3){
Console.WriteLine ($"{number}->{number[2]}");
}
else 
{    
Console.WriteLine ("Третьей цифры нет");
}*/

/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

/*Console.WriteLine("Введите число ");
int number = int.Parse(Console.ReadLine()!); 
if(number<8&&number>5) Console.WriteLine("день недели является выходным");
 else Console.WriteLine("день недели не является выходным");
if(number>7) Console.WriteLine("такой день недели не существует");*/


/*Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да*/

/*Console.WriteLine ("Введите пятизначное число");
String a = Console.ReadLine()!;
if (a.Length == 5){

}
    if (a[0]==a[4]&& a[1]==a[3])
{
        Console.WriteLine ("число является палиндромом");
}
else
{
   Console.WriteLine ("число не является палиндромом");
}

*/


/*Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53*/

/*int ReadInt(string text)
{
System.Console.Write(text);
return Convert.ToInt32(Console.ReadLine());
}
int[] a = new int[3];
int[] b = new int[3];
a[0] = ReadInt("Введите координату X точки A: ");
a[1] = ReadInt("Введите координату Y точки A: ");
a[2] = ReadInt("Введите координату Z точки A: ");
b[0] = ReadInt("Введите координату X точки B: ");
b[1] = ReadInt("Введите координату Y точки B: ");
b[2] = ReadInt("Введите координату Z точки B: ");
double res = Math.Round(Math.Sqrt(Math.Pow(a[0]-b[0], 2) + Math.Pow(a[1]-b[1], 2) + Math.Pow(a[2]-b[2], 2)), 2);
System.Console.WriteLine("Расстояние между точками = " + res);*/

/*Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

/*int ReadInt(string text)
{
System.Console.Write(text);
return Convert.ToInt32(Console.ReadLine());
}

void NumberPow(int number)
{
for (int i = 1; i <= number; i++)
{
System.Console.Write(Math.Pow(i, 3) + " ");
}
}

int number = ReadInt("Введите число: ");
NumberPow(number);*/


/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. (Задачи, решенные через Math.Pow, не будут считаться правильными, так как задача стоит в том, чтобы написать цикл)

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/

/*Console.Write("Введите число: ");
int A = int.Parse (Console.ReadLine()!);
Console.Write("Введите степень: ");
int B = int.Parse (Console.ReadLine()!);
Console.WriteLine ($"{A} в степени {B}={Pow(A,B)}");
int Pow (int num, int rank)
{
    if (B==0) return 1;
    int result = num;
    for (int i = 2; i<=rank; i++)
    {
        result*=num;
    }
    return result;

}
*/

/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/
/*Console.Write("Введите число: ");
int num = int.Parse (Console.ReadLine()!);
Console.WriteLine($"Сумма цифр ={GetSumNums(num)}");
int GetSumNums (int number)
{
    int sum = 0;
    while (number>0)
    {
        sum+=number%10;
        number/=10;
    }
    return sum;
    
    
}
*/
/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (числа берете любые)*/

int [] array = GetRandomArray (8,0,100);
Console.WriteLine ($"[{String.Join(",",array)}]");

int[]GetRandomArray(int size, int minValue, int maxValue)
{
int[]result = new int [size];
for (int i=0; i<size; i++)
{
result[i]= new Random().Next(minValue, maxValue);
}
return result;
}
