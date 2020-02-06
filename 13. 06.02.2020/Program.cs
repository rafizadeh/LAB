using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._06._02._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. first or last
            //int num = Convert.ToInt32(Console.ReadLine());
            //int first = num / 100;
            //int last = num % 10;

            //if(num < 0)
            //{
            //    num = -num;
            //}

            //if(first > last)
            //{
            //    Console.WriteLine("{0} > {1}", first, last);
            //}
            //else if(last > first)
            //{
            //    Console.WriteLine("{0} > {1}", last, first);
            //}
            //else
            //{
            //    Console.WriteLine("Her ikisi beraberdirler!");
            //}

            // 2. chevrilmelerin sayinin tapilmasi
            //int n = int.Parse(Console.ReadLine());

            //if (n < 0)
            //{
            //    n = -n;
            //}

            //int counter = 0;

            //while(n > 1)
            //{
            //    n = Func(n);
            //    counter++;
            //}
            //Console.WriteLine(counter);


            // 3 . Fibonacci sequence
            //int index = int.Parse(Console.ReadLine());

            //int[] fib = new int[index + 1];
            //fib[0] = 0;
            //fib[1] = 1;
            //for (int i = 2; i <= index; i++)
            //{
            //    fib[i] = fib[i - 1] + fib[i - 2]; 
            //}
            //Console.WriteLine(fib[index]);

            // 4. massivde 2.5den boyuk olmayan ilk deyer

            int n = int.Parse(Console.ReadLine());
            string line = Console.ReadLine();

            var arr = line.Split(' ');

            for (int i = 0; i < n; i++)
            {
                double variable = double.Parse(arr[i]);
                if (variable <= 2.5)
                {
                    Console.WriteLine("{0} {1:N1}", i + 1, variable);
                    return;
                }
            }
            Console.WriteLine("Not Found");

        }
        /// <summary>
        /// Funksiya eded cutdurse 2ye bolur tekdirse 1 vahid artirir
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        //private static int Func(int x)
        //{
        //    if (x % 2 == 0)
        //    {
        //        return x /= 2;

        //    }
        //    else
        //    {
        //        return x + 1;
        //    }
        //}
    }
}
