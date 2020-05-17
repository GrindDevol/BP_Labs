using System;
using System.IO;
using System.Linq;

namespace ShaboltsC____
{
    class Program
    {
        static double Сalculation(double r, Func<double,double> func)
        {
            return func(r);
        }
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Введите радиус окружности - ");
            double R = Convert.ToDouble(Console.ReadLine());
            Circle circle = new Circle();
            circle.R=R;
            Console.WriteLine("Длинна окружности - "+Math.Round(Сalculation(R,circle.Length),3));
            Console.WriteLine("Площадь окружности - "+Math.Round(Сalculation(R,circle.Square),3));
            Console.WriteLine("Обьем сферы - "+Math.Round(Сalculation(R,circle.Volumetric),3));
        }
    }
    class Circle
    {
        public double R{ get; set; }
        public double Length(double R)
        {
            return 2*Math.PI*R;
        }
        public double Square(double R)
        {
            return Math.PI*Math.Pow(R,2);
        }
        public double Volumetric(double R)
        {
            return (4*Math.PI*Math.Pow(R,3))/3;
        }
    }
}