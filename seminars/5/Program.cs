// /* Задайте массив из 12 элементов, заполненный случайными числами из промежутка
// (-9, 9). Найдите сумму отрицательных и положительных элементов массива*/

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

// void PosNegSum(int[] array)
// {
//     int sumPos = 0;
//     int sumNeg = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0) sumPos +=array[i];
//         else sumNeg +=array[i];
//     }
//     System.Console.WriteLine($"суммa положительных элементов массива => {sumPos}, сумму отрицательныx элементов массива => {sumNeg}");
// }
// System.Console.WriteLine("Введите желаемый размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите минимальное значение диапазона цифр: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите максимальное значение диапазона цифр: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = RandomArray(size, minValue, maxValue);
// Array(myArray);
// PosNegSum(myArray);

/*Замена элементов массива: положительные значения на отрицательные и наоборот*/

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
// int[] InvertArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] *= -1;
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
// myArray = InvertArray(myArray);
// Array(myArray);

/*Задайте массив, размер которого и элементы может выбрать пользователь. 
Проверить по запросу пользователя, есть ли в массиве определенный элемент*/

int[] YourArray (int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write("Введите элемент массива (целое число): ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}
bool Number(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (num == array[i]) return true;
    }
    return false;
}

System.Console.WriteLine("Введите желаемый размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число, чтобы проверить, есть ли оно в массиве: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = YourArray(size);
if (Number(array, num) == true) Console.WriteLine($"{num} есть в массиве");
else Console.WriteLine($"{num} нет в массиве");
/*Массив из трех случайных чисел. Найдите чило элементов, лежащих в диапазоне,
указанном пользователем*/

