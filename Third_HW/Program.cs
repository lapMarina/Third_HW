using System;

namespace Third_HW
{
    class Program
    {
        static void FirstTask() 
        {
            Console.WriteLine("Введите пятизначное число");
            int m = Convert.ToInt32(Console.ReadLine());
            if (m >= 10000 && m <= 99999)
            {
                int a = m / 10000;
                int b = m / 1000 % 10;
                int c = m / 10 % 10;
                int d = m % 10;
                if (a == d && b == c)
                    Console.WriteLine("да");
                else
                    Console.WriteLine("нет");
            }
            else
                Console.WriteLine("Введеное число не пятизначное");
        }

        static void SecondTask() 
        {
            Console.WriteLine("Введите координаты первой точки");
            Console.WriteLine("Введите х1");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите y1");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите z1");
            int z1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координаты второй точки");
            Console.WriteLine("Введите х2");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите y2");
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите z2");
            int z2 = Convert.ToInt32(Console.ReadLine());
            double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
            Console.WriteLine($"Расстояние между точкой А({x1}, {y1}, {z1}) и B({x2}, {y2}, {z2}) состовляет {result}");
        }

        static void ThirdTask() 
        {
            Console.WriteLine("Введите число");
            int m = Convert.ToInt32(Console.ReadLine());
            string result = "";
            for (int i = 1; i <= m; i++)
                result += $"{Math.Pow(i, 3)} ";
            Console.WriteLine(result);
        }

        static void Main(string[] args)
        {
            FirstTask();
            SecondTask();
            ThirdTask();
        }
    }
}

