/*Задача 36: Задайте одномерный массив, заполненный 
случайными числами. Найдите сумму элементов, стоящих 
на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/
int[] GetArray (int size, int min, int max) // метод заполнения
{
    int[] array = new int[size];// создание нового массива длиной size
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    return array;
}
int[] arrayFirst = GetArray(5, 0, 10);
Console.WriteLine(String.Join(", ", arrayFirst));
int Sum (int [] array)
{
    int count = 0;
    for (int i = 1; i < array.Length; i = i + 2)
    {
    count = array[i] + count;
    }
    return count;
}
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях {Sum(arrayFirst)}");

