// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int SumDig(int N)
{
    if (N == 0) return 0;
    return N % 10 + SumDig(N / 10);
}

Console.Clear();
Console.Write("Введите число N = ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine(SumDig(N));