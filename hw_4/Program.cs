// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Variant 1

// void degreeOfNumber(int a, int b)
// {
//     double result = Math.Pow(a, b);
//     Console.WriteLine($"{a}, {b} {"->"}  {result}");
//     Console.ReadKey();
// }

// Console.Clear();
// Console.Write("Input number A: ");
// int nunberA = int.Parse(Console.ReadLine());
// Console.Write("Input number B: ");
// int nunberB = int.Parse(Console.ReadLine());

// degreeOfNumber(nunberA, nunberB);

// Variant 2

// for (int i = 0; i < 5; i++)
// {
//     Random numA = new Random();
//     int randomNumA = numA.Next(1, 20);
//     Console.WriteLine("number A = " + randomNumA);
//     Random numB = new Random();
//     int randomNumB = numA.Next(1, 5);
//     Console.WriteLine("number B = " + randomNumB);
//     double result = Math.Pow(randomNumA, randomNumB);
//     Console.WriteLine($"{randomNumA}, {randomNumB} {"->"}  {result}");
// }

// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.Write("Input number N: ");
// int numberN = int.Parse(Console.ReadLine());
// int numberNres = 0;

// int numberSum(int numberN)

// {
//     int numberNres = 0;
//     while (numberN > 0)
//     {
//         numberNres = numberNres + numberN % 10;
//         numberN = numberN / 10;
//     }
//     return numberNres;
// }

// Console.Clear();
// Console.Write("Input number N: ");
// int N = int.Parse(Console.ReadLine());

// Console.WriteLine(numberSum(N));
// Console.ReadKey();


// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] GenRndArray(int start, int end)
{
    int[] RndArray = new int[8];
    for (int i = 0; i < 8; i++)
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
Console.Write("Input first number in randomly generated array: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Input last number in randomly generated array: ");
int num2 = int.Parse(Console.ReadLine());

int[] mayNewRndArray = GenRndArray(num1, num2);
PrintArray(mayNewRndArray);

Console.ReadKey();