// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");



// Console.WriteLine("Введите целое число");
// int num = Convert.ToInt32( Console.ReadLine() );
// int square = num * num;
// Console.WriteLine(square);
// Console.WriteLine($"Квадрат введенного числа равен {square}");
// if (num > 0)
// {
//     System.Console.WriteLine("Это положительное число");
// }
// else if (num == 0)
//     System.Console.WriteLine("Это ноль");
// else
//     System.Console.WriteLine("Это отрицательное число");



// int i = 1;
// while (i <= 10)
// {
//     Console.Write($"{i} ");
//     i = i + 1;
//     //i++;
// }
// System.Console.WriteLine();



// System.Console.WriteLine("Введите 1 число");
// int num1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите 2 число");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num1 == num2 * num2)
//     System.Console.WriteLine("да");
// else
//     System.Console.WriteLine("нет");



// Console.Write("введите первое трехзначное целое число : ");
// int num = Convert.ToInt32(Console.ReadLine());
// int i = num % 10 ;
// System.Console.WriteLine(i);



// Console.Write("введите целое число : ");
// int num = Convert.ToInt32(Console.ReadLine());
// int i = -num ;
// while (i <= num)
// {
//     Console.Write($"{i} ");
//     i++ ; 
// }
// System.Console.WriteLine();



// Напишите программу, которая выводит случайное число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

// int num = new Random().Next(10,100);
// System.Console.WriteLine($"Было сгенерировано число {num}");
// int digit1 = num / 10;
// int digit2 = num % 10;
// if (digit1 > digit2)
//     System.Console.WriteLine($"Наибольшая цифра этого числа это {digit1}");
// else if (digit1 == digit2)
//     System.Console.WriteLine("Обе цифры этого числа равны");
// else
//     System.Console.WriteLine($"Наибольшая цифра этого числа это {digit2}");



// for (int i = 0; i < 11; i++)
//     Console.Write($"{i} ");



// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

// int num = new Random().Next(100, 1000);
// System.Console.WriteLine($"Было сгенерировано число {num}");
// int num1 = num / 100;
// int num3 = num % 10;
// System.Console.WriteLine(num1 + "" + num3);



// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

// Console.WriteLine("Write integer number 1");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Write integer number 2");
// int num2 = Convert.ToInt32(Console.ReadLine());
// int result = num1 % num2;
// if (result == 0)
//     Console.WriteLine("кратно");
// else
//     Console.WriteLine($"не кратно, остаток {result}");



// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

// Console.WriteLine("Введите число num1");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число num2");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if(num1 == num2*num2 || num2 == num1 * num1)
//     Console.WriteLine($"{num1} , {num2}-> да");
// else
//     Console.WriteLine($"{num1} , {num2}-> нет");



// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
// 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да

// Console.Write("Введите число : ");
// int number = Convert.ToInt32(Console.ReadLine());
// int result1 = number % 7;
// int result2 = number % 23;
// if (result1 == 0 && result2 == 0)
//     Console.WriteLine($"{number} -> да");
// else
//     Console.WriteLine($"{number} -> нет");

// Второе решение (кратно только одному числу)

// Console.Write("Введите число : ");
// int number = Convert.ToInt32(Console.ReadLine());
// int result1 = number % 7;
// int result2 = number % 23;
// if (result1 == 0 && result2 == 0)
//     Console.WriteLine($"{number} -> да");
// else if (result1 == 0 || result2 == 0)
// {
//     if(result1==0)
//         Console.WriteLine($"{number} -> кратно только 7");
//     else
//         Console.WriteLine($"{number} -> кратно только 23");
// }
// else
//     Console.WriteLine($"{number} -> нет");







