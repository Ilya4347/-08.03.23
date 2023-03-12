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

Console.WriteLine("Введите число ");
int number = int.Parse(Console.ReadLine()!); 
if(number<8&&number>5) Console.WriteLine("день недели является выходным");
 else Console.WriteLine("день недели не является выходным");
if(number>7) Console.WriteLine("такой день недели не существует");