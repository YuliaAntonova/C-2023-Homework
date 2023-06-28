/*Задача 8: Напишите программу, которая на вход принимает
число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4; 8 -> 2, 4, 6, 8*/
Console.WriteLine ("Введите число");
int a = Int32.Parse(Console.ReadLine()); 
int N = 2;
while (N <= a)
{
    Console.WriteLine($"{N}");
    N= N + 2;
}