using System;
using System.Linq;
using System.IO;
using System.Collections.Generic; 
namespace pr16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ");
            StreamReader file = new StreamReader("1.txt");
            string a = file.ReadToEnd().ToLower();
            file.Close();
            string line = Console.ReadLine().ToLower();
            string[] b = a.Split();
            int kol = 0;
            List<int> list = new List<int>();
            if (b.Contains<string>(line))
                for (int i = 0; i < a.Length; i++)
                    list.Add(1);
            Console.WriteLine($"Найдено {list.Sum()} вхождениий из поискового запроса {line}");



        }
    }
}
