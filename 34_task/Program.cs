// 34. Написать программу замены элементов массива на противоположные.

int [] array = {3, 1, 5, -7, 13};
void result (int[]array)
{
    for (int index=0; index < array.Length; index++)
    {
        array[index] = array[index] * -1;
        Console.Write($"{array[index]}, ");
    }
}
result(array);             