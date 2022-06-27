// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Please enter your numbers separated by space: ");
string s = Console.ReadLine();
string [] nums = s.Split(' ');

int count = 0;

for (int i=0; i < nums.Length; i++)
{
    int num = int.Parse(nums[i]);
    if (num > 0) count++;
}

Console.WriteLine($"Positive numbers entered: {count}");
