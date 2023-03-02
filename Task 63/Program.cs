// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

string NumberFor(int N)
{
    if (N == 1) return $"{1}";
    return NumberFor(N - 1) + $", {N}";
}

Console.Clear();
Console.Write("Введите число N = ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine();
Console.WriteLine(NumberFor(N));
