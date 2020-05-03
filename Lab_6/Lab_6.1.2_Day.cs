using System;
namespace NewProjectCshyrp
{
    // визначення інтерфейсу
    interface IDemo
    {
        void Show(); //оголошення методу
        double Dlina(); //оголошення методу
        int X { get; } //оголошення властивості, доступного тільки для читання
        int this[int i] { get; set; } //оголошення індексатора, доступного для
        //читання-запису
    }
     public interface IMeasurable
    {
    double Perimeter();
    double Area();
    }
    public interface ICircumcircleIncircle
    {
        double R { get; } // радіус описаного кола
        double r { get; } // радіус вписаного кола
    }
    // клас DemoPoint успадковує інтерфейс IDemo

    class   Square : IDemo, IMeasurable, ICircumcircleIncircle
    {
        protected int x;
        public int X //реалізація властивості, оголошеної в інтерфейсі
        {
            get
            {
                return x;
            }
        }
        public  Square(int x)
        {
            this.x = x;
        }
        // реалізація методу, оголошеного в інтерфейсі, з приховуванням
       // однойменного методу з базового класу
        public void Show()
            {
                Console.WriteLine($" квадрат: (сторона - { x})");
            }
            // реалізація методу, оголошеного в інтерфейсі, з приховуванням
            //однойменного методу з базового класу
        public double Dlina()
            {
                return Perimeter();
            }
        public double Perimeter()
            {
                return 4*x;
            }
        public double Area()
            {
                return Math.Pow(x,2);
            }
        public double r
        {
            get
            {
                return Convert.ToDouble(x)/2;
            }
        }
        public double R
        {
            get
            {
                return Convert.ToDouble(x)*Math.Sqrt(2)/2;
            }
        }     
         public int this[int i]
        {
            get
            {
                if (i == 0) return x;
                else throw new Exception(" неприпустиме значення індексу");
            }
            set
            {
                if (i == 0) x = value;
                else throw new Exception(" неприпустиме значення індексу ");
            }
        }        
    }
 
    
    class Program
    {
        static void Main()
        {
            // створення масиву інтерфейсних посилань
            Square[] a = new Square[4];
            // заповнення масиву
            for (int i = 0; i < 4; i++)
                a[i] = new Square(i+1); 
            // перегляд масиву
            foreach (Square x in a)
            {
                x.Show();
                Console.WriteLine(" Perimetr = "+x.Dlina());
                Console.WriteLine(" x = " +x.X);
                Console.WriteLine(" Area = "+x.Area());
                Console.WriteLine(" Defined circle radius = "+x.R);
                Console.WriteLine(" Inscribed circle radius = "+x.r);
                Console.WriteLine();
            }
        }
    }
}
