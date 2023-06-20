/* Программа принимает на вход число и выдат сумму числ от 1 от А*/

// int FindSum (int a)
// {
//     int sum = 0;
//     for (int i = 1; i < a; i++)
//     {
//       sum += i; // sum = sum + i;  
//     }
//     return sum;
// }
// System.Console.WriteLine("Введите любое положительное число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine ($"Сумма чисел от 1 до {a} => {FindSum(a)}");



/* Программа выводит массив из n элементов, заполненный 
случайными цифрами. Помните, если работаете с массивом, то
практически всегда будете использовать циклы*/

// int[] RandomArray (int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
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
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите максимальное значение диапазона цифр: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// Array(RandomArray(size, minValue, maxValue));

/* Программа принимает на вход число и выдает количество цифр в числе*/


/* Программа принимает на вход число Н и 
выдает произведение чисел от 1 до Н (факториал числа Н)*/