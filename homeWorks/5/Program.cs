/*Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая покажет 
количество чётных чисел в массиве.*/

// int[] RandomArray ( int size )
// {
//     int minValue = 100;
//     int maxValue = 999;

//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }
// void Array ( int[] array )
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
//     System.Console.WriteLine();
// }

// void AmountEven (int[] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i]%2 == 0) sum++;
//     }
//     System.Console.WriteLine($"Число четных элементов в массиве => {sum}");
// }
// System.Console.WriteLine("Введите желаемый размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] myArray = (RandomArray(size));
// Array(myArray);
// AmountEven(myArray);


/*одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.*/
// int[] RandomArray ( int size, int minValue, int maxValue )
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }
// void Array ( int[] array )
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
//     System.Console.WriteLine();
// }

// void SumOdd (int[] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i%2 != 0) sum += array[i];
//     }
//     System.Console.WriteLine($"Сумма цифр, стоящих на нечетных позициях массива, => {sum}");
// }
// System.Console.WriteLine("Введите желаемый размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите минимальное значение диапазона цифр: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите максимальное значение диапазона цифр: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = (RandomArray(size, minValue, maxValue));
// Array(myArray);
// SumOdd(myArray);


/*массив вещественных чисел. Найдите разницу между 
максимальным и минимальным элементов массива.*/

// double[] RandomArray ( int size, int start, int end)
// {
//     double[] array = new double[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().NextDouble()* (end - start) + start;
//     }
//     return array;
// }
// void Array ( double[] array )
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write($"{array[i]:F2} ");
//     }
//     System.Console.WriteLine();
// }
// void DifferMaxMin (double[] array)
// {
//     double max = array[0];
//     double min = array[0];
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] < min) min = array[i];
//         if (array[i] > max) max = array[i];
//     }
//     System.Console.WriteLine($"Максимум = {max:F}, минимум = {min:F}. Разница между максимумом и минумом массива составляет {max-min:F}");
// }
// System.Console.WriteLine("Введите желаемый размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите минимальное целое значение диапазона: ");
// int start = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите максимальное целое значение диапазона цифр: ");
// int end = Convert.ToInt32(Console.ReadLine());

// double[] myArray = (RandomArray(size, start, end));
// Array(myArray);
// DifferMaxMin(myArray);