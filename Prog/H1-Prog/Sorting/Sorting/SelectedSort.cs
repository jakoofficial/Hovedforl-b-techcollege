using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class SelectedSort
    {
        public static void Run(int[] a)
        {
            int sPos = 0;
            int[] arr = {10, 7, 8, 1, 5}; //Original Array for sorting
            int[] tempArr = new int[arr.Length];
            arr.CopyTo(tempArr, 0);

            foreach (var item in a)
            {
                SelectedSorting(arr, sPos);
                sPos++;
            }

            PrintArr(a.Length, tempArr, a);
        }

        public static void PrintArr(int n, int[] oriArr, int[] a)
        {
            for (int i = 0; i < n; i++)
                Console.WriteLine("Arr space: {0} | Ori: {1} | New: {2} ", i, oriArr[i], a[i]);
        }

        public static void SelectedSorting(int[] a, int sPos)
        {
            int pos = -1;
            int low = a[sPos-1];

            for (int i = 0; i < a.Length; i++)
            {
                if (low >= a[i])
                {
                    pos++;
                    low = a[i];
                    Swap(a, i, pos);
                }
            }
        }

        static void Swap(int[] a, int i, int pos)
        {
            int temp = a[pos];
            a[pos] = a[i];
            a[i] = temp;
        }
    }
}
