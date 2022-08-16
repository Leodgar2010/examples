// Решение в группах задач:
// Задача 28: Напишите программу, которая 
// принимает на вход число N и выдаёт 
// произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120
// Решение в группах задач:
// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

int ProdFrom1ToA(int a) {
    int result = 1;

    for (var i = 1; i <= a; i++)
        result = result*i;

    return result;
}


if (int.TryParse(Console.ReadLine()!, out var a))
{
    if (a < 0)
    {
        Console.WriteLine("Введено отрицательное число");
        return;
    }

    int result = ProdFrom1ToA(a);
    Console.WriteLine(result);

} else {
    Console.WriteLine("Введено не число или слишком большое число!");
}

