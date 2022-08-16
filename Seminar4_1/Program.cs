//Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
//7 -> 28
//4 -> 10
//8 -> 36

int SumFrom1ToA(int a) {
    int result = 0;

    for (var i = 1; i <= a; i++)
        result += i;

    return result;
}

Console.WriteLine ("Вычисление суммы чисел от 1 до введенного числа");
Console.WriteLine ("Введите положительное число:");
var number = int.Parse(Console.ReadLine()!);

if (number <= 0)
    return;

var result = SumFrom1ToA(number);

Console.WriteLine(result);
