// Задача 56: Задайте прямоугольный двумерный массив. Напишите
// программу, которая будет находить строку с наименьшей суммой элементов.

int m = 3, n = 4;
int[,] array = new int[m,n];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = new Random().Next(0,10);
    }
}

void PrintArray (int[,] col)
{
    for (int i = 0; i < col.GetLength(0); i++)
    {
        for (int j = 0; j < col.GetLength(1); j++)
        {
            Console.Write(col[i,j] + " ");
        }
        Console.WriteLine();
    }
}

PrintArray(array);

Console.WriteLine();

int[] sums = new int[n];

for (int i = 0; i < array.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum = sum + array[i,j];
    }
    sums[i] = sum;
}
int minSum = sums[0];
int minPosition = 0;

for (int i = 0; i < sums.Length-1; i++)
{
    if (sums[i] < minSum)
    {
        minSum = sums[i];
        minPosition = i;
    }
    Console.WriteLine ($"Line {i+1} has the sum {sums[i]}");
}

Console.WriteLine();
Console.WriteLine($"Line {minPosition+1} has the minimum sum: {minSum}");
