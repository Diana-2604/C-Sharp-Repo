// Задача 54: Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива.

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

int [] mass = new int[n];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        mass[j] = array[i,j];
    }
    Array.Sort(mass);
    Array.Reverse(mass);
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = mass[j];
    }
}

Console.WriteLine();
PrintArray(array);




