/*Задача 45: Напишите программу,которая будет 
создавать копию заданного массива с помощью 
поэлементного копирования.*/
Console.WriteLine("Введите элементы массива через пробел: ");
string elements = Console.ReadLine();
int[] BaseArray = GetArray(elements);
int[] GetArray (string stringArray) // метод преобразования полученных цифр в массив
{
    string[] nums = stringArray.Split(" ");// разбили строку на массив строк
    int[] res = new int[nums.Length]; // массив строк перевели в массив чисел
    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = int.Parse(nums[i]);
    }
    return res;
}
int [] CopyArray(int[] array) // метод, который копирует массив
{
    for (int i = 0; i<array.Length -1; i++) // обращение к длине массива через array.Length
    {      // блок кода, который ищет минимальный элемент
        int minPosition = i;// определение позиции, на которую смотрим
        for (int j = i + 1; j < array.Length; j++) // то, что отсортировано начинается с i + 1 позиции
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
            //блок кода, который перемещает элементы в массиве
        int temporary = array[i];// Замена минимальной позиции с той, которую нашли
        array[i] = array[minPosition]; // Обмен двух переменных местами
        array[minPosition] = temporary; // в минимальную позицию кладем элемент, который был временным
    }
    return array;
}