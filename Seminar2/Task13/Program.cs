/*Задача 13: Напишите программу, которая выводит третью 
цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5; 78 -> третьей цифры нет; 32679 -> 6 */
Console.Write("Введите число: ");
//string a = Console.ReadLine();
int a = int.Parse(Console.ReadLine());
if (a / 100 > 0)
{
Console.WriteLine($"Третья цифра числа: {a.ToString()[2]}");
}
else
Console.WriteLine("Третьей цифры нет");