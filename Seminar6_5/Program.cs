// Напишите программу, которая будет 
// создавать копию заданного массива 
// с помощью поэлементного копирования.
int [] ArrayCopy (int [] arr)
{
    int [] result = new int [arr.Length];
    for (int i=0; i < arr.Length; i++)
    {
        result [i] = arr [i];
    }
    return result;
}
void PrintArray(int[] input) {
    for(var i = 0; i < input.Length; i++)
        Console.Write(input[i] + ", ");
}
int [] a =  new int []{1,2,3,4,5};
PrintArray (a);
Console.WriteLine();
int [] b = ArrayCopy (a);
PrintArray (b);
