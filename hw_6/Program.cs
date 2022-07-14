// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// 1 Variant. Ввод чисел с клавиатуры
/*
Console.WriteLine("Введите колличество значений M: ");
int arraySize = int.Parse(Console.ReadLine());
int[] arrayNew = new int[arraySize];

for (int i = 0; i < arrayNew.Length; i++)
{
    Console.Write($"Введите элемент массива {i+1}: ");
    arrayNew[i] = int.Parse(Console.ReadLine());
}

int count = 0;
foreach (int x in arrayNew)
    if (x > 0) count++; 
Console.Write("\nКоличество чисел больше 0 = {0}", count);
*/

// 2 Variant. Через создание рандомного массива
/*
Console.WriteLine("Введите размер массива: ");
int arraySize = int.Parse(Console.ReadLine());
int[] arrayNew = new int[arraySize];

for (int i = 0; i < arrayNew.Length; i++)
{
    int num = new Random().Next(-40, 40);
    arrayNew[i] = num;
    Console.Write("{0, 4}", arrayNew[i]);
}

int count = 0;
foreach (int x in arrayNew)
    if (x > 0) count++; 
Console.Write("\n Количество чисел больше 0 = {0}", count);
*/

// =========================================================================================================

// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//  значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
// x = (b2 -b1)/(k1 - k2), y = k2 * x + b2

/*
int b1 = new Random().Next(-10, 10);
int k1 = new Random().Next(-10, 10);
int b2 = new Random().Next(-10, 10);
int k2 = new Random().Next(-10, 10);
Console.Write("b1 = {0}, k1 = {1}, b2 = {2}, k2 = {3}", b1, k1, b2, k2);

if (k1 == k2 && b1 == b2) Console.WriteLine(" -> Прямые совпадают");
else if (k1 == k2) Console.WriteLine(" -> Прямые не пересекаются");
else
{
    int x = (b2 - b1) / (k1 - k2);
    int y = k2 * x + b2;
    Console.Write($" -> ({x}; {y})");
}
*/

// ==============================================================================================================

// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

/*
Console.Write("Введите число N: ");
int decN = Convert.ToInt32(Console.ReadLine());
int tempNumM = 0;
string strNumBinary = "";
Console.Write(decN);
while(decN > 0)
{
    tempNumM = decN % 2;
    strNumBinary = tempNumM + strNumBinary;
    decN = decN / 2;
}
Console.Write($" -> {strNumBinary}");
*/
// ==================================================================================================================

// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

/*
void fibonacciNumber(int number)
{
    int firstNum = 0;
    int secondNum = 1;
    int temporaryNum = 0;

    Console.Write(firstNum + " ");
    for (int i = 0; i < number-1; i++)
    {
        Console.Write(secondNum + " ");
        temporaryNum = secondNum;
        secondNum = secondNum + firstNum;
        firstNum = temporaryNum;
    }
}
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
fibonacciNumber(N);
*/
// =======================================================================================================

// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

Console.WriteLine("Введите размер массива: ");
int arraySize = int.Parse(Console.ReadLine());
int[] arrayOrginal = new int[arraySize];

for (int i = 0; i < arrayOrginal.Length; i++)
{
    int num = new Random().Next(-40, 40);
    arrayOrginal[i] = num;
    Console.Write("{0, 4}", arrayOrginal[i]);
}
Console.WriteLine();
int[] arrayCopy = new int[arrayOrginal.Length];
for (int i = 0; i < arrayOrginal.Length; i++)
{
    arrayCopy[i] = arrayOrginal[i];
    Console.Write("{0, 4}", arrayCopy[i]);
}


