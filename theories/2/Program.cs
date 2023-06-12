// // Знакомство с функциями

// Console.Clear ();

// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if (arg2 > result) result = arg2;
//     if (arg3 > result) result = arg3;
//     return result;
// }

// int a1 = 12;
// int b1 = 43;
// int c1 = 15;
// int a2 = 4;
// int b2 = 34;
// int c2 = 50;
// int a3 = 24;
// int b3 = 6;
// int c3 = 17;

// // int max1 = Max(a1, b1, c1);
// // int max2 = Max(a2, b2, c2);
// // int max3 = Max(a3, b3, c3);
// // int max = Max(max1, max2, max3);
// int max = Max(
//     Max(a1, b1, c1), 
//     Max(a2, b2, c2), 
//     Max(a3, b3, c3));
// Console.WriteLine(max);

// Знакомство с массивами

// Console.Clear ();
// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if (arg2 > result) result = arg2;
//     if (arg3 > result) result = arg3;
//     return result;
// }
// // индекс       0   1   2   3   4   5   6   7   8
// int[] array = {11, 21, 31, 14, 15, 61, 17, 18, 19};

// int max = Max(
//     Max(array[0], array[1], array[2]), 
//     Max(array[3], array[4], array[5]), 
//     Max(array[6], array[7], array[8])
//     );
// Console.WriteLine(max);

// Поиск элемента в массивах

// Console.Clear ();

// int[] array = {1, 23, 3, 14, 52, 16, 37, 14};
// int n = array.Length;
// int find = 14;

// int index = 0;

// while (index < n)
// {
//     if (array[index] == find)
//     {
//         Console.WriteLine($"ответ задачи —> {index} ");
//         break; // чтобы программа не проверяла значения дальше
//     }
//     index++;
// }

// Способы записи значений массивов
Console.Clear ();
// создание нового массива из 10 элементов. По умолчанию он заполнится
// нулями, поэтому надо прописать метод/функцию
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{}
int[] array = new int[10]; 
