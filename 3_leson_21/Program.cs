// 21. Программа проверяет пятизначное число на палиндромом.

/* int InPut(string msg)
{
    Console.Write(msg);
    string num1 = console.ReadLine();
    int A = int.Parse(num1);
    return A;
}
int numOne = InPut("Введите пятизначное число: ");
if () */

Console.Write("Введите пятизначное число: ");
string number = Console.ReadLine();
if(int.TryParse(number, out int valueInt))
{
    string resultValue = valueInt.ToString();
    if(resultValue[0]==resultValue[4] && resultValue[1]==resultValue[3])
    Console.WriteLine("ПАЛИНДРОМ");
    else
    Console.WriteLine("НЕ ПАЛИНДРОМ");
}