using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShaboltsC____
{
    delegate int Operation (int i, int j);
    delegate void GetGreeting();

    class Program
    {
        static void GoodMorning()
        {
            Console.WriteLine("Доброе утро!");
        }
        static void GoodDay()
        {
            Console.WriteLine("Добрый день!");
        }
        static void GoodEvening()
        {
            Console.WriteLine("Добрый вечер!");
        }
        static void GoodNight()
        {
            Console.WriteLine("Доброй ночи!");
        }

        static int Add(int x, int y)
        {
            return x + y;
        }
        static int Subtract(int x, int y)
        {
            return x - y;
        }
        static int Multiply(int x, int y)
        {
            return x * y;
        }
        static int IntegerDevide(int x, int y)
        {
            return x / y;
        }
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            GetGreeting ggDel;
            int timeHour = DateTime.Now.Hour;
            if(timeHour<12)
            {
                ggDel=GoodMorning;
            }
            else if(timeHour>=12 && timeHour <17)
            {
                ggDel=GoodDay;
            }
            else if(timeHour>=17 && timeHour <21)
            {
                ggDel=GoodEvening;
            }
            else
            {
                ggDel=GoodNight;
            }
            ggDel();
            Console.WriteLine("\nТекущее время\n"+DateTime.Now.TimeOfDay);

            Operation opDel;
            Console.WriteLine("\nПриступим к расчетам\n");
            Console.Write("Введите два числа для подсчетов\nx - ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("y - ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Теперь введите операцию(+, -, *, -)\nОперация - ");
            string operation = Convert.ToString(Console.ReadLine());
            switch (operation)
            {
                case "+":
                    opDel=Add;
                break;
                case "-":
                    opDel=Subtract;
                break;
                case "*":
                    opDel=Multiply;
                break;
                case "/":
                    opDel=IntegerDevide;
                break;
                default:
                    opDel=Add;
                break;
            }
            Console.WriteLine("Результат выполненой операции - "+opDel(x,y));
        }
    }
}