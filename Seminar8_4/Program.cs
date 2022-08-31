// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, 
// которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим 
// следующий массив:
// 9 2 3
// 4 2 4
// 2 6 7


void PrintArray(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}, ");
        }
        Console.WriteLine();
    }
}

int[,] CreateArrayWithRandomNumbers(int m, int n)
{
    var result = new int[m, n];

    var random = new Random();

    for (var i = 0; i < result.GetLength(0); i++)
    {
        for (var j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = random.Next(0, 11);
        }
    }

    return result;
}

int[,] RemoveMinColumnAndString(int[,] array)
{
    if (array.GetLength(0) == 0 && array.GetLength(1) == 0)
         return new int[0,0];

    var min = array[0, 0];
    var minIndexI = 0;
    var minIndexJ = 0;

    for (var i = 0; i < array.GetLength(0); i++)
        for (var j = 0; j < array.GetLength(1); j++)
            if (array[i, j] < min)
            {
                min = array[i, j];
                minIndexI = i;
                minIndexJ = j;
            }

    Console.WriteLine("мин i: " + minIndexI);
    Console.WriteLine("мин j: " + minIndexJ);

    var result = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];

    for (var i = 0; i < array.GetLength(0) - 1; i++)
    {
        for (var j = 0; j < array.GetLength(1) - 1; j++)
        {
            int resultI, resultJ;

            if (i < minIndexI)
                resultI = i;
            else
                resultI = i + 1;

            if (j < minIndexJ)
                resultJ = j;
            else
                resultJ = j + 1;

            result[i, j] = array[resultI, resultJ];

            Console.Write(array[resultI, resultJ] + ", ");
        }
        Console.WriteLine();
    }

    return result;
}

Console.WriteLine("Введите число строк (m)");
if (!int.TryParse(Console.ReadLine()!, out var m))
{
    Console.WriteLine("Всё плохо");
}

Console.WriteLine("Введите число столбцов (n)");
if (!int.TryParse(Console.ReadLine()!, out var n))
{
    Console.WriteLine("Всё плохо");
}

var array = CreateArrayWithRandomNumbers(m, n);
PrintArray(array);
Console.WriteLine();
var result = RemoveMinColumnAndString(array);
Console.WriteLine();
PrintArray(result);