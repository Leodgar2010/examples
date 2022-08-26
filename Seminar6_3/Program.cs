// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

string DecimalToBinary(int input) {
    var result = string.Empty;
    var divider = 2;

    int resultLength = 1;
    int temp = input;

    while(temp / divider > 0) {
        resultLength++;
        temp /= divider;
    }

    Console.WriteLine(resultLength);

    int[] resultArray = new int[resultLength]; 

    int index = resultLength - 1;
    while(index > 0) {
        resultArray[index] += input % divider;
        index--;
        input /= divider;
        Console.WriteLine(resultArray[index]);
    }
    resultArray[0] = input;

    for (int i = 0; i < resultArray.Length; i++)
        result += resultArray[i];

    return result;
}

Console.WriteLine("Введите 10-чное число");
if(!int.TryParse(Console.ReadLine()!, out var number)) {
    Console.WriteLine("Всё плохо");
} 

var result = DecimalToBinary(number);

Console.WriteLine("Двоичное представление числа " + number + " есть число " + result);