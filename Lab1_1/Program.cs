
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
namespace L1
{
    class Program1
    {
        static void Task1()
        {
            int T = int.Parse(Console.ReadLine());
            LinkedList<int> list = new LinkedList<int>();

            for (int i = 0; i < T; i++)
            {
                int r = int.Parse(Console.ReadLine());
                if (r % 2 == 0)
                {
                    list.AddFirst(r);
                }
                else
                {
                    list.AddLast(r);
                }
            }
            foreach (int item in list)
            {
                Console.Write($"{item} ");
            }

        }
        static void Task2()
        {
            Dictionary<string, double> d = new Dictionary<string, double>();

            d.Add("item1", 45.50);
            d.Add("item2", 35);
            d.Add("item3", 41.30);
            d.Add("item4", 55);
            d.Add("item5", 24);

            Dictionary<string, double> newD = d.OrderByDescending(x => x.Value).Take(3).ToDictionary(a => a.Key, b => b.Value);
            foreach (var item in newD)
            {
                Console.WriteLine($"{item.Key} {item.Value}");
            }
            string JSON = JsonConvert.SerializeObject(newD, Formatting.Indented);

            string fileName = @"file[2].json";

            File.Create(fileName).Close();
            File.WriteAllText(fileName, JSON);
        }
        static void Task3()
        {
            int t = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            for (int i = 0; i < t; i++)
            {
                int x = int.Parse(Console.ReadLine());
                list.Add(x);

            }
            var nList = list.Where(x => x % 2 == 0 && x < 0)
                    .Reverse();
            foreach (int item in nList)
            {
                Console.Write($"{item} ");
            }

        }
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();

        }
    }
}
