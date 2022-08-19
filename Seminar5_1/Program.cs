int [] createArray ()
{
   var random = new Random();
   var result = new int [12];
   for (int i = 0; i<result.Length; i++)
   {
    result [i] = random.Next (-9,10);
   }
   return result;
}
int SumPositiveNumbers(int [] array)
{
    var result = 0;
    for (int i= 0; i < array.Length; i++)
    {
        if (array[i] > 0) result += array [i];
    }
    return result ;
}
int SumNegativeNumbers(int [] array)
{
    var result = 0;
    for (int i= 0; i < array.Length; i++)
    {
        if (array[i] < 0) result += array [i];
    }
    return result ;
}
var array = createArray ();
for (int i= 0; i < array.Length; i++)
{
    Console.Write(array [i] +",");
}
Console.WriteLine (SumPositiveNumbers (array));
Console.WriteLine (SumNegativeNumbers (array));

// int[] createArray()
// {
//     var random = new Random();

//     var result = new int[12];

//     for (long i = 0; i < result.Length; i++)
//     {
//         result[i] = random.Next(-9, 10);
//     }
// int sumNegativeNumbers(int[] array) {
//     var result = 0;

//     for (long i = 0; i < array.Length; i++)
//     {
//         if (array[i] < 0)
//             result += array[i];
//     }

//     return result;
// }

// void printArray(int[] array) {
//     Console.Write("[");

//     for(var i = 0; i < array.Length; i++) {
//         Console.Write(array[i]);
        
//         if (i != array.Length - 1)
//             Console.Write(", ");
//     }
    
//     Console.Write("]");
//     Console.WriteLine();
// }


// var array = createArray();

// Console.WriteLine("Сгенерировали массив из 12 элементов в диапазоне [-9, 9]:");

// printArray(array);

// Console.WriteLine();

// Console.WriteLine("Сумма положительных чисел в массиве:");
// Console.WriteLine(sumPositiveNumbers(array));
// Console.WriteLine();

// Console.WriteLine("Сумма отрицательных чисел в массиве:");
// Console.WriteLine(sumNegativeNumbers(array));
// Console.WriteLine();
