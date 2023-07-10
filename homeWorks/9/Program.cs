/*Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.*/

// void PrintNum(int n)
// {
//     if (n > 0)
//     {
//         System.Console.Write(n + " ");
//         PrintNum(n - 1);
//     }
// }
// PrintNum(10);



/*Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.*/


// int FindSum(int m, int n)
// {
//     if (m > n)
//     {
//         int temp = m;
//         m = n;
//         n = temp;
//     }
//     if (m == n) return m;
//     return n + FindSum(m, n - 1);
// }
// System.Console.WriteLine(FindSum(5, 2));


/*Напишите программу вычисления функции Аккермана 
с помощью рекурсии. Даны два неотрицательных числа m и n.*/

// int Akkerman (int n, int m)
// {
//   if (n == 0)
//     return m + 1;
//   else
//     if ((n != 0) && (m == 0))
//       return Akkerman(n - 1, 1);
//     else
//       return Akkerman(n - 1, Akkerman(n, m - 1));
// }
// System.Console.WriteLine(Akkerman(2,3));