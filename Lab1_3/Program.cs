using System;
using System.Collections.Generic;
using System.Linq;


namespace ConsoleApp25
{ 
    class Program3
    {
        static void Main(string[] args)
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
    }
}
