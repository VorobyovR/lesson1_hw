// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// void palindrome(int number)
// {
//     int number5 = number % 10;
//     int number4 = number / 10 % 10;
//     int number3 = number / 100 % 10;
//     int number2 = number / 1000 % 10;
//     int number1 = number / 10000 % 10;

//     if (number1 == number5)
//     {
//         if (number2 == number4)
//         {
//             Console.WriteLine(number + " -> " + "It is a palindrome number");
//         }
//     }
//     else
//     {
//         Console.WriteLine(number + " -> " + "It isn't a palindrome number");
//     }
// }

// Console.Write("Input number : ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number > 9999 && number <= 99999)
// {
//     palindrome(number);
// }
// else
// {
//     Console.Write("Input a right number!");
// }


// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// void lengthpoints(int numberA1, int numberA2, int numberA3, int numberB1, int numberB2, int numberB3)
// {
//     double finalLength = Math.Sqrt(Math.Pow((numberA1 - numberB1), 2) + Math.Pow((numberA2 - numberB2), 2) + Math.Pow((numberA3 - numberB3), 2));
//     Console.WriteLine("L = " + Math.Round(finalLength, 2));
// }

// Console.Write("Input number A1: ");
// int numberA1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number A2: ");
// int numberA2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number A3: ");
// int numberA3 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input number B1: ");
// int numberB1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number B2: ");
// int numberB2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number B3: ");
// int numberB3 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("A (" + numberA1 + ", " + numberA2 + ", " + numberA3 + ")");
// Console.WriteLine("B (" + numberB1 + ", " + numberB2 + ", " + numberB3 + ")");

// lengthpoints(numberA1, numberA2, numberA3, numberB1, numberB2, numberB3);


// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Input number N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
double num2 = 0;
if (numberN >= 0)
{
    for (int num = 1; num <= numberN; num++)
    {
        num2 = Math.Pow(num, 3);
        Console.Write(num2 + " ");
    }
}
else if (numberN < 0)
{
    for (int num = -1; num >= numberN; num--)
    {
        num2 = Math.Pow(num, 3);
        Console.Write(num2 + " ");
    }
}
