using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>(){2, 5, 6, 22, 13};
            System.Console.WriteLine("Before sorting");
            PrintList(list);
            ListSort(list);
            System.Console.WriteLine("After sorting");
            PrintList(list);
            System.Console.Read();
        }

        public static void PrintList(List<int> list)
        {
            foreach (var el in list)
            {
                System.Console.WriteLine(el);
            }
        }

        public static long GetFibonacciNumber(int a)
        {
            return 1;
        }

        public static void ListSort(List<int> list)
        {

        }
    }
}
