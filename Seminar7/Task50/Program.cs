/*Задача 50. Напишите программу, которая на вход принимает 
позиции элемента в двуумерном массиве и возвращает значение 
этого элемента или же говорит о том, что его нет*/
using System;
using static System.Console;
Write("Введите номер строки: ");
int row = int.Parse(ReadLine());
Write("Введите номер столбца: ");
int columns = int.Parse(ReadLine());

int[,] array = GetArray(5, 5, 0, 9);
PrintArray(array);
WriteLine();
GetNumber(array, row, columns);
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];//создаем новый двумерный массив, указываем его размерность
    for (int i = 0; i < m; i++)// первый цикл перебирает строки
    {
        for(int j = 0; j < n; j++)// второй цикл переберает столбцы
        {
            result[i, j] = new Random().Next(minValue, maxValue +1);
        }
    }
    return result;
}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)// обращение к количеству строк
    {
        for (int j = 0; j < inArray.GetLength(1); j++) // обращение к количеству столбцов
        {
          Write($"{inArray[i,j]} ");  // вывод элементов двумерного массива с пробелом
        }
        WriteLine();// разделяем вывод на строки
    }
}
void GetNumber(int[,] array, int row, int columns)
{
    if (array.GetLength(0) > row && array.GetLength(1) > columns)
    {
        WriteLine($"{array[row, columns]}"); 
    }  
    else
    {
        WriteLine($"Элемента с такими индексами нет");
    } 
}
