// 17. По двум заданным числам проверить является ли одно квадратом другого.
int InPut(string msg)
{
    Console.WriteLine(msg);
    string num1 = Console.ReadLine();
    int A = int.Parse(num1);
    return A;
}
int numOne = InPut("Введите первое число: ");
int numTwo = InPut("Введите второе число: ");
if(numOne==numTwo*numTwo)
{
    Console.WriteLine($"{numOne} является квадратом числа {numTwo}");
}
else 
if (numTwo==numOne*numOne)
{
    Console.WriteLine($"{numTwo} является квадратом числа {numOne}");
}
else
{
    Console.WriteLine("Ни одно из чисел не является квадратом другого");
}
