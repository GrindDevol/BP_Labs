using System;
namespace NewProjectCshyrp
{
    // визначення інтерфейсу
    interface IDemo
    {
        void Show(); //оголошення методу
        double Dlina(); //оголошення методу
        int X { get; } //оголошення властивості, доступного тільки для читання
        int Y { get; } //оголошення властивості, доступного тільки для читання
        int this[int i] { get; set; } //оголошення індексатора, доступного для
        //читання-запису
    }
    // клас DemoPoint успадковує інтерфейс IDemo
    class DemoPoint : IDemo
    {
        protected int x;
        protected int y;
        public DemoPoint(int x, int y)
        {
            this.x = x; this.y = y;
        }
        public void Show() //реалізація методу, оголошеного в інтерфейсі
        {
            Console.WriteLine($" точка на площині: ({ x}, { y})");
        }
        public double Dlina() //реалізація методу, оголошеного в інтерфейсі
        {
            return Math.Sqrt(x * x + y * y);
        }
        public int X //реалізація властивості, оголошеної в інтерфейсі
        {
            get
            {
                return x;
            }
        }
         public int Y //реалізація властивості, оголошеної в інтерфейсі
        {
            get
            {
                return y;
            }
        }
        public int this[int i] //реалізація індексатора, оголошеного в інтерфейсі
        {
            get
            {
                if (i == 0) return x;
                else if (i == 1) return y;
                else throw new Exception(" неприпустиме значення індексу ");
            }
            set
            {
                if (i == 0) x = value;
                else if (i == 1) y = value;
                else throw new Exception(" неприпустиме значення індексу ");
            }
        }
    }
    // клас DemoShape успадковує клас DemoPoint і інтерфейс IDemo
    class DemoShape : DemoPoint, IDemo
    {
        protected int z;
        public DemoShape(int x, int y, int z) : base(x, y)
        {
            this.z = z;
        }
        // реалізація методу, оголошеного в інтерфейсі, з приховуванням
       // однойменного методу з базового класу
    public new void Show()
        {
            Console.WriteLine($" точка в пространстве: ({ x}, { y}, { z})");
        }
        // реалізація методу, оголошеного в інтерфейсі, з приховуванням
        //однойменного методу з базового класу
    public new double Dlina()
        {
            return Math.Sqrt(x * x + y * y + z * z);
        }
        // реалізація індексатора, оголошеного в інтерфейсі, з приховуванням
        // однойменного індексатора з базового класу
        public new int this[int i]
        {
            get
            {
                if (i == 0) return x;
                else if (i == 1) return y;
                else if (i == 2) return z;
                else throw new Exception(" неприпустиме значення індексу");
            }
            set
            {
                if (i == 0) x = value;
                else if (i == 1) y = value;
                else if (i == 2) z = value;
                else throw new Exception(" неприпустиме значення індексу ");
            }
        }
    }
 
    
    class Program
    {
        static void Main()
        {
            // створення масиву інтерфейсних посилань
            IDemo[] a = new IDemo[4];
            // заповнення масиву
            a[0] = new DemoPoint(0, 1);
            a[1] = new DemoPoint(-3, 0);
            a[2] = new DemoShape(3, 4, 0);
            a[3] = new DemoShape(0, 5, 6);
            // перегляд масиву
            foreach (IDemo x in a)
            {
                x.Show();
                Console.WriteLine(" Dlina = "+ x.Dlina());
                Console.WriteLine(" x = " +x.X);
                Console.WriteLine(" y = " +x.Y);
                x[1] += x[0];
                Console.Write(" нові координати -");
                x.Show();
                Console.WriteLine();
            }
        }
    }
}
