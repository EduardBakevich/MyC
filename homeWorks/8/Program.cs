/*Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки 
двумерного массива.*/
int[,] Create2DArray (int rows, int columns,int minValue,int maxValue)
{
int[,] array = new int[rows,columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
        array[i, j] = new Random().Next(minValue, maxValue+1);
        }
    }
return array;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)// array.GetLength(0) == количество строк в 2Д массиве
    {
        for( int j = 0 ; j < array.GetLength(1); j++)// array.GetLength(0) == количество столбцов в 2Д массиве
        {
        System.Console.Write(array[i,j] + " ");
        }
    System.Console.WriteLine();
    }
System.Console.WriteLine();
}

void RowMaxMin(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
}
System.Console.WriteLine("Введите число строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите минимальное значение для элементов: ");
int minValue = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите максимальное значение для элементов: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();

int [,] myArray = Create2DArray(rows, columns, minValue, maxValue);
Print2DArray(myArray);
RowMaxMin(myArray);
Print2DArray(myArray);
