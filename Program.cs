// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
/*{
            Console.WriteLine("Введите пятизначное число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            bool isPalindrome = CheckPalindrome(number);

            if (isPalindrome)
                Console.WriteLine("Это число является палиндромом.");
            else
                Console.WriteLine("Это число не является палиндромом.");
        }

        static bool CheckPalindrome(int number)
        {
            int originalNumber = number;
            int reversedNumber = 0;

            while (number > 0)
            {
                int remainder = number % 10;
                reversedNumber = reversedNumber * 10 + remainder;
                number /= 10;
            }

            return originalNumber == reversedNumber;
        }
*/

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
/*
Console.WriteLine("Введите координаты точки A (x, y, z): ");
            double ax = Convert.ToInt32(Console.ReadLine());
            double ay = Convert.ToInt32(Console.ReadLine());
            double az = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите координаты точки B (x, y, z): ");
            double bx = Convert.ToInt32(Console.ReadLine());
            double by = Convert.ToInt32(Console.ReadLine());
            double bz = Convert.ToInt32(Console.ReadLine());

            double distance = CalculateDistance(ax, ay, az, bx, by, bz);

            Console.WriteLine("Расстояние между точкой A и точкой B: " + distance.ToString("F2"));

        static double CalculateDistance(double ax, double ay, double az, double bx, double by, double bz)
        {
            double dx = ax - bx;
            double dy = ay - by;
            double dz = az - bz;

            double distance = Math.Sqrt(dx * dx + dy * dy + dz * dz);

            return distance;
        }
        */

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

/*Console.WriteLine("Введите число N: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Таблица кубов чисел от 1 до " + n + ":");
            PrintCubeTable(n);
    
            static void PrintCubeTable(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                int cube = i * i * i;
                Console.WriteLine(cube);
            }
        } */