using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOП6._3
{
    class Triangle
    {
        double x1, y1;
        double x2, y2;
        double x3, y3;
        double a, b, c;

        public void EnterCoordinate()
        {
            Console.WriteLine("Введите координаты сторон треугольника");

            Console.WriteLine("Введите координату x1");
            double x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату y1");
            double y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату x2");
            double x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату y2");
            double y2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату x3");
            double x3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату y3");
            double y3 = double.Parse(Console.ReadLine());

            a = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            b = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
            c = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));
        }
        public bool ProverkaTriangle()
        {
            if (((a + b > c) && (b + c > a) && (c + a > b)) == false)
                return false;
            else
                return true;
        }
        public void AnglesTriangle()
        {
            double Alf;
            double Bet;
            double Gam;

            Alf = Math.Cos((b * b + c * c - a * a) / (2 * b * c));
            Console.WriteLine("Угол альфа " + Alf);
            Bet = Math.Cos((a * a + c * c - b * b) / (2 * a * c));
            Console.WriteLine("Угол бетта " + Bet);
            Gam = Math.Cos((a * a + b * b - c * c) / (2 * a * b));
            Console.WriteLine("Угол гамма " + Gam);
        }
        class Program
        {
            static void Main(string[] args)
            {
                Triangle trig = new Triangle();
                trig.EnterCoordinate();
                trig.AnglesTriangle();
                Console.ReadLine();
            }
        }
    }
}

