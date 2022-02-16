// 27. определить количество цифр в числе

// 123/10 = 12/10 = 1/10 = 0
//            1       2     3

int GetNumber() // получаем число
{
    int randomNumber = new Random().Next(100, 1000000);
    return randomNumber;
}
int number = GetNumber();
Console.WriteLine(number);

int countofDigit = 0;
while (number != 0)
{
    number = number/10;
    countofDigit++;
}
Console.WriteLine(countofDigit);