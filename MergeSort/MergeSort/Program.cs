using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>() { 2, 8, 5, 3, 9, 4, 1, 7 };

            new Solver().DivideEtImpera(list, 0, list.Count - 1);

            for(int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
