// Задача 60: Сформируйте трёхмерный массив из неповторяющихся
// двузначных чисел. Напишите программу, которая будет построчно выводить
// массив, добавляя индексы каждого элемента.

int l = 3, m = 4, n = 5;
int[,,] array = new int[l, m, n];

bool Contains(int[,,] mass, int value)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            for (int k = 0; k < mass.GetLength(2); k++)
            {
                if (mass[i,j,k] == value) return true;
            }
        }
    }   
    return false; 
}

void FillArray (int[,,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            for (int k = 0; k < mass.GetLength(2); k++)
            {
                var next = 0;                
                while (true)
                {
                    next = new Random().Next(10,100);
                    if (!Contains(mass, next)) break;                    
                }
                mass[i,j,k] = next;
            }
        }
    }
}

void PrintArray (int[,,] col)
{
    for (int i = 0; i < col.GetLength(0); i++)
    {
        for (int j = 0; j < col.GetLength(1); j++)
        {
            for (int k = 0; k < col.GetLength(2); k++)
            {
                Console.Write($"{col[i,j,k]} [{i},{j},{k}]   ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

FillArray(array);
PrintArray(array);

