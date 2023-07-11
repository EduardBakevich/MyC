/*Написать программу, которая выведет все натуральные числа от 1 до Н*/

// void PrintSum(int n)
// {
//     if (n >= 0)
//     {
//         PrintSum(n - 1);
//         Console.Write(n + " ");
//     }
// }
// PrintSum(6);



/*программа, чтобы найти сумму цифр заданного числа*/

// int FindSum(int num)
// {
//     if (num > 0) return FindSum(num/10) + num%10;
//     else return num;
// }
// Console.WriteLine(FindSum(453));


/*Задайте значения M и N. Напишите программу, 
которая выведет все натуральные числа в промежутке от M до N.*/

// void PrintSum(int n, int m)
// {
//     if (n > m)
//     {
//         int temp = n;
//         n = m;
//         m = temp;
//     }
//     if (n != m)
//     {
//         Console.Write(n + " ");
//         PrintSum(n + 1, m);
//     }
//     else Console.Write(m + " ");
// }
// PrintSum(8, 3);



/*Задача 4.Напишите программу, которая на вход принимает два 
числа A и B, и возводит число А в целую степень B с помощью рекурсии.*/

// int FindPow(int a, int b)
// {
//     if (b > 0) return FindPow(a, b - 1) + a * a;
//     else return a;
// }

// System.Console.WriteLine("Введите число A: ");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите число B: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(FindPow(2, 4));