// Задача 58: Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц.

void FillArray (int[,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            mass[i,j] = new Random().Next(0,10);
        }
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

int k = 2, l = 3;
int[,] matrixA = new int[k,l];

int m = 3, n = 2;
int[,] matrixB = new int[m,n];

Console.WriteLine("Matrix A: ");
FillArray(matrixA);
PrintArray(matrixA);

Console.WriteLine();

Console.WriteLine("Matrix B: ");
FillArray(matrixB);
PrintArray(matrixB);

Console.WriteLine();

int[,] MultiplyMatrix(int[,] matrixA, int[,] matrixB)
{
    int rowsA = matrixA.GetLength(0);
    int columnsA = matrixA.GetLength(1);
    int rowsB = matrixB.GetLength(0);
    int columnsB = matrixB.GetLength(1);

    int [,] multiplication = new int[rowsA, columnsB];
    int temp = 0;
    if (rowsA != columnsB)
    {
        Console.WriteLine("Matrices can't be multiplied : columnsA should be equal to rowsB! ");
    }
    else 
    {
        for (int i = 0; i < rowsA; i++)
        {
            for (int j = 0; j < columnsB; j++)
            {
                temp = 0;
                for (int a = 0; a < columnsA; a++)
                {
                    temp += matrixA[i, a] * matrixB[a, j];
                }
                multiplication[i, j] = temp;
            }
        }
    }
    return multiplication;
}

Console.WriteLine("MatrixA * MatrixB: ");
int[,] result = MultiplyMatrix(matrixA, matrixB);
PrintArray(result);

