// fill array with random numbers and find index of needed result

void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1, 10); // fill with random numbers from 1 to 10
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0; // -1 for the cases when the needed result is absent
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = 0;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; // create array with 10 elements

FillArray(array);
PrintArray(array);

Console.WriteLine();

int pos = IndexOf(array, 8); // find element 8
Console.WriteLine(pos);