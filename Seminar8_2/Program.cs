// Задача 55: Задайте двумерный массив. Напишите программу, 
// которая заменяет строки на столбцы. В случае, если это невозможно, 
// программа должна вывести сообщение для пользователя.
Георгий Давыденко, [30.08.2022 20:44]
//Задача 53: Задайте двумерный массив. 
// Напишите программу, которая поменяет местами первую и последнюю строку массива. 
 
 
int[,] CreateArray(int numberOfRows, int numberOfColumns) 
{ 
    var random = new Random(); 
    int[,] result = new int[numberOfRows, numberOfColumns]; 
    for (int i = 0; i < result.GetLength(0); i++) 
    { 
        for (int j = 0; j < result.GetLength(1); j++) 
        { 
            result[i, j] = random.Next(1, 10); 
        } 
    } 
    return result; 
} 
 
void ViewArray(int[,] array) 
{ 
    for (int i = 0; i < array.GetLength(0); i++) 
    { 
        for (int j = 0; j < array.GetLength(1); j++) 
        { 
            Console.Write($"{array[i, j]} "); 
        } 
        Console.WriteLine(); 
    } 
} 
 
int ReadInputData() 
{ 
    if (!int.TryParse(Console.ReadLine(), out var result)) 
        Console.WriteLine("Все плохо"); 
    return result; 
} 
 
int[,] ChangeFirstAndLastRows(int[,] array) 
{ 
    int[,] result = new int[array.GetLength(0), array.GetLength(1)]; 
    for (int i = 0; i < result.GetLength(0); i++) 
    { 
        for (int j = 0; j < result.GetLength(1); j++) 
        { 
            if (i == 0) 
                result[i, j] = array[array.GetLength(0)-1, j]; 
            else if (i == array.GetLength(0)-1) 
                result[i, j] = array[0, j]; 
            else 
                result[i, j] = array[i, j]; 
        } 
    } 
    return result; 
} 
 
Console.Write("Введите число строк (m): "); 
int numberOfRows = ReadInputData(); 
Console.Write("Введите число столбцов (n): "); 
int numberOfColumns = ReadInputData(); 
int[,] array = CreateArray(numberOfRows, numberOfColumns); 
Console.WriteLine(""); 
ViewArray(array); 
Console.WriteLine(""); 
int[,] resultArray = ChangeFirstAndLastRows(array); 
ViewArray(resultArray);

Георгий Давыденко, [30.08.2022 20:47]
//Задача 55:  
//Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
//В случае, если это невозможно, программа должна вывести сообщение для пользователя (только квадратные) 
 
 
int[,] CreateArray(int numberOfRows, int numberOfColumns) 
{ 
    var random = new Random(); 
    int[,] result = new int[numberOfRows, numberOfColumns]; 
    for (int i = 0; i < result.GetLength(0); i++) 
    { 
        for (int j = 0; j < result.GetLength(1); j++) 
        { 
            result[i, j] = random.Next(1, 10); 
        } 
    } 
    return result; 
} 
 
void ViewArray(int[,] array) 
{ 
    for (int i = 0; i < array.GetLength(0); i++) 
    { 
        for (int j = 0; j < array.GetLength(1); j++) 
        { 
            Console.Write($"{array[i, j]} "); 
        } 
        Console.WriteLine(); 
    } 
} 
 
int ReadInputData() 
{ 
    if (!int.TryParse(Console.ReadLine(), out var result)) 
        Console.WriteLine("Все плохо"); 
    return result; 
} 
 
 
int[,] ChangeRowsAndColumns(int[,] array) 
{ 
    int[,] result = new int[array.GetLength(1), array.GetLength(0)]; 
    for (int i = 0; i < result.GetLength(0); i++) 
    { 
        for (int j = 0; j < result.GetLength(1); j++) 
        { 
            result[i, j] = array[j, i]; 
        } 
    } 
    return result; 
} 
 
Console.Write("Введите число строк (m): "); 
int numberOfRows = ReadInputData(); 
Console.Write("Введите число столбцов (n): "); 
int numberOfColumns = ReadInputData(); 
if (numberOfRows == numberOfColumns) 
{ 
    int[,] array = CreateArray(numberOfRows, numberOfColumns); 
    Console.WriteLine(); 
    ViewArray(array); 
    Console.WriteLine(); 
    int[,] resultArray = ChangeRowsAndColumns(array); 
    ViewArray(resultArray); 
} 
else 
Console.WriteLine("Невозможно заменить строки на столбцы");
