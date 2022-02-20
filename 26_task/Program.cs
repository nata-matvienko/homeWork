// 26. Возведите число А в натуральную степень В, используя цикл

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("Введите степень: ");
int n = int.Parse(Console.ReadLine());    
double exp = Exponentiation(num, n);
double Exponentiation( int num, int n)
{
    double exp = 1;
    for (int i=0; i<n; i++)
    {
        exp = exp*num;
    }
    return exp;
}
Console.WriteLine(exp);
   

/* РАБОЧИЙ НО БЕЗ ЦИКЛА!!!

Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите степень: ");
int b = int.Parse(Console.ReadLine());
//int res =num;
double result = Math.Pow(a, b);
Console.WriteLine($"{a}^{b}={result}");   */

