/*Переворачиваем одномерный массив: 
1й элемент на последнем месте и наоборот*/
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
// int[] ReverseArray(int[] array)
// {
//     for (int i = 0; i < array.Length/2; i++)
//     {
//         int temp = array[i];
//         array[i] = array[array.Length - i - 1];
//         array[array.Length - i - 1] = temp;
//     }
//     return array;
// }

// System.Console.WriteLine("Введите желаемый размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите минимальное значение диапазона цифр: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите максимальное значение диапазона цифр: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = RandomArray(size, minValue, maxValue);
// Array(myArray);
// myArray = ReverseArray(myArray);
// Array(myArray);


// /*Написать метод, который переводит число в двоичную 
// систему исчисления*/
// string DecimalToBinary(int num)
// {
//     string result = string.Empty;
//     while (num > 0)
//     {
//         result = num % 2 + result ;
//         num /= 2;
//     }
//     return result;
// }
// System.Console.WriteLine("Введите целое число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"Число {num} в двоичной системе исчисления => {DecimalToBinary(num)}");



/* Не используя рекурсию выведите N-е количество
 первых чисел Фиббоначи. Каждый следующий элемент -
 это сумма предыдущих двух: 1,1,2,3,5,8 и тд*/

// int[] Fibonacci (int size, int num1, int num2)
// {
//     int[] array = new int[size];
//     array[0] = num1;
//     array[1] = num2;
    
//     for (int i = 2; i < size; i++)
//     {
//         array[i] = num1 + num2;
//         num1 = num2;
//         num2 = array[i];
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
// System.Console.WriteLine("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"Последовательность Фибоначчи для цифр {num1} и {num2}:");
// Array(Fibonacci(size, num1, num2));

/*Программа принимает на вход три числа и проверяет, 
 может ли существовать треугольник со сторонами такой длины.
 При этом каждая сторона должна быть меньше суммы двух других*/

// bool YesOrNot(int num1, int num2, int num3)
// {
//     if(num1 + num2 > num3 && num1 + num3 > num2 && num3 + num2 > num1) return true;
//     else return false;
// }
// System.Console.WriteLine("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите третье число: ");
// int num3 = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine($"Существует ли треугольник со сторонами {num1}, {num2} и {num3}? {YesOrNot(num1, num2, num3)}");