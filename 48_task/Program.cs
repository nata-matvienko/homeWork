// Задача 48: Показать двумерный массив
// размером m×n заполненный целыми числами.

void PrintArray(int[,]matrix)
{
    for(int n = 0; n<matrix.GetLength(0); n++)
    {
        for(int m = 0; m<matrix.GetLength(1); m++)
        {
            Console.Write($"{matrix[n,m]}");
        }
    Console.WriteLine();
    }
}
void FillArray(int[,] matrix)
{
    for(int n = 0; n<matrix.GetLength(0); n++)
    {
        for(int m = 0; m<matrix.GetLength(1); m++)
        {
            matrix [n,m] = new Random().Next(1,10);
        }
    }
}
int[,]matrix = new int[4,10];
FillArray(matrix);
PrintArray(matrix);











//Задача 50: В двумерном массиве n×k заменить четные элементы на противоположные.

//Задача 52: В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты.

//Задача 54: В матрице чисел найти сумму элементов главной диагонали.