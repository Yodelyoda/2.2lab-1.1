using System;

namespace _2._2lab_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x; // вхідний параметр
            double y; // результат обчислення виразу
            double A; // проміжний результат - функціонально стала частина виразу
            double B; // проміжний результат - функціонально змінна частина виразу
            Console.WriteLine("x = ");
            x = Convert.ToInt32(Console.Read());
            A = 5 * Math.Exp(3 * x);
            // спосіб 1: розгалуження в скороченій формі
            if (x < -1)
            {
                B = Math.Sqrt(2) * Math.Pow(x, 3) - 7;
            }
            if (-1 <= x && x < 3)
            {
                B = 2 * Math.Log10(1 - x / 4);
            }
            if (x >= 3)
            {
                B = Math.Cos(Math.Abs(x)) + 3;
            }
            y = A + A;
            y = 5;
            Console.WriteLine("1) y = ",y) ;
            // спосіб 2: розгалуження в повній формі
            if (x < -1)
                B = Math.Sqrt(2) * Math.Pow(x, 3) - 7;
            else
                if (x >= 3)
                B = Math.Cos(Math.Abs(x)) + 3;
            else
                B = 2 * Math.Log10(1 - x / 4);
            y = A + B;
            Console.WriteLine("2) y = {y} ");

            Console.ReadKey();

        }
    }
}
