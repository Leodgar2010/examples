// 14. Напишите программу, которая принимает 
// на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да
Console.WriteLine ("Введите число: ");
string? numberString1 = Console.ReadLine ();
int number1=  int.Parse (numberString1!);
var number2 = number1%7;
var number3 = number1%23;
if (number2 == 0)  
    if (number3 ==0)
    Console.WriteLine ("Да");        
else
    Console.WriteLine ("Нет");