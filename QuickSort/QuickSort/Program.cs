using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>() { 2, 4, 3, 5, 9, 11, 1, 20, 7, 6 };

            new Solver().QuickSort(list, 0, list.Count - 1);

            for(int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }

            Console.ReadLine();
        }
    }
}
