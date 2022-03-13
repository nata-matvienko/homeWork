// Задача 54: В матрице чисел найти сумму элементов главной диагонали.

int [,] matrix = new int [5,5];
int result = 0;
for (int n=0; n<5; n++)
{
    for (int k=0; k<5; k++)
    {
        matrix[n,k]=new Random().Next(1,10);
        if(n == k) result += matrix[n, k]; 
        Console.Write($"{matrix[n,k]} ");
    }
    Console.WriteLine();
}
Console.WriteLine($"{result}");
