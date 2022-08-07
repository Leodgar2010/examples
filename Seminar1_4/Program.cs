Console.WriteLine ("Введите число: ");
string? numberString1 = Console.ReadLine ();

int number1=  int.Parse (numberString1);
int number2 = number1%10;
Console.WriteLine ("Последняя цифра введенного числа: " + number2);

