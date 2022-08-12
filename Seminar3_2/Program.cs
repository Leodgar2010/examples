// Задача 18: Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).
// if (x > 0 && y > 0)
//     result = 1;
// else if (x < 0 && y > 0)
//     result = 2;
// else if (x < 0 && y < 0)
//     result = 3;
// else if (x > 0 && y < 0)
//     result = 4;
Console.WriteLine ("Введите номер четверти: ");
var QuarterString = Console.ReadLine ();
int Quarter= int.Parse (QuarterString!);
if (Quarter>4 || Quarter<1) 
{
    Console.WriteLine ("Нужно ввести число от 1 до 4");
    return;
}
if (Quarter==1)
    Console.WriteLine ("Диапазон этой четверти: x от 0 до +бесконечности, y от 0 до +бесконечности");
if (Quarter==2)
    Console.WriteLine ("Диапазон этой четверти: x от 0 до -бесконечности, y от 0 до +бесконечности");
if (Quarter==3)
    Console.WriteLine ("Диапазон этой четверти: x  от -бесконечности до 0, y от -бесконечности до 0");
if (Quarter==4)
    Console.WriteLine ("Диапазон этой четверти: x от 0 до +бесконечности, y от -бесконечности до 0");
