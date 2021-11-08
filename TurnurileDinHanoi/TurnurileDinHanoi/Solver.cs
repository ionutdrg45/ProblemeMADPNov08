using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnurileDinHanoi
{
    class Solver
    {
        public void Hanoi(int n, char a, char b, char c)
        {
            if (n == 1) Console.WriteLine(a + " -> " + b);
            else
            {
                Hanoi(n - 1, a, c, b);
                Console.WriteLine(a + " -> " + b);
                Hanoi(n - 1, c, b, a);
            }
        }
    }
}
