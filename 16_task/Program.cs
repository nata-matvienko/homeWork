// Дано число, обозначающее день недели. Выяснить является ли № дня выходным.

int numberX = new Random().Next(1,8);
Console.WriteLine($"Номер дня недели: {numberX}");
int number = numberX / 10;
if(numberX > 5)
{
    Console.WriteLine($"{numberX} день недели - выходной");
}
else
{
    Console.WriteLine($"{numberX} день недели - рабочий");
}
    