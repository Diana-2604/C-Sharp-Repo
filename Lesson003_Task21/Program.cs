// Задача 21: Напишите программу, которая принимает на
// вход координаты двух точек и находит расстояние между
// ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Please enter X1: ");
int X1 = int.Parse(Console.ReadLine());

Console.WriteLine("Please enter Y1: ");
int Y1 = int.Parse(Console.ReadLine());

Console.WriteLine("Please enter Z1: ");
int Z1 = int.Parse(Console.ReadLine());

Console.WriteLine("Please enter X2: ");
int X2 = int.Parse(Console.ReadLine());

Console.WriteLine("Please enter Y2: ");
int Y2 = int.Parse(Console.ReadLine());

Console.WriteLine("Please enter Z2: ");
int Z2 = int.Parse(Console.ReadLine());

double sum = Math.Pow(X1 - X2, 2) + Math.Pow(Y1 - Y2, 2) + Math.Pow(Z1 - Z2, 2);

double result = Math.Sqrt(sum);

Console.WriteLine(Math.Round(result, 2));