/* Цикл принимает на вход два числа (А и В) и возводит А в степень В*/

// Console.Clear();

// double AtoDegreeB(int a, int b)
// {
//     return Math.Pow (a, b);
// }

// System.Console.WriteLine ("Введите число A: " );
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine ("Введите число B: " );
// int b = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine($" А в степени В => {AtoDegreeB(a, b)}");

// /* Цикл принимает на вход число и выдает сумму цифр в числе*/
// Console.Clear();

// int HowMany (int n)
// {
//         int sum = 0;
//     for (int i = 0; n >= 1; i++)
//     {
//         sum = sum + n%10;
//         n = n / 10;
//     }
//     return sum;
// }
// Console.WriteLine("Введите число: " );
// int n = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"Сумма цифр в числе: {HowMany (n)} ");



/* Программа задает массив из Н элементов и выводит его на экран*/
// Console.Clear();
// int[] RandomArray (int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
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

// System.Console.WriteLine("Введите желаемый размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите минимальное значение диапазона цифр: ");
// int min = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите максимальное значение диапазона цифр: ");
// int max = Convert.ToInt32(Console.ReadLine());

// Array(RandomArray(size, min, max));

// int Prompt(string message)
// {
//     System.Console.WriteLine(message);
//     string ReadInput = Console.ReadLine();
//     int result = int.Parse(ReadInput);
//     return result;
// }
// int[] GenerateArray(int Length, int minValue, int maxValue)
// {
//     int[] array = new int[Length];
//     Random random = new Random();
//     for (int i = 0; i < Length; i++)
//     {
//         array[i] = random.Next (minValue, maxValue + 1);
//     }
//     return array;
// }
// void PrintArray(int[] array)
// {
//     Console.Write(" [");
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         Console.Write($"{array[i]}, ");
//     }
//     Console.WriteLine($"{array[array.Length - 1]}");
//     Console.Write("]");
// }

// int length = Prompt ("Длина массива: ");
// int min = Prompt ("Начальное значение, для диапазона случайного числа: ");
// int max = Prompt ("Конечное значение, для диапазона случайного числа: ");
// int[] array = GenerateArray(length, min, max);
// PrintArray(array);