// Задача 38: Задайте массив вещественных чисел. Найдите
// разницу между максимальным и минимальным
// элементов массива.

double[] arr = new double[5]; // new array with 5 double elements

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().NextDouble() * 100; // fill array with random double (0,100)
    Console.WriteLine(arr[i].ToString("F2")); // print array with two digits after the decimal point
}

Console.WriteLine("Difference between max and min: ");

double maxNum = arr[0];
double minNum = arr[0];

for (int i = 1; i < arr.Length; i++)
{
    if (arr[i] > maxNum) { maxNum = arr[i]; }
    else if (arr[i] < minNum) { minNum = arr[i]; }
}

double diff = maxNum - minNum;

Console.WriteLine($"{maxNum.ToString("F2")} - {minNum.ToString("F2")} = {diff.ToString("F2")}");
