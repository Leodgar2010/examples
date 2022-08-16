// Задача 30: Напишите программу, 
// которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]
//int [] arr ={1,5,4,3,2,6,7,1,1};
 int [] ArrayWith0and1 ()
 {
    int [] result = new int[8]; 
    var random = new Random (); 
    for (int i=0; i<8; i++)
        {
            result  [i]= random.Next(0,2);
        }
    return result;
 }
 var a= ArrayWith0and1();
for (int i = 0; i < 8; i++)
    Console.WriteLine (a[i]);

// int[] CreateArray()
// {
//     int[] array = new int[8];
//     var random = new Random();

//     for (int i = 0; i < 8; i++)
//         array[i] = random.Next(0, 2);

//     return array;
// }

// var array = CreateArray();

// for (int i = 0; i < 8; i++)
//     Console.WriteLine(array[i]);

