using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnurileDinHanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.Write("Numar discuri: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Solutia pentru " + n + " discuri:");
            new Solver().Hanoi(n, 'a', 'b', 'c');

            Console.ReadLine();
        }
    }
}
