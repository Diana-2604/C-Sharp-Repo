// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Enter first number: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Enter second number: ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Enter third number: ");
int c = int.Parse(Console.ReadLine());

if (a > b & a > c)
{
    Console.WriteLine("Max = " + a);
}

if (b > a & b > c)
{
    Console.WriteLine("Max = " + b);
}

if (c > a & c > b)
{
    Console.WriteLine("Max = " + c);
}

if (a == b | b == c | c == a)
{
    Console.WriteLine("More than one max");
}
