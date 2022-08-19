// Задача 33: Задайте массив. Напишите программу, 
// которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да
int[] createArray()
{
    var random = new Random();
    var result = new int[20];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = random.Next(-5, 5);
    }
    return result;
}

Console.WriteLine("Введите число:");
var numberString = Console.ReadLine();
int number = int.Parse(numberString!);

int[] newArray = createArray();
for (int i = 0; i < newArray.Length; i++)
{
    Console.Write(newArray[i] + ",");
}
bool a = false;
Console.WriteLine();
for (int i = 0; i < newArray.Length; i++)
{
    if (number == newArray[i])
    {
        a = true;
        break;
    }
}
if (a) Console.WriteLine("Да");
else Console.WriteLine("Нет");


