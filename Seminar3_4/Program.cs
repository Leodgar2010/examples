// Задача 22: Напишите программу, которая 
// принимает на вход число (N) и выдаёт 
// таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.WriteLine("Введите число:");
var numberString = Console.ReadLine();
int number = int.Parse(numberString!);
int count = 1;
if (number <0)
    number = number*-1;
Console.Write ("Квадраты все чисел от 1 до "+number+": ");
while (count <=number)
{
    Console.Write (Math.Pow(count, 2)+ " ");
    count += 1;
}
