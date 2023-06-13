// // Кратно ли 1е число, 2му
// Console.Clear();
// void CheckEven(int num1, int num2)
// {
//     if (num1 % num2 == 0)
//     {
//         Console.WriteLine($"Число {num1} кратно {num2} ");
//     }
//     else
//     {
//         Console.WriteLine($"Число {num1} не кратно {num2}. Остаток от деления — {num1 % num2} ");
//     }
// }

// Console.Write("Введите первое число -> ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число -> ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// CheckEven(num1, num2);


// // Кратно ли одно число, одновременно 7 и 23
// Console.Clear();

// bool CheckEven(int num)
// {
//     if(num % 7 == 0 && num % 23 == 0) return true;
//     else return false;
// }

// Console.Write ("Введите число -> ");
// int num = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine(CheckEven(num));


// Программа выводит трехзначное число и удаляет вторую цифру
// этого числа
// Console.Clear();

// ﻿int num = new Random().Next(100, 999);

// Console.WriteLine(num);

// System.Console.WriteLine($"{num / 10 - (num / 10) % 10 + num % 10}");


// Программа принимает два числа и проверяет, является ли
// одно число квадратом другого

// Console.Clear();

// void Squared(int num1, int num2)
// {
//     if (num1 == num2*num2) 
//     {
//         Console.WriteLine($"{num2} является квадратом {num1}");
//     }
//     if (num2 == num1*num1)
//     {
//         Console.WriteLine($"{num1} является квадратом {num2}");
//     }
//     else
//     {
//         Console.WriteLine($"{num1} и {num2} не являются квадратом друг друга");
//     }
// }

// Console.Write("Введите первое число -> ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число -> ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// Squared(num1, num2);