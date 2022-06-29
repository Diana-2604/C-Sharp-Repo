// Задача 50: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int m = 3, n = 4;
int[,] array = new int[m,n];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = new Random().Next(0,10);
        Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
}

void Position (int a, int b)
{
    if (a <= m && b <= n) Console.WriteLine(array[a,b]);
    else Console.WriteLine("there is no element with such number in the array");
}

Console.Write ("(0,0) -> ");
Position(0,0); // позиции элементов в массиве начинаются с (0,0)

Console.Write ("(2,2) -> ");
Position(2,2); 

Console.Write ("(1,7) -> ");
Position(1,7); 




