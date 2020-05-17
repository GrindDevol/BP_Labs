using System;
using System.IO;
using System.Linq;

namespace ShaboltsC____
{
    class Program
    {
        static void Show(string str)
        {
            Console.Write(str);
        }
        static void ShowNumbers(String str)
        {
            int value;
            int.TryParse(string.Join("", str.Where(c => char.IsDigit(c))), out value);
            Console.WriteLine(value);
        }
        static string Replacement(string str)
        {
            str = str.Replace(',',' ');
            str = str.Replace('.',' ');
            str = str.Replace('*',' ');
            str = str.Replace('(',' ');
            str = str.Replace(')',' ');         
            return str;
        }
        static void ReadFile(string str, Action<string> act)
        {
            act(str);
        }
        static string ReadFile(string str, Func<string,string> func)
        {
            return func(str);
        }
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            StreamReader readFile = new StreamReader("F:\\2 семестр 2 курс\\BP\\Lab_8\\Lab_8.2_readFile.txt");
            string text = Convert.ToString(readFile.ReadToEnd());
            Console.WriteLine("Содержимое файла:");
            ReadFile(text,Show);
            Console.WriteLine("\n\nЧисла, находящиеся в файле:");
            ReadFile(text,ShowNumbers);
            Console.WriteLine("\nСодержимое файла после замены символов на пробел:");
            ReadFile(ReadFile(text, Replacement),Show);
        }
    }
}