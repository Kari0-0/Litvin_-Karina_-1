using System;
using System.Linq;
using Newtonsoft.Json;
using System.IO;

namespace ConsoleApp1
{
    class Program2
    {
        static void Main(string[] args)
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
    }
}
