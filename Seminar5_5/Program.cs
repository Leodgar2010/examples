// Задача 37: Найдите произведение пар чисел 
// в одномерном массиве. Парой считаем первый 
// и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21
// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] createArray(int length)
{
    var random = new Random();

    int[] array = new int[length];

    for (int i = 0; i < array.Length; i++)
        array[i] = random.Next(1, 11);

    return array;
}
int[] multiplePair(int[] array)
{
    int newArrLength = array.Length / 2 + array.Length % 2;

    int[] result = new int[newArrLength];

    var lastResultIndex = result.Length - 1;

    for (int i = 0; i < lastResultIndex; i++)
        result[i] = array[i] * array[array.Length - i - 1];

    var middleIndex = array.Length / 2;

    if (array.Length % 2 == 0)
        result[lastResultIndex] = array[middleIndex - 1] * array[middleIndex];
    else
        result[lastResultIndex] = array[middleIndex];

    return result;
}
void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", ");
    }
}
Console.Write("Введите размер массива: ");
int length = int.Parse(Console.ReadLine()!);

int[] array = createArray(length);
Console.WriteLine("Сгенерировали массив:");
printArray(array);

int[] result = multiplePair(array);
Console.WriteLine("\nПроизведение пар:");
printArray(result);