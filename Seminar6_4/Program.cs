//Решение в группах задач:
//Задача 44: Не используя рекурсию, выведите 
//первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
//Если N = 5 -> 0 1 1 2 3
//Если N = 3 -> 0 1 1
//Если N = 7 -> 0 1 1 2 3 5 8
void Fibonacci (int n)
{
    int [] arr = new int [n];
    arr [0] = 0;
    arr [1] = 1;
    Console.Write ($"{arr[0]}, {arr[1]}, ");
    for (int i=2; i <n; i++)
    {
         arr [i] = arr[i-1]+ arr[i-2]; 
         Console.Write ($"{arr[i]}, "); 
    }
}
Fibonacci (20);