using System;
using System.Collections.Generic;
using System.Linq;

namespace C_Sharp_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {

            //Program1();
            //Program2();
            Program4();
            Console.ReadKey(true);
        }

        public static void Program1()
        {
            int[] arr1 = { 4, 5, -12, 5, -3, -5, 1, 34 };


            var qwery = from i in arr1 group i by i < 0 into res select res;
            var pos = qwery.AsEnumerable().Where(i => i.Key == false).First().First();
            var pos2 = qwery.AsEnumerable().Where(i => i.Key == true).Last().Last();

            Console.WriteLine("The array change: ");
            foreach (var item in qwery)
            {
                foreach (var elem in item)
                {
                    Console.Write($"{elem}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine(pos);
            Console.WriteLine(pos2);
        }


        public static void Program2()
        {
            int D = 3;
            List<int> list1 = new List<int> { -10, 21, 46, 9, 10, -33, 77, 965, -80 };

            var result1 = list1.FirstOrDefault(x => (x > 0) && (x % 10 == D));

            Console.WriteLine(result1);
            Console.ReadKey();

        }


        public static void Program4()
        {
            int[] a1 = { 2, 54, 3, 5, 2, 8, 6, 2, 8, 5, 3, 6, 8, 76, 45, 6, 34, 10 };

            var lastDigit = from i in a1
                            where i > 0
                            select i % 10;
            foreach (var item in lastDigit)
            {

                Console.Write($"{item}\t");
            }
            Console.WriteLine();
        }


    }
  }


