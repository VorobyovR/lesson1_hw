// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// void secondNumM(int number)
// {
//     int secondNum = number / 10 % 10;
//     Console.WriteLine(number + " -> " + secondNum);
// }

// Console.Write("Input a three-digit number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// secondNumM(number);



// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// void numberThird(int number)
// {
//     if (number / 100 < 1)
//     {
//         Console.WriteLine(number + " -> " + "the third number is missing");
//     }
//     else
//     {
//         if (number > 99 && number < 1000)
//         {
//             int numberThird1 = number % 10;
//             Console.WriteLine(number + " -> " + numberThird1);
//         }
//         else
//         {
//             while (number > 999)
//             {
//                 number = number / 10;
//             }
//             int numberThird2 = number % 10;
//             Console.WriteLine(number + " -> " + numberThird2);
//         }
//     }
// }

// Console.Write("Input number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// numberThird(number);



// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// Variant 1

// void numberDay(int number)
// {
//     if (number == 7 || number == 6)
//     {
//         Console.WriteLine(number + " -> " + "Yes - weekend");
//     }
//     else
//     {
//         if (number == 5 || number == 4 || number == 3 || number == 2 || number == 1)
//         {
//             Console.WriteLine(number + " -> " + "No - working day");
//         }
//     }

// }
// Console.Write("Input number in range 1...7: ");
// int number = Convert.ToInt32(Console.ReadLine());
// numberDay(number);

// Variant 2

void numberDay(int number)
{
    if (number < 6)
    {
        Console.WriteLine(number + " -> " + "No - working day");
    }
    else
    {
        if (number >= 6 && number < 8)
        {
            Console.WriteLine(number + " -> " + "Yes - weekend");
        }
    }

}
Console.Write("Input number in range 1...7: ");
int number = Convert.ToInt32(Console.ReadLine());
numberDay(number);



