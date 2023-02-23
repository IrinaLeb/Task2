// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] GetArray(int row, int col, int minValue, int maxValue)
{
    int[,] result = new int[row, col];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            Console.Write($"{array2D[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

string FindArithm(int[,] array)
{
    double res = 0;
    string result = "Среднее арифметическое число каждoго столбца: ";

    for (int j = 0; j < array.GetLength(1); j++)
    {
        double ArithmSum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            ArithmSum += array[i, j];
        }
        res = ArithmSum / array.GetLength(1);
        result += ($"{res:f1} ");

        if (j != array.GetLength(1) - 1)
        {
            result += "; ";
        }
    }
    return result;
}

Console.Clear();
int[,] inArray = GetArray(5, 5, -10, 10);
PrintArray(inArray);
Console.WriteLine();
Console.WriteLine(FindArithm(inArray));
