Random random = new Random ();
int random_number = random.Next(10, 99);
int first_digit = random_number % 10;
int second_digit = random_number / 10;
Console.WriteLine (random_number);
if (first_digit>second_digit)
    Console.WriteLine (first_digit);
else
     Console.WriteLine (second_digit);



