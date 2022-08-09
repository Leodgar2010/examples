// 12. Напишите программу, которая будет 
// принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
Console.WriteLine ("Введите первое число: ");
string? numberString1 = Console.ReadLine ();
int number1=  int.Parse (numberString1!);
Console.WriteLine ("Введите второе число: ");
string? numberString2 = Console.ReadLine ();
int number2=  int.Parse (numberString2!);
var number3 = number1%number2;
if (number3 == 0)
    Console.WriteLine  ("Второе число кратно первому");
else
    Console.WriteLine ("Второе число не кратно первому. Остаток:"+(number3));

