// /*Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.*/
// int[] InputArray (int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         System.Console.WriteLine("Введите число: ");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }

// void Array(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
//     System.Console.WriteLine();
// }

// void Positives(int[] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0) sum ++;
//     }
//     System.Console.WriteLine($"Среди массива цифр {sum} — положительные");
// }
// System.Console.WriteLine("Введите желаемый размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] myArray = InputArray(size);
// Array(myArray);
// Positives(myArray);

/*Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.*/

// Console.WriteLine("Введите переменную b1: ");
// double b1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите переменную k1: ");
// double k1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите переменную b2: ");
// double b2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите переменную k2: ");
// double k2 = Convert.ToDouble(Console.ReadLine());

// double x = -(b1 - b2) / (k1 - k2);
// double y = k1 * x + b1;

// Console.Write($" Точка пересечения двух прямых: [{x},{y}]");