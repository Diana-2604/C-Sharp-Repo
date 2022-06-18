// Напишите программу, которая принимает на
// вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Sum(int number)
{
    int result = 0;

    string array = number.ToString();

    for (int i = 0; i < array.Length; i++)
    {
        result += int.Parse(array[i].ToString());
    }
    return result;
}

Console.WriteLine($"452 -> {Sum(452)}");
Console.WriteLine($"82 -> {Sum(82)}");
Console.WriteLine($"9012 -> {Sum(9012)}");