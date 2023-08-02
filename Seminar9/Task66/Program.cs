/*Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120 M = 4; N = 8. -> 30*/
using System;
using static System.Console;
Clear();
Write("Введите число M: ");
int m = int.Parse(ReadLine());
Write("Введите число N: ");
int n = int.Parse(ReadLine());
WriteLine(PrintNumber(m, n));
int PrintNumber(int start, int end)
    {
        if (start == end) return start;
        if (start > end) return 1;
        return(start + PrintNumber(start + 1, end));
    }
    

