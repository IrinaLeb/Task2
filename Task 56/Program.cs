// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] SearchMinStringArray(int m, int n, int minValue, int maxValue)
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

void PrintArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"{Array[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

void FindMinSumString(int[,] array2D)
{
    int MinRow = 0;
    int MinSumRow = 0;
    int SumRow = 0;

    for (int k = 0; k < array2D.GetLength(1); k++)
    {
        MinRow += array2D[0, k];
    }
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++) SumRow += array2D[i, j];

        if (SumRow < MinRow)
        {
            MinRow = SumRow;
            MinSumRow = i;
        }
        SumRow = 0;
    }
    Console.WriteLine($"Наименьшая сумма элементов равна {MinRow} и находится в {MinSumRow + 1} строке");
}
Console.Clear();
int[,] inArray = SearchMinStringArray(4, 3, 1, 10);
PrintArray(inArray);
Console.WriteLine();
FindMinSumString(inArray);
Console.WriteLine();