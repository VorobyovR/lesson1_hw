// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8


/*
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
Console.WriteLine("----------------------");

for (int i = 0; i < arrayResult.GetLength(0); i++)
{
    for (int j = 0; j < arrayResult.GetLength(1); j++)
    {
        for (int m = j + 1; m < arrayResult.GetLength(1); m++)
        {
            if(arrayResult[i, m] > arrayResult[i, j])
            {
                int tempNumber = arrayResult[i, j];
                arrayResult[i, j] = arrayResult[i, m];
                arrayResult[i, m] = tempNumber;
            }
        }

    }

}
ShowArray(arrayResult);
Console.ReadKey();
*/

// ================================================================================================================

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

/*
Console.Clear();

int[,] GetNewArray(int row, int column, int minValue, int maxValue)
{
    int[,] result = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
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

Console.Write("Введите количество строк массива M: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива N: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write($"M = {rows}, N = {columns}");
int minNumber = new Random().Next(1);
int maxNumber = new Random().Next(100+1);
Console.WriteLine();

int[,] resultArray = GetNewArray(rows, columns, minNumber, maxNumber);
ShowArray(resultArray);
Console.WriteLine("----------------------");

int firstMinSum = 0;
int result = 0;
for (int i = 0; i < resultArray.GetLength(1); i++)
{
    firstMinSum += resultArray[0, i];
}
for (int i = 1; i < resultArray.GetLength(0); i++)
{
    int secondMinSum = 0;
    for (int j = 0; j < resultArray.GetLength(1); j++)
    {
        secondMinSum+= resultArray[i, j];
    }
    if(firstMinSum > secondMinSum)
    {
        firstMinSum = secondMinSum;
        result = i;
    }
}
Console.Write("Номер строки с минимальным значением = ");
Console.Write(result);
Console.ReadKey();
*/

// =================================================================================================================

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2  
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

/*
Console.Clear();

int[,] GetNewArray(int row, int column, int minValue, int maxValue)
{
    int[,] result = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
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

Console.Write("Введите количество столбцов массива равное количеству строк: ");
int columns = Convert.ToInt32(Console.ReadLine());

int minNumber = new Random().Next(5);
int maxNumber = new Random().Next(20);

int[,] arrayFirst = GetNewArray(rows, columns, minNumber, maxNumber);
ShowArray(arrayFirst);
Console.WriteLine("----------------------");
int[,] arraySecond = GetNewArray(rows, columns, minNumber, maxNumber);
ShowArray(arraySecond);
Console.WriteLine("----------------------");

int[,] arrayResult = new int[rows, columns];
for (int i = 0; i < arrayResult.GetLength(0); i++)
{
    for (int j = 0; j < arrayResult.GetLength(1); j++)
    {
        arrayResult[i, j] = arrayFirst[i, j] * arraySecond[i, j];
    }
}
ShowArray(arrayResult);
Console.ReadKey();
*/

// =================================================================================================================

// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)
/*
Console.Clear();
Console.Write("Введите размеры массива через пробел: ");
string[] nums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

int[,,] array = GetArray(new int[] { int.Parse(nums[0]), int.Parse(nums[1]), int.Parse(nums[2])}, 10, 99);
PrintArray(array);

int[,,] GetArray(int[] size, int min, int max)
{
    int[,,] result = new int[size[0], size[1], size[2]];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            int k = 0;
            while(k < result.GetLength(2))
            {
                int element = new Random().Next(min, max + 1);
                if(FindElement(result, element)) continue;
                result[i, j, k] = element;
                k++;
            }
        }
    }
    return result;
}

bool FindElement(int[,,] array, int el )
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if(array[i, j, k] == el) return true;
            }
        }
    }
    return false;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i}, {j}, {k}");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
*/

// ===================================================================================================================

// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

Console.Clear();
Console.Write($"Введите размер матрицы: ");
int size = Convert.ToInt32(Console.ReadLine());
int[,] arr = GetArray(size);
PrintArray(arr);

int[,] GetArray(int size);
{
    int[,] result = new int[size, size];
    int i = 0;
    int j = 0;
    int rowE = size - 1;
    int columnE = size - 1;
    int rowS = 0;
    int columnS = 0;
    bool left = true;
    bool top = true;
    int count = 0;
    while (count < size * size)
    {
        count++;
        result[i, j] = count;
        //идем вправо
        if (left && top)
        {
            if (j == columnE)
            {
                rowS++;
                top = true;
                left = false;
                i++;
                continue;
            }
            else
            {
                j++;
                continue;
            }
        }
        //идем вниз
        if (left && top)
        {
            if (i == rowE)
            {
                columnE--;
                top = false;
                left = false;
                j--;
                continue;
            }
            else
            {
                i++;
                continue;
            }
        }
        //идем влево
        if (left && top)
        {
            if (j == columnS)
            {
                rowE--;
                top = false;
                left = true;
                i--;
                continue;
            }
            else
            {
                j--;
                continue;
            }
        }
        //идем вверх
        if (left && top)
        {
            if (i == rowS)
            {
                columnS++;
                top = true;
                left = true;
                j++;
                continue;
            }
            else
            {
                i--;
                continue;
            }
        }
    }
    return result;

}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}");
        }
        Console.WriteLine();
    }
}


