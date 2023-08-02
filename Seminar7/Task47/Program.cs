/*Задача 47. Задайте двумерный массив mxn, 
заполненный случайными вещественными числами*/
using System;
using static System.Console;
Clear();
Write("Введите количество строк массива: ");
int row = int.Parse(ReadLine());
Write("Введите количество столбцов массива: ");
int columns = int.Parse(ReadLine());
double[,] arrayDouble = GetArray(row, columns);
PrintArray(arrayDouble);
double[,] GetArray (int n, int m)
{
    double[,] array = new double[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            array[i, j] = new Random().NextDouble() * m;
        }
    }
    return array;
}
void PrintArray(double[,] inArray)
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