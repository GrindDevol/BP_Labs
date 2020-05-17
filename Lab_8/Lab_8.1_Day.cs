using System;

namespace ShaboltsC____
{
    class Program
    {
        static void MethodAct(int [,] arr, Action<int> act)
        {
            foreach (var i in arr)
            {
                act(i);
            }
        }
        static void MethodFunc(int[,] arr, Func<int, int> func)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i,j] = func(arr[i,j]);
                }
            }
        }
        static void Show(int num)
        {
            Console.Write(num+" ");
        }
        static void ShowPositive(int num)
        {
            if(num>=0)
                Console.Write(num+" ");
        }
        static int Mult3(int num)
        {
            return num*=3;
        }
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Random rand = new Random();
            Console.WriteLine("Введите размерность массива:");
            Console.Write("Строк - ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Столбцов - ");
            int columns = Convert.ToInt32(Console.ReadLine());
            int [,] array = new int[rows,columns];
            for (int i = 0; i < rows; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    array[i,j] = rand.Next(-25,25);
                }
            }
            Console.WriteLine("Сгенерирован матрицы:");
            MethodAct(array, Show);
            Console.WriteLine("\nПоложительные элементы матрицы:");
            MethodAct(array, ShowPositive);
            MethodFunc(array, Mult3);
            Console.WriteLine("\nУмножение матрицы на 3:");
            MethodAct(array, Show);



        }
    }
}