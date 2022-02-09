// Удалить 2ю цифру 3х значного числа.

int numberABC = new Random().Next(100,999);
Console.WriteLine($"Случайное число: {numberABC}");
int numberA = numberABC / 100;
int numberC = numberABC % 10;

Console.WriteLine($"{numberA}{numberC}");
