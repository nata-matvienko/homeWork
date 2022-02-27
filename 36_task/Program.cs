// 36. Задать массив, заполнить его случайными положительными 3-х значными числами. 
// Показать количество нечетных/четных чисел.

int even = 0;
int odd = 0;
int [] array = new int[9];

Console.WriteLine("Задан массив: ");
for (int index = 0; index<array.Length; index++)
{
    array [index] = new Random().Next(100, 1000);
    Console.Write($"{array[index]}, ");
    if (array [index]%2==0)
        even = even + 1;
    else
        odd = odd + 1;
}
Console.WriteLine($"Четных чисел: {even}");
Console.WriteLine($"Нечетных чисел: {odd}");
