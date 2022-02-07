// Дано число. Проверить кратно ли оно 7 и 23

int number = 152;
if(CheckIfModed(number))
    Console.WriteLine($"Число {number} делится на 7 и на 23");
else
    Console.WriteLine($"Число {number} не делится на 7 и на 23");

bool CheckIfModed(int number)
{
    return number % 7 == 0 && number % 23 ==0;
}