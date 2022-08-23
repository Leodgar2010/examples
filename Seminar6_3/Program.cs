//Задача 42: Напишите программу, 
//которая будет преобразовывать 
//десятичное число в двоичное.
//45 -> 101101
//3  -> 11
//2  -> 10
int a=number1;
int b=0;
int c=0;
string DecimalToBinary (int input)
{
    var result = string.Empty;
    var divider =2;
    int resultLength = 0;
    int temp = input;
while (input/divider >0)
{
    resultLenghth++;
    temp = temp/divider;
}

    result += int
   

    a = (a/2);
    b=a%2;
    c=b/2;
    Console.Write (b);
}
}    
Console.WriteLine ("Введите число: ");
if (!int.TryParse (ConsoleReadline()!, out var number))
{ 
    Console.WriteLine ("Всё плохо");
}
var result = DecimalToBinary (number);
