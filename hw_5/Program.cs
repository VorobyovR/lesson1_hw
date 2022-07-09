// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

/*
int[] GenRndArray(int lenArray, int start, int end)
{
    int[] RndArray = new int[lenArray];
    for (int i = 0; i < lenArray; i++)
    {
        RndArray[i] = new Random().Next(start, end + 1);
    }
    return RndArray;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.Clear();
Console.Write("Input length of massive: ");
int arrayLen = Convert.ToInt32(Console.ReadLine());

Console.Write("Input start number of massive: ");
int startNumber = Convert.ToInt32(Console.ReadLine());
if(startNumber < 100 || startNumber > 999) Console.WriteLine("Wrong number");
else Console.Write("Input end number of massive: ");
int endNumber = Convert.ToInt32(Console.ReadLine());
if(endNumber < 100 || endNumber > 999) Console.WriteLine("Wrong number");
else Console.WriteLine("You`re incredible!");

int[] newArray = GenRndArray(arrayLen, startNumber, endNumber);
PrintArray(newArray);

int coutEvenNumbers = 0;
for (int i = 0; i < newArray.Length; i++)
{
    if(newArray[i] % 2 == 0)
    {
        coutEvenNumbers++;
    }
}
Console.WriteLine("Количество чётных чисел в массиве: {0}", coutEvenNumbers);
*/

// =========================================================================================================================

// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

/*
int[] GenRndArray(int lenArray, int start, int end)
{
    int[] RndArray = new int[lenArray];
    for (int i = 0; i < lenArray; i++)
    {
        RndArray[i] = new Random().Next(start, end + 1);
    }
    return RndArray;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length-1; i++)
    {
        Console.Write(array[i]+" ");
    }
    Console.WriteLine();
}

Console.Clear();
Console.Write("Input length of massive: ");
int arrayLen = Convert.ToInt32(Console.ReadLine());

Console.Write("Input start number of massive: ");
int startNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Input end number of massive: ");
int endNumber = Convert.ToInt32(Console.ReadLine());

int[] newArray = GenRndArray(arrayLen, startNumber, endNumber);
PrintArray(newArray);

int[] coutEvenNumbers = new int[arrayLen];
int resultSum = 0;
for (int i = 1; i < newArray.Length; i+=2)
{
    coutEvenNumbers[i] = newArray[i];  
}
for (int i = 0; i < coutEvenNumbers.Length; i++)
{
    resultSum = resultSum + coutEvenNumbers[i];
}
Console.Write("Сумма чисел с нечетными индексами: {0}", resultSum);
*/

// ==========================================================================================================================

// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] GenRndArray(int lenArray, int start, int end)
{
    int[] RndArray = new int[lenArray];
    for (int i = 0; i < lenArray; i++)
    {
        RndArray[i] = new Random().Next(start, end + 1);
    }
    return RndArray;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length-1; i++)
    {
        Console.Write(array[i]+" ");
    }
    Console.WriteLine();
}

Console.Clear();
Console.Write("Input length of massive: ");
int arrayLen = Convert.ToInt32(Console.ReadLine());

Console.Write("Input start number of massive: ");
int startNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Input end number of massive: ");
int endNumber = Convert.ToInt32(Console.ReadLine());

int[] newArray = GenRndArray(arrayLen, startNumber, endNumber);
PrintArray(newArray);

int numMax = newArray[0];
int numMin = newArray[0];
for (int i = 0; i < newArray.Length; i++)
{
    if(newArray[i] > numMax) numMax = newArray[i];
}
for (int i = 0; i < newArray.Length; i++)
{
    if(newArray[i] < numMin) numMin = newArray[i];
}
Console.WriteLine("Difference between the maximum and minimum numbers: {0}", numMax-numMin);
