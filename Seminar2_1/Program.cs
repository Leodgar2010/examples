Console.WriteLine ("Введите первое число: ");
string? numberString1 = Console.ReadLine ();
int number1=  int.Parse (numberString1);
Console.WriteLine ("Введите второе число: ");
string? numberString2 = Console.ReadLine ();
int number2=  int.Parse (numberString2);
if (number1*number1 == number2)
{
   Console.WriteLine ("Первое число является квадратом второго.");
}
else
{
    Console.WriteLine ("Первое число не является квадратом второго.");
}
