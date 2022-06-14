// Задача 19: Напишите программу, которая принимает на
// вход пятизначное число и проверяет, является ли оно
// палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.WriteLine("Please enter a five-digit number: ");
int num = int.Parse(Console.ReadLine());

string str = num.ToString(); // преобразовать число в строку - массив

Console.WriteLine("Is " + $"{num}" + " a palindrome?");

if (str[0] == str[4] && str[1] == str[3])
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}





