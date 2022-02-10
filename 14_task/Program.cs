// 14. Найти 3ю цифру числа или сообщить что ее нет.

 /* int numberX = new Random().Next(0,1000);
Console.WriteLine($"Случайное число: {numberX}");
int number = numberX / 10;
if(number >= 10)
{
    Console.WriteLine($"Третья цифра = {numberX%10}");
}
else
{
    Console.WriteLine($"Третья цифра отсутствует");
} */

// не учитывает возможность числа из более, чем 3 цифр

Console.WriteLine("Введите число: ");
string numberStr = Console.ReadLine();
if (int.TryParse(numberStr, out int numberInt))
{
    string resultNumber = numberInt.ToString();
    if(resultNumber.Length >= 3)
        Console.WriteLine($"Третья цифра числа: {resultNumber[2]}");
    else
        Console.WriteLine("Число не трехзначное");
}
else
    Console.WriteLine("Ввели не число");

// Преобразование из string в int
/* 
    int.Parse("232323) -- возвращает int
    Convert.ToInt32("34343434") -- возвращает int
    int.TryParse("dfdf", out int valueInt) -- возвращает тип bool;
*/