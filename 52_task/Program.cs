// Задача 52: В двумерном массиве заменить элементы,
// у которых оба индекса чётные на их квадраты.

int [,] matrix = new int [3,4];
for (int n=0; n<3; n++)
{
    for (int k=0; k<4; k++)
    {
        matrix[n,k]=new Random().Next(1,10);
        if (n % 2 == 0 && k % 2 == 0)
            {
                matrix[n, k] = matrix[n, k] * matrix[n, k];
            }
        Console.Write($"{matrix[n,k]} ");
    }
    Console.WriteLine();
}
