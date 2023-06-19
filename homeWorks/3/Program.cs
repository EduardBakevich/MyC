// /* Проверка: является ли пятизначное число палиндромом?*/

// Console.Clear();

// bool result (int num)
// {
//     if (num / 10000 == num % 10 && num % 10000 / 1000 == num % 100 / 10)
//     {
//     return true;
//     }
// return false;
// }
// Console.Write ( " Введите пятизначное число => " );
// int num = Convert.ToInt32(Console.ReadLine());

// if (num < 10000 && num > 99999)
// {
//     Console.WriteLine("Ошибка ввода: условия не соблюдены");
// }
// Console.WriteLine($"Число {num} — палиндром? => {result(num)}");




/* Расстояние между точками в 3Д-пространстве*/

// Console.Clear();
// double Distance (double xa, double ya, double za, double xb, double yb, double zb)
// {
// return Math.Round(Math.Sqrt(Math.Pow(xb-xa, 2) + Math.Pow(yb-ya, 2) + Math.Pow(zb-za, 2)), 2);
// }

// Console.WriteLine ("Input x coordinate point A: ");
// double xa = Convert.ToDouble(Console.ReadLine ());
// Console.WriteLine ("Input y coordinate point A: ");
// double ya = Convert.ToDouble(Console.ReadLine ());
// Console.WriteLine ("Input z coordinate point A: ");
// double za = Convert.ToDouble(Console.ReadLine ());
// Console.WriteLine ("Input x coordinate point B: ");
// double xb = Convert.ToDouble(Console.ReadLine ());
// Console.WriteLine ("Input x coordinate point B: ");
// double yb = Convert.ToDouble(Console.ReadLine ());
// Console.WriteLine ("Input z coordinate point B: ");
// double zb = Convert.ToDouble(Console.ReadLine ());

// Console.WriteLine ($"расстояние от точки А до точки B в 3D-пространстве => {Distance(xa, ya, za, xb, yb, zb)}");



/* Программа принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.*/

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
//     Console.WriteLine($" {count} в кубе => {Math.Pow(count, 3)}");
//     count ++;
// }