// Напишите программу, которая задаёт массив
// из 8 элементов и выводит их на экран.

int[] array = new int[8];

void FillArray (int[] collection)
{
    int length = collection.Length;
    for (int i = 0; i < length; i++)
    {
        collection[i] = new Random().Next(1,10);
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;

    Console.Write("{ ");

    for (int pos = 0; pos < count; pos++)
    {
        Console.Write($"{col[pos]} ");
    }

    Console.Write("}");
}

FillArray(array);
PrintArray(array);

