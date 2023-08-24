/*Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2; 1, -7, 567, 89, 223-> 3*/
int Prompt (string message) // Метод выведения текста в терминале
{
Console.Write (message);
int result = int.Parse(Console.ReadLine());//считывание строки, преобразование ее в число
return result;
}
int [] InputArray (int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Prompt ($"Введите {i + 1} - й элемент");
    }return array;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"[{i}] = {array[i]}");
    }
}
int CountPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }return count;
}
int lenght = Prompt("Введите количество элементов >");
int[] array;
array = InputArray(lenght);
PrintArray(array);
Console.WriteLine($"Количество чисел больше 0 - {CountPositiveNumbers (array)}");