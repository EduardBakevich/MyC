/*Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки 
двумерного массива.*/
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

// void RowMaxMin(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       for (int k = 0; k < array.GetLength(1) - 1; k++)
//       {
//         if (array[i, k] < array[i, k + 1])
//         {
//           int temp = array[i, k + 1];
//           array[i, k + 1] = array[i, k];
//           array[i, k] = temp;
//         }
//       }
//     }
//   }
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
// RowMaxMin(myArray);
// Print2DArray(myArray);


/*Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей 
суммой элементов.*/

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

// int SumLineElements(int[,] array, int i)
// {
//   int sumLine = array[i,0];
//   for (int j = 1; j < array.GetLength(1); j++)
//   {
//     sumLine += array[i,j];
//   }
//   return sumLine;
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

// // Не получилось из этого сделать метод((()))
// int minSumLine = 0;
//   int sumLine = SumLineElements(myArray, 0);
//   for (int i = 1; i < myArray.GetLength(0); i++)
//   {
//     int tempSumLine = SumLineElements(myArray, i);
//     if (sumLine > tempSumLine)
//     {
//       sumLine = tempSumLine;
//       minSumLine = i;
//     }
//   }
// Console.WriteLine($"{minSumLine+1} — строкa с наименьшей суммой ({sumLine}) элементов ");

/*Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.*/


// System.Console.WriteLine("Введите число строк для матрицы А: ");
// int rowsA = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите число столбцов для матрицы А: ");
// int columnsA = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите число строк для матрицы В: ");
// int rowsB = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите число столбцов для матрицы В: ");
// int columnsB = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите минимальное значение для элементов: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите максимальное значение для элементов: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine();

// int[,] Create2DArray (int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       array[i, j] = new Random().Next(minValue, maxValue + 1);
//     }
//   }
//   return array;
// }

// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for( int j = 0 ; j < array.GetLength(1); j++)
//         {
//         System.Console.Write(array[i,j] + " ");
//         }
//     System.Console.WriteLine();
//     }
// System.Console.WriteLine();
// }

// void MultiplyMatrix(int[,] firstMartrix, int[,] secondMartrix, int[,] resultMatrix)
// {
//   if (firstMartrix.GetLength(1) != secondMartrix.GetLength(0))
//   {
//     System.Console.WriteLine("Умножение не возможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы.");
//   }
//   for (int i = 0; i < resultMatrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < resultMatrix.GetLength(1); j++)
//     {
//       int sum = 0;
//       for (int k = 0; k < firstMartrix.GetLength(1); k++)
//       {
//         sum += firstMartrix[i,k] * secondMartrix[k,j];
//       }
//       resultMatrix[i,j] = sum;
//     }
//   }
// }

// int[,] firstMartrix = new int[rowsA, columnsA];
// Create2DArray(firstMartrix);
// Print2DArray(firstMartrix);
// int[,] secondMartrix = new int[rowsB, columnsB];
// Create2DArray(secondMartrix);
// Print2DArray(secondMartrix);
// int[,] resultMatrix = new int[rowsA, columnsB];

// MultiplyMatrix(firstMartrix, secondMartrix, resultMatrix);
// Console.WriteLine($"\nПроизведение первой и второй матриц:");
// Print2DArray(resultMatrix);

/*Сформируйте трёхмерный массив из неповторяющихся 
двузначных чисел. Напишите программу, которая будет
построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2*/


// Не получилось
// int[,,] Create3DArray (int[,,] array)
// {
//   array[0, 0, 0] = 10;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//           for (int k = 0; k < array.GetLength(2); k++)
//           {
//             array[i, j, k] = array[0, 0, 0]++;
//           }
//         }
//     }
// return array;
// }

// void Print3DArray(int[,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for( int j = 0 ; j < array.GetLength(1); j++)
//         {
//           for(int k = 0 ; k < array.GetLength(2); k++);
//           {
//             System.Console.Write(array[i,j,k] + $"({i}; {j}; {k})");
//           }
//           System.Console.WriteLine();
//         }
//     System.Console.WriteLine();
//     }
// System.Console.WriteLine();
// }
// Print3DArray(Create3DArray(new int[2, 2, 2]));