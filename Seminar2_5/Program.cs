// Напишите программу, которая принимает на 
//вход два числа и проверяет, \
//является ли одно число квадратом другого.
// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет
Console.WriteLine ("Введите первое число: ");
string? numberString1 = Console.ReadLine ();
var number1=  int.Parse (numberString1!);

Console.WriteLine ("Введите второе число: ");
string? numberString2 = Console.ReadLine ();
var number2=  int.Parse (numberString2!);

var number3 = number1*number1;
var number4 = number2*number2;

if (number3 == number2)
    Console.WriteLine  ("Да");
else if (number4 == number1)
    Console.WriteLine ("Да");
else
    Console.WriteLine ("Нет");
