Console.WriteLine ("Введите число: ");
string? numberString1 = Console.ReadLine ();
int number1=  int.Parse (numberString1);
if (number1 < 0)
{
    number1 = (number1* -1);
}    
int number2=(number1*-1);
Console.WriteLine ("Результат:");
Console.WriteLine (number2);
while (number2 < number1)
{
    number2=number2+1;
    Console.WriteLine (number2);

}
