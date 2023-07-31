/*Задача 38: Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементами
массива.[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76*/
double[] arrayFirst = GetArray(10, 100);
Console.WriteLine(String.Join(", ", arrayFirst));
Console.WriteLine($"Максимальный элемент массива {SelectionMax(arrayFirst)}, Минимальный элемент массива {SelectionMin(arrayFirst)}, Разница между ними {SelectionMax(arrayFirst) - SelectionMin(arrayFirst)}");

double[] GetArray (int size, int m) // метод заполнения
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().NextDouble() * m;
    }
    return array;
}
double SelectionMin(double[] array) // метод, который ищет минимальный элемент
{    
        int minPosition = 0;
        for (int i = 0; i < array.Length; i++) 
        {
            if(array[i] < array[minPosition]) minPosition = i;
        }  
          return array[minPosition];
}

double SelectionMax(double[] array) // метод, который ищет максимальный элемент
{    
        int maxPosition = 0;
        for (int i = 0; i < array.Length; i++) 
        {
            if(array[i] > array[maxPosition]) maxPosition = i;
        }  
          return array[maxPosition];
}