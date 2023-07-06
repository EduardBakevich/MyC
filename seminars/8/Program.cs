/*Задание 1. Задайте двумерный массив. Напишите программу, 
которая поменяет местами указанные строки массива.*/
// int[,] Create2DArray (int rows, int columns,int minValue,int maxValue)
// {
//     int[,] array = new int[rows,columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = new Random().Next(minValue, maxValue+1);
//         }
//     }
//     return array;
// }

// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for( int j = 0 ; j < array.GetLength(1); j++)
//         {
//             System.Console.Write(array[i,j] + " ");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// int[,] ChangeRows(int[,] array, int row1, int row2)
// {
//     if ( row1 >= array.GetLength (0) || row2 >= array.GetLength(0))
//     {
//         System.Console.WriteLine("Указанные строки выходят за пределы массива!");
//         return array;
//     }
//     else
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//         int temp = array[row1, j];
//         array[row1, j] = array[row2, j];
//         array[row2, j] = temp;
//         }
//         return array;
// }

// System.Console.WriteLine("Введите число строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите число столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите минимальное значение для элементов: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите максимальное значение для элементов: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите строку массива, которую хотите поменять местами с другой: ");
// int row1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите другую строку элемента, которую хотите поменять местами с первой: ");
// int row2 = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = (Create2DArray(rows, columns, minValue, maxValue));
// Print2DArray(myArray);
// Print2DArray(ChangeRows(myArray, row1, row2));


/*Задание 2. Задайте двумерный массив. Напишите программу, 
которая заменяет строки на столбцы. В случае, если это невозможно, 
программа должна вывести сообщение для пользователя.*/
// int[,] Create2DArray (int rows, int columns,int minValue,int maxValue)
// {
//     int[,] array = new int[rows,columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = new Random().Next(minValue, maxValue+1);
//         }
//     }
//     return array;
// }

// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for( int j = 0 ; j < array.GetLength(1); j++)
//         {
//             System.Console.Write(array[i,j] + " ");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// int[,] RowsToColumns(int[,] array)
// {
//     if (array.GetLength(0) != array.GetLength(1))
//     {
//         System.Console.WriteLine("Массив не квадратный!");
//         return array;
//     }
//     else
//     {
//         for (int i = 0; i < array.GetLength(0) - 1; i++)
//         {
//             for (int j = i + 1; j < array.GetLength(1); j++)
//             {
//                 int temp = array[i, j];
//                 array[i, j] = array[j, i];
//                 array[j, i] = temp;
//             }
//         }
//         return array;
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

// int[,] myArray = (Create2DArray(rows, columns, minValue, maxValue));
// Print2DArray(myArray);
// Print2DArray(RowsToColumns(myArray));

/*Найти в двумерном массиве элемент с наименьшим значением.
Обнулиnь значения других элементов, находящихся
с ним на одной строке и столбце*/

// int[,] Create2DArray (int rows, int columns,int minValue,int maxValue)
// {
//     int[,] array = new int[rows,columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = new Random().Next(minValue, maxValue+1);
//         }
//     }
//     return array;
// }

// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for( int j = 0 ; j < array.GetLength(1); j++)
//         {
//             System.Console.Write(array[i,j] + " ");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// int[,] FindMin (int[,] array)
// {
//     int minI  = 0;
//     int minJ = 0;
//     int min = array[0, 0];
        
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] <= min) 
//             {
//             min = array[i, j];
//             minI = i;
//             minJ = j;
//             }
//         }
//     }
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         array[i, minJ] = 0;
//     }
//     for (int j = 0; j < array.GetLength(0); j++)
//     {
//         array[minI, j] = 0;
//     }
//     return array;
// }

// System.Console.WriteLine("Введите число строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите число столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите минимальное значение для элементов: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите максимальное значение для элементов: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = (Create2DArray(rows, columns, minValue, maxValue));
// Print2DArray(myArray);
// Print2DArray(FindMin (myArray));