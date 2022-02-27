// 38. Найти сумму чисел 1 мерного массива, стоящих на нечетной позиции.

int sum = 0;
int [] array = new int[9];
Console.WriteLine("Задан массив: ");
for (int index = 0; index<array.Length; index++)
{
    array [index] = new Random().Next(1, 100);
    Console.Write($"{array[index]}, ");
    if (index%2==0)
        sum = sum + array[index];
}
Console.WriteLine($"Сумма чисел массива из нечетных позиций = {sum}");

