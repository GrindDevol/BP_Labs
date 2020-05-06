using System;
using System.IO;
using System.Collections.Generic;

namespace NewProjectCshyrp
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Считаный из файла порядок чисел:\n");
            StreamReader readFile = new StreamReader("F:\\2 семестр 2 курс\\BP\\Lab_7\\Lab_7.4_readFile.txt");
            Stack<int> stack = new Stack<int>();
            while (!readFile.EndOfStream)
            {
                int number = Convert.ToInt32(readFile.ReadLine());
                Console.WriteLine(number);
                stack.Push(number);
            }
            readFile.Close();
            StreamWriter writeFile = new StreamWriter("F:\\2 семестр 2 курс\\BP\\Lab_7\\Lab_7.4_writeFile.txt", false);
            Console.WriteLine("\nОбратный порядок чисел, записаный в другой файл:\n");
            foreach( int i in stack)
            {
                writeFile.WriteLine(i);
                Console.WriteLine(i);
            }
            writeFile.Close();

        }
    }
}