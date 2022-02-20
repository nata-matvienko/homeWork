// 30.Показать кубы чисел, заканчивающихся на четную цифру


int number = new Random().Next(1,100);
Console.WriteLine ("число: ");
int ostatok= number%2;
if (ostatok == 0)
{
    int result=number*number*number;
    Console.WriteLine($"Куб числа {number}={result}");
}  
else
{
    int number2 = number + 1;
    int result2 = number2*number2*number2;
    Console.WriteLine($"Куб числа {number2}={result2}");
}

