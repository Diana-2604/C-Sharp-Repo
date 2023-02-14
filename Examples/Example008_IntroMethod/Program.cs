// Find the biggest of 9 numbers

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 432;
int b1 = 332;
int c1 = 90;
int a2 = 78;
int b2 = 78954;
int c2 = 65;
int a3 = 654;
int b3 = 4783;
int c3 = 956;

int max = Max(
    Max(a1, b1, c1),
    Max(a2, b2, c2),
    Max(a3, b3, c3));

Console.WriteLine(max);