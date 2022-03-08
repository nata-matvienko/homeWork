// 42. Определить, сколько чисел больше 0 введено с клавиатуры

Console.Write("Введите числа: ");
string[] n = Console.ReadLine().Split(' ');
int[] array = new int[n.Length];
int count = 0;
for (int i = 0; i < n.Length; i++)
{
    array[i] = Convert.ToInt32(n[i]);
    if (array[i] > 0)
    count++;   
}
Console.WriteLine($"Введено {count} чисел > 0");