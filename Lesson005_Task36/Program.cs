// Задача 36: Задайте одномерный массив, заполненный
// случайными числами. Найдите сумму элементов, стоящих
// на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] arr = new int[10];

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(-99,100);
    Console.Write($"{arr[i]} ");
}

Console.WriteLine();

int sum = 0;

for (int i = 1; i < arr.Length; i+=2)
{
   sum += arr[i];
}

Console.WriteLine(sum);