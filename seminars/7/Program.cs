/*Задача 4. задайте двумерный массив. Найдите сумму элементов,
 находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.*/
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

// int FindSumOfMainDiagonal(int[,] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.GetLength(0); i++)// array.GetLength(0) == количество строк в 2Д массиве
//     {
//         for( int j = 0 ; j < array.GetLength(1); j++)// array.GetLength(0) == количество столбцов в 2Д массиве
//         {
//         if (i == j) sum += array[i, j];
//         }
//     }
// return sum;
// }

// System.Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input minimal value of array element: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input maximal value of array element: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine();

// int [,] myArray = Create2DArray(rows, columns, minValue, maxValue);
// Print2DArray(myArray);
// System.Console.WriteLine(FindSumOfMainDiagonal(myArray));



/*Задача 3.Задайте двумерный массив. Найдите элементы, 
у которых оба индекса чётные, и замените эти элементы на их квадраты.*/
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

// int[,] ReplaceEven(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)// array.GetLength(0) == количество строк в 2Д массиве
//     {
//         for( int j = 0 ; j < array.GetLength(1); j++)// array.GetLength(0) == количество столбцов в 2Д массиве
//         {
//         if (i % 2 == 0 && j % 2 == 0)
//         array[i, j] = Convert.ToInt32(Math.Pow(array[i, j], 2));
//         }
//     }
//     return array;
// }

// System.Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input minimal value of array element: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input maximal value of array element: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine();

// int [,] myArray = Create2DArray(rows, columns, minValue, maxValue);
// Print2DArray(myArray);
// Print2DArray(ReplaceEven(myArray));

/*Задайте двумерный массив размера m на n, каждый элемент в массиве 
находится по формуле: Aₘₙ = m+n.
Выведите полученный массив на экран.*/



// int[,] Create2DArray (int rows, int columns)
// {
// int[,] array = new int[rows,columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//         array[i, j] = i + j;
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

// System.Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input minimal value of array element: ");

// Print2DArray(Create2DArray(rows, columns));