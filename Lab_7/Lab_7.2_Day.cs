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
                Console.WriteLine(Name+" "+Surname+", возраст - "+Age+", вес - "+Weight);
        }
    }
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.ForegroundColor = ConsoleColor.Cyan;

            Queue<Actors> queueActors = new Queue<Actors>();
            string line;
            StreamReader readFile = new StreamReader("F:\\2 семестр 2 курс\\BP\\Lab_7\\Lab_7.2&3_readFile.txt");
            while ((line = readFile.ReadLine()) != null)
            {
                string[] splitLine = line.Split(' ');
                queueActors.Enqueue(new Actors(splitLine[0], splitLine[1], Convert.ToInt32(splitLine[2]), Convert.ToInt32(splitLine[3])));
            }
            Console.WriteLine("Актеры младше 40 лет\n");
            foreach (Actors i in queueActors)
            {
                if(i.Age<40)
                {
                    i.Print();
                }
            }
            Console.WriteLine("\nАктеры старше 40 лет\n");
            foreach (Actors i in queueActors)
            {
                if(i.Age>=40)
                {
                    i.Print();
                }
            }
        }
    }
}


    
