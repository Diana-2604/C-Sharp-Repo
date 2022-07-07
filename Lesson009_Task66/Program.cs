// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int CalculateSumRecursively(int n, int m)
{
    int sum = n;
    if(n < m)
    {
        n++;
        return sum += CalculateSumRecursively(n, m);
    }
    return sum;
}

int result1 = CalculateSumRecursively(1,15);
Console.WriteLine($"M = 1, N = 15 --> {result1}");

Console.WriteLine();

int result2 = CalculateSumRecursively(4,8);
Console.WriteLine($"M = 4, N = 8 --> {result2}");
