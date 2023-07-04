/* Задайте двумерный массив размером m×n, заполненный 
случайными вещественными числами*/

// double[,] RandomArray ( int rows, int columns, int start, int end)
// {
//     double[,] array = new double[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = new Random().NextDouble() * (end - start) + start;
//         }
//     }
//     return array;
// }
// void PrintArray ( double[,] array )
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write($"{array[i, j]:F2} ");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// System.Console.WriteLine("Введите желаемое число строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите желаемое число столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите минимальное целое значение диапазона: ");
// int start = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите максимальное целое значение диапазона: ");
// int end = Convert.ToInt32(Console.ReadLine());

// PrintArray(RandomArray(rows, columns, start, end));



/*Напишите программу, которая на вход принимает позиции 
элемента в двумерном массиве, и возвращает значение этого элемента
 или же указание, что такого элемента нет.*/
// int[,] Create2DArray (int rows, int columns,int minValue,int maxValue)
// {
// int[,] array = new int[rows,columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//         array[i, j] = new Random().Next(minValue, maxValue+1);
//         }
//     }
// return array;
// }

// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)// array.GetLength(0) == количество строк в 2Д массиве
//     {
//         for( int j = 0 ; j < array.GetLength(1); j++)// array.GetLength(0) == количество столбцов в 2Д массиве
//         {
//         System.Console.Write(array[i,j] + " ");
//         }
//     System.Console.WriteLine();
//     }
// System.Console.WriteLine();
// }

// void WhatElementYouNeed(int[,] array, int row, int column)
// {
//     if (row < array.GetLength(0) && column < array.GetLength(1))
//         System.Console.WriteLine($"элемент с индексом [{row}, {column}] — это {array[row, column]}");
//     else
//         System.Console.WriteLine($"элемента с указанным индексом [{row}, {column}] не существует"); 
// }

// System.Console.WriteLine("Введите число строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите число столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите минимальное значение для элементов: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите максимальное значение для элементов: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine();

// int [,] myArray = Create2DArray(rows, columns, minValue, maxValue);
// Print2DArray(myArray);

// System.Console.WriteLine("Введите индекс строки элемента, значение которого хотите узнать: ");
// int row = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите индекс столбца элемента, значение которого хотите узнать: ");
// int column = Convert.ToInt32(Console.ReadLine());
// WhatElementYouNeed(myArray, row, column);





 /*Задайте двумерный массив из целых чисел. 
 Найдите среднее арифметическое элементов в каждом столбце.*/

//  int[,] Create2DArray (int rows, int columns,int minValue,int maxValue)
// {
// int[,] array = new int[rows,columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//         array[i, j] = new Random().Next(minValue, maxValue+1);
//         }
//     }
// return array;
// }

// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)// array.GetLength(0) == количество строк в 2Д массиве
//     {
//         for( int j = 0 ; j < array.GetLength(1); j++)// array.GetLength(0) == количество столбцов в 2Д массиве
//         {
//         System.Console.Write(array[i,j] + " ");
//         }
//     System.Console.WriteLine();
//     }
// System.Console.WriteLine();
// }

// void Avg(int[,] array)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         double sum = 0;
//         for( int i = 0 ; i < array.GetLength(0); i++)
//         {   
//             sum += array[i, j];
//         }
//         System.Console.Write($"{sum/array.GetLength(0):F1} ");
//     }
// }
// System.Console.WriteLine("Введите число строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите число столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите минимальное значение для элементов: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите максимальное значение для элементов: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine();

// int [,] myArray = Create2DArray(rows, columns, minValue, maxValue);
// Print2DArray(myArray);
// Avg(myArray);