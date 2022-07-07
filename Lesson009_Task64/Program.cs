// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все
// натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 5, 6, 7, 8"
// M = 8; N = 4. -> "8, 7, 6, 5, 4"

int Function(int n, int m)
{
    Console.Write(n + " ");
    if (n == m) return n;
    if (n < m) return Function(++n, m);
    else return Function(--n, m);
}

Console.Write("M = 1, N = 5: A = ");
Function(1, 5);

Console.WriteLine("\n");

Console.Write("M = 4, N = 8: A = ");
Function(4, 8);

Console.WriteLine("\n");

Console.Write("M = 8, N = 4: A = ");
Function(8, 4);
