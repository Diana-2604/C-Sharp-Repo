// Задача 19: Напишите программу, которая принимает на
// вход пятизначное число и проверяет, является ли оно
// палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.WriteLine("Please enter a five-digit number: ");
string numInput = Console.ReadLine();

Console.WriteLine("Is " + $"{numInput}" + " a palindrome?");

if (numInput[0] == numInput[4] && numInput[1] == numInput[3])
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}





