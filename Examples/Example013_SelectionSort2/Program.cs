// Алгоритм «Сортировка выбором»
// ["Igor", "Ira", "Ivan", "Alexander", "Ruslan"] --> [Ira, Igor, Ivan, Ruslan, Alexander]

Console.WriteLine("Введите строки для сортировки: ");
string[] array = new string[5];
for (int i = 0; i < 5; i++)
{
    array[i] = Console.ReadLine();
}
Console.WriteLine("Начальный массив: [" + string.Join(", ", array) + "]");

for (int i = 0; i < 4; i++)
{
    int MinIndex = i;
    for (int j = i + 1; j < 5; j++)
    {
        if (array[j].Length < array[MinIndex].Length)
            MinIndex = j; 
    }
    string temp;
    temp = array[MinIndex];
    array[MinIndex] = array[i];
    array[i] = temp;
}
Console.WriteLine("Конечный массив: [" + string.Join(", ", array) + "]");
