// 40. В указанном массиве вещественных чисел найти разницу между max и min элементом

double [] array = new double[9];
double max = 0;
double min = 0;

Random rnd = new Random();
for (int i=0; i<array.Length; i++)
{
    array [i] = rnd.NextDouble()*100;
    if (max > array [i])
        min = array [i];
    else
        max = array[i];
}

for (int j=0; j<array.Length; j++)
{
    if (min > array [j])
        min = array[j];
}
double dif = max-min;
Console.WriteLine($"max={max}");
Console.WriteLine($"min={min}");
Console.WriteLine($"Разница между max и min элементом = {dif}");
