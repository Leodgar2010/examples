// Задача 21: Напишите программу, которая принимает на вход
// координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21
Console.WriteLine("Введите координату X точки A:");
string? numberXAstring = Console.ReadLine();
int numberXA = int.Parse(numberXAstring!);
Console.WriteLine("Введите координату Y точки A:");
string? numberYAstring = Console.ReadLine();
int numberYA = int.Parse(numberYAstring!);
Console.WriteLine("Введите координату X точки B:");
string? numberXBstring = Console.ReadLine();
int numberXB = int.Parse(numberXBstring!);
Console.WriteLine("Введите координату Y точки B:");
string? numberYBstring = Console.ReadLine();
int numberYB = int.Parse(numberYBstring!);

double numberXX = numberXB - numberXA;
double numberYY = numberYB - numberYA;
double result = (double) Math.Sqrt ((numberXX * numberXX) + (numberYY * numberYY));
Console.WriteLine("Расстояние между точками А и В равно: " + result + ".");
