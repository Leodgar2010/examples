// Задача 35: Задайте одномерный массив из 123 
// случайных чисел. Найдите количество 
// элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В 
// своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5
int[] createArray()
{
    Console.WriteLine ("Введите размер массива: ");
    var numberString = Console.ReadLine();
    int number = int.Parse(numberString!);
    Console.WriteLine ("Введите минимальное значение массива: ");
    var number2String = Console.ReadLine();
    int number2 = int.Parse(number2String!);
    Console.WriteLine ("Введите максимальное значение массива: ");
    var number3String = Console.ReadLine();
    int number3 = int.Parse(number3String!);
    var random = new Random();
    var result = new int[number];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = random.Next(number2,number3);
    }
    return result;
}
void PrintArray (int []array)
{for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ",");
    }
}
int [] a = createArray ();
PrintArray(a);
int count = 0;
for (int i = 0; i < a.Length; i++)
{
   if (a [i] < 99 && a [i] > 10)  count += 1;
}
Console.WriteLine ();
Console.WriteLine ("В этом массиве "+count+ " чисел больше 10 и меньше 99");


