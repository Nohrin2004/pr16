using System;
using System.Collections.Generic;
using System.Linq;
namespace pr16_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            double[] a = new double [10] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i] + " ");
            }
            List<double> b = new List<double>();
            List<int> c = new List<int>();
            for (int i = 0; i < a.Length; i++)
            {
                int c1 = 1;
                c.Clear();
                c.Add(1);
                for (int j = 0; j < a.Length; j++)
                {


                    if (i != j)
                    {
                        if (a[i] == a[j])
                        {
                            c1++;
                            c.Add(1);
                        }
                    }

                }
                b.Add(c.Sum());

            }
            Console.WriteLine("!");

            Console.WriteLine(b[7]);

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"{i + 1}) {a[i]} == {a[i]}");
                Console.WriteLine();
            }
            double[] fin = new double[a.Length];
            Console.WriteLine("Финальный массив");
            Console.WriteLine();
            for (int i = 0; i < fin.Length; i++)
            {
                fin[i] = a[i] * b[i];
                Console.Write(fin[i] + " ");

            }
        }
    }
}
