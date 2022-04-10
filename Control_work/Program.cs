/* Написать программу, которая из имеющегося массива строк формирует массив из строк, длинна <=3 символа.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами. */

string [] array = new string [] {"Hello","2","world",":-)","1234", "-2","Russia","ok"};
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length<=3)
        Console.Write($"[{array[i]}], ");
    else
        count++;
}
string [] newArray = new string [count];
Console.WriteLine();
