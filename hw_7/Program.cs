// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

/*
Console.Clear();
Console.Write("Введите количество строк массива M: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов массива N: ");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] resultArray = new double[rows, columns];

Random random = new Random();
Random random1 = new Random();
Console.Write($"M = {rows}, N = {columns}");
Console.WriteLine();
for (int i = 0; i < resultArray.GetLength(0); i++)
{
    for (int j = 0; j < resultArray.GetLength(1); j++)
    {
        resultArray[i, j] = random.NextDouble() * 10 * random1.Next(-5, 5); 
        Console.Write("{0,10:F2}", resultArray[i, j]);
    }
    Console.WriteLine();
}
Console.ReadKey();
*/

// ================================================================================================================================================

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет

/*
Console.Clear();
Console.Write("Введите количество строк массива M: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива N: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] resultArray = new int[rows, columns];
Random random = new Random();
Console.Write($"M = {rows}, N = {columns}");
Console.WriteLine();

for (int i = 0; i < resultArray.GetLength(0); i++)
{
    for (int j = 0; j < resultArray.GetLength(1); j++)
    {
        resultArray[i, j] = random.Next(-100, 100);
        Console.Write("{0,5}", resultArray[i, j]);
    }
    Console.WriteLine();
}

Console.Write("Введите индекс по строкам массива для поиска значения(M): ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс по столбцам массива для поиска значения(N):");
int N = Convert.ToInt32(Console.ReadLine());

if (M < resultArray.GetLength(0) && N < resultArray.GetLength(1)) Console.Write("Число = {0}", resultArray[M, N]);
else Console.Write($"M = {M}, N = {N} - такого числа в массиве нет");

Console.ReadKey();
*/

// ================================================================================================================================================

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

int[,] GetNewArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void ShowArray(int[,] inArray)
{
    for (int row = 0; row < inArray.GetLength(0); row++)
    {
        for (int column = 0; column < inArray.GetLength(1); column++)
        {
            Console.Write("{0,5}", inArray[row, column]);
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
int minNumber = new Random().Next(10);
int maxNumber = new Random().Next(100);

int[,] arrayResult = GetNewArray(rows, columns, minNumber, maxNumber);
ShowArray(arrayResult);


double avrNumCol = 0;
int count = 0;
for (int j = 0; j < arrayResult.GetLength(1); j++)
{
    for (int i = 0; i < arrayResult.GetLength(0); i++)
    {
        avrNumCol += arrayResult[i, j];
    }
    avrNumCol = avrNumCol / rows;
    Console.Write($" Столбец {count}");
    Console.Write(" -> средне-арифметическое значение элементов в столбце = ");
    Console.Write("{0:f2}", avrNumCol);
    Console.WriteLine();
    count++;
}
Console.ReadKey();




