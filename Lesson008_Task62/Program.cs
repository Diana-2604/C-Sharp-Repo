// Задача 62: Заполните спирально массив 4 на 4.

int m = 4, n = 4;
int[,] array = new int[m,n];
int number = 1;

// 1 to 4
for (int i = 0; i < array.GetLength(0)/m; i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = number++;
    }
}

// 4 to 7
for (int j = n-1; j < array.GetLength(1); j++)
{
    for (int i = 1; i < array.GetLength(0); i++)
    {
       array[i,j] = number++; 
    }
}

// 7 to 10
for (int i = m-1; i < array.GetLength(0); i++)
{
    for (int j = n-2; 0 <= j; j--)
    {
        array[i,j] = number++;
    }
}

// 10 to 12
for (int j = 0; j < array.GetLength(1)/n; j++)
{
    for (int i = m-2; 0 <= i-1; i--)
    {
        array[i,j] = number++;
    }
}

// 12 to 14
for (int i = 1; i < array.GetLength(0)/m+1; i++)
{
    for (int j = 1; j < array.GetLength(1)-1; j++)
    {
        array[i,j] = number++;
    }
}

//14 to 15
for (int j = n-2; j < array.GetLength(1)-1; j++)
{
    for (int i = 2; i < array.GetLength(0)-1; i++)
    {
       array[i,j] = number++; 
    }
}

//15 to 16
for (int i = m-2; i < array.GetLength(0)-1; i++)
{
    for (int j = n-3; 0 <= j-1; j--)
    {
        array[i,j] = number++;
    }
}

void PrintArray (int[,] col)
{
    for (int i = 0; i < col.GetLength(0); i++)
    {
        for (int j = 0; j < col.GetLength(1); j++)
        {
            //Console.Write($"{col[i,j]} [{i},{j}]" + "\t");
            Console.Write(col[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

PrintArray(array);

Console.WriteLine();
