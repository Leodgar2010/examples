void PrintArray (int [,] array)
{
   for (int i=0; i<result.GetLength(0);i++)
    {
        for (int j=0; j<result.GetLength(1);j++) Console.Write ($"{array[i,j]}");
    }
    Console.WriteLine ();    
}
int [,] CreateArrayWithRandomNumbers (int m, int n)
{
    int random = new Random ();
    int [,] result = new int [m,n]();
    for (int i=0; i<result.GetLength(0);i++)
    {
        for (int j=0; j<result.GetLength(1);j++) result [i,j] = random.Next (1,100);
    }
    return result
}

Console.WriteLine ("Введите число строк (m)");
if(!int.TryParse(Console.ReadLine()!, out var m)) {
    Console.WriteLine("Всё плохо");
}
Console.WriteLine ("Введите число cтолбцов (n)");
if(!int.TryParse(Console.ReadLine()!, out var n)) {
    Console.WriteLine("Всё плохо");
}

