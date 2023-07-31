/*Задача 34: Задайте массив заполненный случайными 
положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/
int[] GetArray (int size, int min, int max) // метод заполнения
{
    int[] array = new int[size];// создание нового массива длиной size
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    return array;
}
int[] arrayFirst = GetArray(5, 100, 1000);
Console.WriteLine(String.Join(", ", arrayFirst));
int Calculate(int[] array)
{
    int n = 0;
    foreach (int item in array)
    {
      if (item % 2 ==0)
      n++;  
    }
    return n;
}
int sum = Calculate(arrayFirst);
Console.WriteLine(sum);
