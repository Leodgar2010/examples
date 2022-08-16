// Решение в группах задач:
// Задача 26: Напишите программу, которая 
// принимает на вход число и выдаёт 
// количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
// int NumberLenght(string a) 
// {
//     int result =a.Length;
//     return result;
// }

// Console.WriteLine ("Вычисление длины числа");
// Console.WriteLine ("Введите число:");
// string? number = (Console.ReadLine()!);
// var result = NumberLenght(number);
// Console.WriteLine(result);
// int Digits(int num)
// {
//     if (num == 0)
//         return 1;

//     var result = 0;
    
//     while(num > 0)
//     {
//         num = num / 10;
//         result++;
//     }
    
//     return result;
// }
int Digits(int num)
{
    if (num == 0)
        return 1;

    for (var i = 1; i < 100; i++) {
        num = num / 10;

        if (num == 0)
            return i;
    }

    return -1;
}


if (int.TryParse(Console.ReadLine()!, out var number))
{
    var result = Digits(number);

    Console.WriteLine(result);

} else {
    Console.WriteLine("Введено не число или слишком большое число!");
}

Console.WriteLine ("Вычисление длины числа");
Console.WriteLine ("Введите число:");

if (int.TryParse(Console.ReadLine()!, out var number))
{
    if (number <= 0)
        return;

    var result = Digits(number);

    Console.WriteLine(result);

} else {
    Console.WriteLine("Введено не число или слишком большое число!");
}
