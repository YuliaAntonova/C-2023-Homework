/*Задача 23
Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27; 5 -> 1, 8, 27, 64, 125*/
Random rand = new Random();
int n = rand.Next(1,10);
Console.WriteLine($"Выведем таблицу кубов цифры {n}");
int counter = 1;
while (true)
{
    Console.WriteLine($"{counter} -> {Math.Pow(counter, 3)}");
    counter++;
    if (counter > n) break;     
}