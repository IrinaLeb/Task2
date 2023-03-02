// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int Sqr(int A, int B)
{
    if (B == 0) return 1;
    return Sqr(A, B - 1) * A;
}

Console.Clear();
Console.Write("Введите число A = ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("Введите число B = ");
int B = int.Parse(Console.ReadLine()!);
Console.WriteLine(Sqr(A, B));