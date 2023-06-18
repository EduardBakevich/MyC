// /* Программа, которая принимает на вход координаты точки (х и y), которые не равны нулю, и
// выдает номер четверти плоскости, в которой находится эта точка*/

// Console.Clear ();

// int Quarte (int x, int y)
// {
//     if (x > 0 && y > 0)
//     {
//         return 1;
//     }

//     if (x < 0 && y > 0)
//     {
//         return 2;
//     }

//     if (x < 0 && y < 0)
//     {
//         return 3;
//     }

//     if (x > 0 && y < 0)
//     {
//         return 4;
//     }
//     return 0;
// }
// Console.WriteLine ("Input x coordinate: ");
// int x = Convert.ToInt32(Console.ReadLine ());
// Console.WriteLine ("Input y coordinate: ");
// int y = Convert.ToInt32(Console.ReadLine ());

// Console.WriteLine($"Введенные вами координаты соответствуют четверти № {Quarte(x, y)}");



/* Праграмма принимает на вход координаты двух точек 
и находит расстояние между ними в 2Д пространстве*/
// using System.Runtime.Intrinsics.X86;

// Console.Clear();

// double Distance (double xa, double ya, double xb, double yb)
// {
// return Math.Round(Math.Sqrt(Math.Pow(xb-xa, 2) + Math.Pow(yb-ya, 2)), 2);
// }
// Console.WriteLine ("Input x coordinate point A: ");
// double xa = Convert.ToDouble(Console.ReadLine ());
// Console.WriteLine ("Input y coordinate point A: ");
// double ya = Convert.ToDouble(Console.ReadLine ());
// Console.WriteLine ("Input x coordinate point B: ");
// double xb = Convert.ToDouble(Console.ReadLine ());
// Console.WriteLine ("Input x coordinate point B: ");
// double yb = Convert.ToDouble(Console.ReadLine ());

// Console.WriteLine ($"расстояние от точки А до точки => {Distance(xa, ya, xb, yb)}");



/* По заданному номеру четверти плоскости показать возможный диапазон 
координат точек в этой четверти*/

// Console.Clear();

// string Min = "от нуля до минус бесконечности";
// string Max = "от нуля до плюс бесконечности";

// Console.WriteLine("Координаты какой четверти вас интересуют? ");
// int num = Convert.ToInt32 (Console.ReadLine ());

// {
//     if (num == 1)
//     {
//         Console.WriteLine($"Координаты х: {Max}, координаты у: {Max}");
//     }
//     if (num == 2)
//     {
//         Console.WriteLine($"Координаты х: {Min}, координаты у: {Max}");
//     }
//     if (num == 3)
//     {
//         Console.WriteLine($"Координаты х: {Min}, координаты у: {Min}");
//     }
//     if (num == 4)
//     {
//         Console.WriteLine($"Координаты х: {Max}, координаты у: {Min}");
//     }
//     Console.WriteLine("Четверти, которую вы ввели не существует");
// }




// /* Программа принимает на вход число N и выдает квадраты чисел от 1 до N */
// Console.Clear();

// Console.WriteLine("Введите любое натуральное число больше единицы => ");
// int num = Convert.ToInt32(Console.ReadLine());
// int count = 1;

// if (num < 1)
// {
//     Console.WriteLine("Мы же просили число побольше(((");
// }
// while (count <= num)
// {
//     Console.WriteLine($"Квадратный корень {count} => {Math.Pow(count, 2)}");
//     count ++;
// }
