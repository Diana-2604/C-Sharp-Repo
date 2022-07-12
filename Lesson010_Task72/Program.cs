// Задача 72: Заданы 2 массива: info и data. В массиве info хранятся двоичные
// представления нескольких чисел (без разделителя). В массиве data хранится
// информация о количестве бит, которые занимают числа из массива info.
// Напишите программу, которая составит массив десятичных представлений чисел
// массива data с учётом информации из массива info.

// входные данные:
// - data = {0, 1, 1, 1, 1, 0, 0, 0, 1 }
// - info = {2, 3, 3, 1 }
// выходные данные:
// - 1, 7, 0, 1

int[] SkipElements (int[] array, int skipAmount)
{
    int [] newArray = new int[array.Length - skipAmount];

    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = array[i + skipAmount];
    }

    return newArray;
}

int DecimalRec (int[] data, int[] info)
{
    if (data.Length == 0 && info.Length == 0)
    {
        return 0;
    }
    
    int amountOfNumbers = info[0];
    string line = string.Empty;

    for (int i = 0; i < amountOfNumbers; i++)
    {
        line += data[i];
    }

    int result = Convert.ToInt32(line, 2);
    Console.Write($"{result} ");

    int[] newData = SkipElements(data, amountOfNumbers);
    int[] newInfo = SkipElements(info, 1);

    return DecimalRec(newData, newInfo);
}

int[] data = {0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] info = {2, 3, 3, 1 };

DecimalRec(data,info);