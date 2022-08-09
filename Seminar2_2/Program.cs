// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98
Random random = new Random ();
int random_number = random.Next(100, 1000);
Console.WriteLine (random_number);
int first_digit = random_number % 100;
int second_digit = first_digit % 10;
int third_digit = random_number/100;
Console.WriteLine ("Результат "+third_digit+second_digit);

