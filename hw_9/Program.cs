// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""
/*
string numberCountStringRecursive(int start, int end)
{
    if(start == end)
    {
        return start.ToString();
    }
    return start + " " + numberCountStringRecursive(start + 1, end);
}

Console.Clear();
Console.Write("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.Write($"M = {numberM}; N = {numberN} -> ");
Console.Write(numberCountStringRecursive(numberM, numberN));
Console.ReadKey();
*/
// ========================================================================================================================

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
/*
int sumNumbers(int m, int n)
{
    int sumNum = m;
    if (m == n)
    {
        return sumNum;
    }
    else
    {
        return  sumNum + sumNumbers(m + 1, n);
    }
}

Console.Clear();
Console.Write("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.Write($"M = {numberM}; N = {numberN} -> ");
Console.Write(sumNumbers(numberM, numberN));
Console.ReadKey();
*/
// ===================================================================================================================

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

int akkermanMetod(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return akkermanMetod(m - 1, 1);
    }
    else
    {
        return akkermanMetod(m - 1, akkermanMetod(m, n - 1));
    }
}

Console.Clear();
Console.Write("Введите число m: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.Write($"m = {numberM}; n = {numberN} -> ");
Console.Write(akkermanMetod(numberM, numberN));
Console.ReadKey();
