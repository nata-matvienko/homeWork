// 10. Показать 2ю цифру 3х значного числа.

int numberABC = new Random().Next(100,999);
Console.WriteLine($"Случайное число: {numberABC}");
int numberB = numberABC%100/10;
Console.WriteLine($"Вторая цифра = {numberB}");
