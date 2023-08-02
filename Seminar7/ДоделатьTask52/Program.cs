/*Задача 52. Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом столбце*/
using System;
using static System.Console;
Clear();
Write("Введите количество строк массива: ");
int row = int.Parse(ReadLine());
Write("Введите количество столбцов массива: ");
int columns = int.Parse(ReadLine());

int[,] array = GetArray(row, columns, 0, 9);
PrintArray(array);
WriteLine();
AverageNumber(array);
PrintArray(array);
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n]; 
    for (int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue +1);
        }
    }
    return result;
}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++) 
        {
          Write($"{inArray[i,j]} ");  
        }
        WriteLine();
    }
}
double[] AverageNumber(int[,] array)
{
    
    double[] average = 0;
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
   
    {
        for (int i = 0; i <= array.GetLength(0); i++)
        {
            sum = array[i, j];
            average = sum / i;
        }
        return sum;
    }
     
}

