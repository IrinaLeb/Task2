// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

void SortfromMaxtoMin(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            for (int k = 0; k < array2D.GetLength(1) - 1; k++)
            {
                if (array2D[i, k] < array2D[i, k + 1])
                {
                    int temp = array2D[i, k + 1];
                    array2D[i, k + 1] = array2D[i, k];
                    array2D[i, k] = temp;
                }
            }
        }
    }
}

Console.Clear();
int[,] inArray = GetArray(5, 5, 1, 10);
Console.WriteLine("Исходный массив:");
PrintArray(inArray);
Console.WriteLine();
Console.WriteLine("Упорядоченный массив по убыванию элементов:");
SortfromMaxtoMin(inArray);
PrintArray(inArray);