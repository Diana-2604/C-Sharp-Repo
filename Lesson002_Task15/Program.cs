/* Задача 15: Напишите программу, которая принимает на
вход цифру, обозначающую день недели, и проверяет,
является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

Console.WriteLine("Is this day a weekend?");

int day = new Random().Next(1,8);

Console.WriteLine(day);

if (day >= 1 && day < 6)
{
    Console.WriteLine("no");
}
else
{
    Console.WriteLine("yes");
}