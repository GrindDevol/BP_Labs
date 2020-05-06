using System;
using System.IO;
using System.Collections.Generic;

namespace NewProjectCshyrp
{
    class Actors
    {
        public string Name{set;get;}
        public string Surname{set;get;}
        public int Age{set;get;}
        public int Weight{set;get;}
        public Actors(string name, string surname, int age, int weight)
        {
            Name=name;
            Surname=surname;
            Age=age;
            Weight=weight;
        }
        public void Print()
        {
                Console.WriteLine(Name+" "+Surname+", "+Age+" лет, вес - "+Weight);
        }
    }
    class ActorsComparer : IComparer<Actors>
        {
            public int Compare(Actors p1, Actors p2)
            {
                if (p1.Age > p2.Age)
                {
                    return 1;
                }
                else if (p1.Age < p2.Age)           
                {
                    return -1;
                }
                else
                 {
                    return 0;
                 }   
            }
        }

    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.ForegroundColor = ConsoleColor.Cyan;

            List<Actors> listActors = new List<Actors>();
            string line;
            StreamReader readFile = new StreamReader("F:\\2 семестр 2 курс\\BP\\Lab_7\\Lab_7.2&3_readFile.txt");
            while ((line = readFile.ReadLine()) != null)
            {
                string[] splitLine = line.Split(' ');
                listActors.Add(new Actors(splitLine[0], splitLine[1], Convert.ToInt32(splitLine[2]), Convert.ToInt32(splitLine[3])));
            }
            Console.WriteLine("Список до сортировки:\n");
            foreach (Actors i in listActors)
            {
                i.Print();
            }
            listActors.Sort(new ActorsComparer());
            Console.WriteLine("\nСписок после сортировки:\n");
            foreach (Actors i in listActors)
            {
                i.Print();
            }
        }
    }
}