using System;
using System.IO;

namespace NewProjectCshyrp
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.ForegroundColor = ConsoleColor.Cyan;

            string str;
            int open = 0, close = 0;
            StreamReader readFile = new StreamReader("F:\\2 семестр 2 курс\\BP\\Lab_7\\Lab_7.1_readFile.txt");
            str = Convert.ToString(readFile.ReadToEnd());
            for (int i = 0; i < str.Length; i++)
            {
               if (str[i] == '(')
                {
                    open++;
                }
                else if (str[i] == ')')
                {
                    close++;
                } 
            }
            if (close == open)
            {
                Console.WriteLine("Балланс скобок соблюден");
            }

            else
            {
                Console.WriteLine("Балланс скобок не соблюден");
            }
                Console.WriteLine($"Количество открытых скобок - {open}");
                Console.WriteLine($"Количество закрытых скобок - {close}");

            
        }
    }
}


    
