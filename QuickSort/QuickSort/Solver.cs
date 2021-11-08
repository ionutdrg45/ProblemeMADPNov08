using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Solver
    {
        public void QuickSort(List<int> list, int p, int u)
        {
            int i = p, j = u;
            int m;
            int pivot = list[(p + u) / 2];
            while(i <= j)
            {
                while (list[i] < pivot) i++;
                while (list[j] > pivot) j--;
                if(i <= j)
                {
                    m = list[i];
                    list[i] = list[j];
                    list[j] = m;
                    i++;
                    j--;
                }
            }
            if (p < j) QuickSort(list, p, j);
            if (i < u) QuickSort(list, i, u);
        }
    }
}
