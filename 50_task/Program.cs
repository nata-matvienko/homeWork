//Задача 50: В двумерном массиве n×k заменить четные элементы на противоположные.

int [,] matrix = new int [3,4];
for (int n=0; n<3; n++)
{
    for (int k=0; k<4; k++)
    {
        matrix[n,k]=new Random().Next(1,10);
        if (matrix[n, k] % 2 == 0)
            {
                matrix[n, k] = matrix[n, k] * -1;
            }
        Console.Write($"{matrix[n,k]} ");
    }
    Console.WriteLine();
}

