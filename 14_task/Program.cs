// 14. Найти 3ю цифру числа или сообщить что ее нет.

 int numberX = new Random().Next(0,1000);
Console.WriteLine($"Случайное число: {numberX}");
int number = numberX / 10;
if(number >= 10)
{
    Console.WriteLine($"Третья цифра = {numberX%10}");
}
else
{
    Console.WriteLine($"Третья цифра отсутствует");
}

