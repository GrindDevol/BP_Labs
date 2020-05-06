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
            Random rand = new Random();
            List<int> list = new List<int>();
            int N=18, min=400, max=600;
            Console.WriteLine("Количество елементов списка - "+N);
            Console.WriteLine("Диапазон значений "+min+" - "+max+"\n");
            for (int i = 0; i < N; i++)
            {
                list.Add(rand.Next(min,max));
            }
            Console.WriteLine("Сортированый список в порядке увеличения:\n");
            list.Sort();
            foreach(var i in list)
            {
                Console.Write(i+" ");
            }
            int variant = 12;
            Console.Write("\n\nЗначение номера варианта - "+variant);
            list[variant]=variant;//Я не хочу выводить на экран(обьемно выходит)
            Console.WriteLine(", добавлено в список на "+variant+" позицию\n");
            int newNumber = rand.Next(0,1000+N);
            Console.WriteLine("Новое число - "+newNumber+", сгенерированое в диапазоне 0 - "+(variant+1000)+"\n");
            int count=0;
            for (int i = 0; i < N; i++)
            {
                if(list[i]==newNumber)
                {
                    Console.WriteLine("Обнаружено совпадение в списке на позиции - "+i);
                    count++;
                }
            }
            if(count==0)
            {
                    Console.WriteLine("Число в списке не обнаружено");
            }
            int remove = rand.Next(0,N);
            Console.WriteLine("\nНовое число - "+remove+", сгенерированое в диапазоне 0 - "+N);
            list.Remove(remove);
            Console.WriteLine("Число удалено из списка\n");
            foreach(var i in list)
            {
                Console.Write(i+" ");
            }
            list.Clear();
            Console.WriteLine("\n\nСписок очищен");

        }
    }
}