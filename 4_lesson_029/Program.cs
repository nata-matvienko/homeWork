// 29. Написать программу вычисления произведения чисел от 1 до N

int InPut(string msg)
{
    Console.Write(msg);
    string num1 = Console.ReadLine();
    int A = int.Parse(num1);
    return A;
}
int multiple(int number)
{
    int result = 1;
    for(int i = 1; i<number; i++)
    {
        result = i * result;
    }
    return result;
}
int number = InPut("Введите число N: ");
int resultofmultiple = multiple(number);

Console.WriteLine(resultofmultiple);