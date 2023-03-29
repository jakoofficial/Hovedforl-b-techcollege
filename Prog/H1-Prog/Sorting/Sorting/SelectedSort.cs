using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class SelectedSort
    {
        

        static void Swap(int[] a, int i, int pos)
        {
            int temp = a[pos];
            a[pos] = a[i];
            a[i] = temp;
        }
    }
}
