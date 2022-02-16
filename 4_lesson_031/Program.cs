// 31. Задать массив из 8 элементов и вывести их на экран


int GetIntFromConsole()
{
    Console.WriteLine("Введите число от 1 до 10:");
    string input = Console.ReadLine();
    return int.Parse(input);
}

int[] ArrayInt(int num)
{
    int[]array = new int [num];
    Random randomNum = new Random();

    for(int i = 0; i<num; i++)
    {
        array[i]=randomNum.Next(1, 10);
    }
    return array;
}
void ArratPrint(int[]array)
{
    for (int i = 0; i<array.Length; i++)
    {
        Console.Write($"{array[i]}");
    }
}
int getInt = GetIntFromConsole();
int[] array = ArrayInt(getInt);
ArratPrint(array);

