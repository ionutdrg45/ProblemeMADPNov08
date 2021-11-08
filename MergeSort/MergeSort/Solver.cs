using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    class Solver
    {
        public void Sort(List<int> list, int p, int q)
        {
            if(list[p] > list[q])
            {
                int aux = list[p];
                list[p] = list[q];
                list[q] = aux;
            }
        }

        public void Merge(List<int> list, int p, int q, int m)
        {
            int i = p, j = m + 1, k = 0;
            var list2 = new List<int>(list.Count);
            for (int index = 0; index < list.Count; index++)
                list2.Add(0);

            while(i <= m && j <= q)
            {
                if(list[i] <= list[j])
                {
                    list2[k] = list[i];
                    i++;
                }
                else
                {
                    list2[k] = list[j];
                    j++;
                }
                k++;
            }

            if(i <= m)
            {
                for(j = i; j <= m; j++)
                {
                    list2[k] = list[j];
                    k++;
                }
            }
            else
            {
                for(i = j; i <= q; i++)
                {
                    list2[k] = list[i];
                    k++;
                }
            }
            k = 0;
            for(i = p; i <= q; i++)
            {
                list[i] = list2[k];
                k++;
            }
        }

        public void DivideEtImpera(List<int> list, int p, int q)
        {
            if (q - p <= 1) Sort(list, p, q);
            else
            {
                int m = (p + q) / 2;
                DivideEtImpera(list, p, m);
                DivideEtImpera(list, m + 1, q);
                Merge(list, p, q, m);
            }
        }
    }
}
