// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

string NumberNatural(int M, int N)
{
    if (M == N) return $"{M}";
    return $"{M}, " + NumberNatural(M + 1, N) ;
}

Console.Clear();
Console.Write("Введите число M = ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите число N = ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine();
Console.WriteLine(NumberNatural(M, N));