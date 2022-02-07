// Выяснить кратно ли число заданному, если нет, вывести остаток

int GetNumber()
{
    int randomNumber = new Random().Next(20,100);
    return randomNumber;
}
void isMultiple(int firstNumber, int secondNumber)
{
    if (firstNumber>secondNumber)
    {
        int result = firstNumber%secondNumber;
        if (result == 0)
            Console.WriteLine("Первое число кратно второму");
        else
        Console.WriteLine($"Остаток: {result}");
    }
    else
    {
        int result = secondNumber%firstNumber;
        if (result == 0)
            Console.WriteLine("Второе число кратно первому");
        else
        Console.WriteLine($"Остаток: {result}");
    }
}
int number = GetNumber();
Console.WriteLine($"Случайное число {number}");

int secondNumber = GetNumber();
Console.WriteLine($"Второе случайное число: {secondNumber}");
isMultiple(number, secondNumber);

