﻿// Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A в натуральную
// степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Func(int a, int b)
{
    int result = 1;

    for (int i = 1; i <= b; i++)
    {
        result *= a;
    }
    return result;
}

Console.WriteLine($"3^5 = {Func(3, 5)}");
Console.WriteLine($"2^4 = {Func(2, 4)}");
