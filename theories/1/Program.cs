// Задача1

// Console.Clear(); // Очистка консоли после выполнения программы
// Console.WriteLine("Введите ваше имя ");
// string username = Console.ReadLine();
// Console.WriteLine("Привет, ");
// Console.WriteLine(username);

// Задача2

// Console.Clear();
// ﻿int numberA = new Random().Next(1,10); // случайное число от 1 до 9
// Console.WriteLine(numberA);
// int numberB = new Random().Next(1,10);
// Console.WriteLine(numberB);
// int result = numberA + numberB;
// Console.WriteLine(result);

// Задача3

// Console.Clear();
// ﻿double numberA = 102;
// double numberB = 5;
// double result = numberA / numberB;
// Console.WriteLine(result);

// Задача3

// Console.Clear();
// ﻿Console.Write("Введите имя пользователя");
// string username = Console.ReadLine();

// if(username.ToLower() == "маша") // Команда ТоЛовер, чтобы объединять ввод Маша маша мАшА и тд.
// {
//     Console.WriteLine("Ура, это же МАША!");
// }
// else
// {
//     Console.Write("Привет, ");
//     Console.WriteLine(username);
// }

// Задача4

// Console.Clear();
// ﻿int a = 1;
// int b =  2;
// int c = 6;
// int d = 8;
// int e = 4;

// int max = a;

// if (a > max) max = a;
// if (b > max) max = b;
// if (c > max) max = c;
// if (d > max) max = d;
// if (e > max) max = e;

// Console.Write("max = ");
// Console.WriteLine(max);

// Задача5

// Console.Clear();
// int xa = 1, ya = 1,
//     xb = 14, yb = 1,
//     xc = 14, yc = 14;

// Console.SetCursorPosition(xa, ya);
// Console.WriteLine("+");

// Console.SetCursorPosition(xb, yb);
// Console.WriteLine("+");

// Console.SetCursorPosition(xc, yc);
// Console.WriteLine("+");

// int x = xa, y = xb;

// int count = 0;

// while(count < 100)
// {
//     int what = new Random().Next(0, 3);

//     if(what == 0)
//     {
//         x = (x + xa)/2; // на одной вершине
//         y = (y + ya)/2;
//     }

//     if(what == 1)
//     {
//         x = (x + xb)/2; // на другой вершине
//         y = (y + yb)/2;
//     }

//     if(what == 2)
//     {
//         x = (x + xc)/2; // на третьей вершине
//         y = (y + yc)/2;
//     }

//     Console.SetCursorPosition(x, y);
//     Console.WriteLine("+");
//     count = count + 1; // можно count++
// }