/* Первый вид методов (функций): ничего не принимают (нет аргументов)
и не возвращают (не преобразуют). 
Например, просто указывают авторство в конце кода.*/

// void Mehod1()
// {
//     System.Console.WriteLine("By Eduard Bakevich");
// }
// Mehod1();


/* Второй вид методов: ничего не возвращают (не преобразуют),
но могут принимать некие аргументы*/

// void Method2(string msg)
// {
//     System.Console.WriteLine(msg);
// }
// Method2("Текст сообщения");

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         System.Console.WriteLine(msg);
//         i++; /*увеличение счетчика increment,
//         уменьшение - decrement*/
//     }
// }
// Method21("Текст", 4); // сколько раз хотим увидеть "Текст"
// Также можно записать аргументы по-другому, именуя их
// Method21(msg: "Текст", count: 4);

// Кстати, если программу зацикливает, остановить ее можно CTRL+C


/* Третья группа методов: что-то возвращают (преобразуют),
но ничего не принимают (нет аргументов)*/
/* Если методы что-то возвращают (преобразуют), 
значит нужно указывать, какой это будет тип данных.
А также что возвращает — return*/
// int Method3()
// {
//     return DateTime.Now.Year; // указываем методу, что хотим
// }
// int year = Method3(); // обрабатываем результат
// System.Console.WriteLine(year);

/* Четвертый тип методов: что-то принимают (некие аргументы)
и возвращают (преобразуют) их*/

// string Method4(int count, string text)
// {
//     string result = string.Empty; /* string.Empty (можно и так "")
//      — означает пустую строку*/
     
//     //  while (i < count)
//     //  {
//     //     result = result + text;
//     //     i++;
//     //  }
//     //  return result;
//      /* Есть более подходящий для таких ситуаций цикл  — 
// for (цикл со счетчиком)*/
//     for (int i = 0; i < count; i++)
//         {
//             result = result + text;
//         }
//         return result;
// }
// string res =Method4(10, "asdf");
// System.Console.WriteLine(res);

/* Цикл можно использовать в другом цикле. Например,
вывод таблицы умножения на экран */

// for (int i = 1; i < 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
        // System.Console.WriteLine($"{i} * {j} = {i*j}"); 
        // /* $ — символ интерполяции строки, т.е. объединение 
        // в одной строке разных типов данных*/
//     }
//     System.Console.WriteLine();
// }

/* Практика. Дан кусок текст. Нужно все пробелы заменить черточками, 
к на К, а С — на с.*/

// string text =  "— Я думаю, — сказал князь, улыбаясь, — что,"
//             + "ежели бы вас послали вместо нашего милого Винценгроде,"
//             + "вы бы взяли приступом согласие прусского короля."
//             + "Вы так красноречивы. Вы дадите мне чаю?";

// string ReplaceText (string text, char oldValue, char newValue)
// // char — условный тип данных
// {
//     string result = String.Empty;

//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if (text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }
//     return result;
// }
// string newText = ReplaceText(text, ' ', '|');
// System.Console.WriteLine(newText);
// System.Console.WriteLine();
// newText = ReplaceText(newText, 'к', 'К');
// System.Console.WriteLine(newText);
// System.Console.WriteLine();
// newText = ReplaceText(newText, 'Я', 'я');
// System.Console.WriteLine(newText);



/* Упорядочить данные в массиве. Алгоритм сортировки 
методом выбора (мини-макс, выбор максимального).
Его суть в том, что у нас есть некий набор чисел. 
Мы выбираем в нем первый элемент. Находим среди оставшихся
элементов минимальный и перемещаем его на место первого.
Далее берем второй элемент, находим минимальный среди
оставшихся элементов и т. д.*/

// int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

// void PrintArray (int[] array)
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         System.Console.Write ( $"{array[i]} " ) ;
//     }
//     System.Console.WriteLine();
// }
// void SelectionSort (int[] array)
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         int minPosition = i;
//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if (array[j] < array[minPosition]) minPosition = j;
//         }

//         int teporary = array[i];
//         array[i] = array[minPosition];
//         array[minPosition] = teporary;
//     }
// }
// PrintArray (arr);
// SelectionSort (arr);
// PrintArray (arr);

// Сортировка в обратном порядке

// int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

// void PrintArray (int[] array)
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         System.Console.Write ( $"{array[i]} " ) ;
//     }
//     System.Console.WriteLine();
// }
// void SelectionSort (int[] array)
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         int maxPosition = i;
//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if (array[j] > array[maxPosition]) maxPosition = j;
//         }

//         int teporary = array[i];
//         array[i] = array[maxPosition];
//         array[maxPosition] = teporary;
//     }
// }
// PrintArray (arr);
// SelectionSort (arr);
// PrintArray (arr);