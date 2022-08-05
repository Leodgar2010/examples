Console.WriteLine ("Введите номер дня недели: ");
string? numberString1 = Console.ReadLine ();
int number1=  int.Parse (numberString1);
if (number1==1)
{
   Console.WriteLine ("Понедельник");
}
if (number1==2)
{
   Console.WriteLine ("Вторник");
}
if (number1==3)
{
   Console.WriteLine ("Среда");
}
if (number1==4)
{
   Console.WriteLine ("Четверг");
}
if (number1==5)
{
   Console.WriteLine ("Пятница");
}
if (number1==6)
{
   Console.WriteLine ("Суббота");
}
if (number1==7)
{
   Console.WriteLine ("Воскресенье");
}