// Задача 43. Напишите программу, которая найдёт точку
// пересечения двух прямых, заданных уравнениями y = k1 *
// x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
// пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Please enter b1: ");
double b1 = double.Parse(Console.ReadLine());

Console.WriteLine("Please enter k1: ");
double k1 = double.Parse(Console.ReadLine());

Console.WriteLine("Please enter b2: ");
double b2 = double.Parse(Console.ReadLine());

Console.WriteLine("Please enter k2: ");
double k2 = double.Parse(Console.ReadLine());

Console.WriteLine("Find the point of intersection of two lines given by the equations: ");

Console.WriteLine($"y = {k1} * x + {b1}");  
Console.WriteLine($"y = {k2} * x + {b2}");

if ( k1 == k2 && k1 * b2 == k2 * b1 && b2 == b1 )
{
    Console.WriteLine("The lines coincide and have an infinite number of solutions");
}
else if ((k2 - k1) == 0) 
{
   Console.WriteLine("The lines are parallel and there's no point of intersection");
}
else 
{ 
    double x = (b1 - b2) / (k2 - k1);
    Console.WriteLine($"X = {x}");

    double y = (k2 * b1 - k1 * b2) / (k2 - k1);
    Console.WriteLine($"Y = {y}");
}

// Уравнение прямой ax + by + c = 0

// AB a1x + b1y + c1 = 0
// CD a2x + b2y + c2 = 0

// x = (b1 * c2 - b2 * c1) / (a1 * b2 - a2 * b1);
// y = (a2 * c1 - a1 * c2) / (a1 * b2 - a2 * b1);

// a1 --> k1, a2 --> k2, 
// b1 = -1, b2 = -1,
// c1 --> b1, c2 --> b2

// x = ((-1) * b2 - (-1) * b1) / (k1 * (-1) - k2 * (-1)) --> x = (b1 - b2) / (k2 - k1)
// y = (k2 * b1 - k1 * b2) / (k1 * (-1) - k2 * (-1)) --> y = (k2 * b1 - k1 * b2) / (k2 - k1);

// if (a1 * b2 == b1 * a2 && a1 * c2 == a2 * c1 && b1 * c2 == c1 * b2) --> ( k1 == k2 && k1 * b2 == k2 * b1 && b2 == b1 )
// Прямые совпадают и имеют бесконечное количество решений

// if ((a1 * b2 - a2 * b1) == 0) --> ((k2 - k1) == 0) 
// Прямые параллельны другу друг и не имеют точек пересечения

