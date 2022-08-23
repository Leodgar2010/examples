//Задача 40: Напишите программу, 
//которая принимает на вход три числа и проверяет,
//может ли существовать треугольник с сторонами такой длины.
//Теорема о неравенстве треугольника: каждая сторона
//треугольника меньше суммы двух других сторон.
Console.WriteLine ("Введите длину первой стороны: ");
var number1String = Console.ReadLine();
int number1 = int.Parse(number1String!);
Console.WriteLine ("Введите длину второй стороны: ");
var number2String = Console.ReadLine();
int number2 = int.Parse(number2String!);
Console.WriteLine ("Введите длину третьей стороны: ");
var number3String = Console.ReadLine();
int number3 = int.Parse(number3String!);
if (number1+number2 > number3 && number2+number3 > number1 && number1+number3 >number2) Console.WriteLine ("Треугольник существует");
else Console.WriteLine ("Треугольник не существует");
