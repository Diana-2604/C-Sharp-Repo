// Find element in an array

int[] array = {32,43,54,6500,43,65,765,75,54};

int n = array.Length;
int find = 54; // find element 5 in the array

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break; // interrupt algorithm when the first example is found
    }
    index++;
}
