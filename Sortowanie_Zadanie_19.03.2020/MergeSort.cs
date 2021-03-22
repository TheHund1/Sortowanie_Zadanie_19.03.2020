using System;
using System.Collections.Generic;
using System.Text;

namespace Sortowanie_Zadanie_19._03._2020
{
    class MergeSorting
    {
      public static void MergeSort(int[] tab, int p, int q, int r)
        {
            int[] L = new int[q - p + 1];
            int[] R = new int[r - q];

            Array.Copy(tab, p, L, 0, q - p + 1);
            Array.Copy(tab, q + 1, R, 0, r - q);

            int ii = 0;
            int jj = 0;
            for (int k = p; k < r + 1; k++)
            {
                if (ii == L.Length)
                {
                    tab[k] = R[jj];
                    jj++;


                }

                else if (jj == R.Length)
                {
                    tab[k] = L[ii];
                    ii++;

                }
                else if (L[ii] <= R[jj])
                {
                    tab[k] = L[ii];
                    ii++;

                }
                else
                {
                    tab[k] = R[jj];
                    jj = jj + 1;

                }
            }
        }
        public static void Merge(int[] tab, int p, int r)
        {
            if (p < r)
            {
                int q = (p + r) / 2;

                Merge(tab, p, q);
                Merge(tab, q + 1, r);

                MergeSort(tab, p, q, r);
                foreach (var num in tab)
                {
                    Console.Write(num + " ");
                }
                Console.Write("\n");
            }

        }
    }
}

