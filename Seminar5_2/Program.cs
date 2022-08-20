// Задача 32: Напишите программу замена элементов 
// массива: положительные элементы замените на 
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 
int[] createArray()
{
    var random = new Random();
    var result = new int[12];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = random.Next(-9, 10);
    }
    return result;
}
void ChangePlaces(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * -1;
    }
}


var array = createArray();
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + ",");
}
ChangePlaces(array);
Console.WriteLine();
// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write(array[i] + ",");
// }
Console.WriteLine (array);