using System;
using System.Collections.Generic;
using System.Text;

namespace Sortowanie_Zadanie_19._03._2020
{
    class QuickSort
    {
        public static int[] Sortowanie(int[] tablica)
        {
            void Quick_Sort(int[] arr, int left, int right)
            {
                if (left < right)
                {
                    int pivot = Partition(arr, left, right);

                    if (pivot > 1)
                    {
                        Quick_Sort(arr, left, pivot - 1);
                    }
                    if (pivot + 1 < right)
                    {
                        Quick_Sort(arr, pivot + 1, right);
                    }
                }
            }

            static int Partition(int[] tab, int left, int right)
            {
                int temp;
                int pivot = tab[right];
                int i = left - 1;
                for (int j = left; j <= right - 1; j++)
                {
                    if (tab[j] <= pivot)
                    {
                        i++;
                        temp = tab[i];
                        tab[i] = tab[j];
                        tab[j] = temp;
                    }
                }

                temp = tab[i + 1];
                tab[i + 1] = tab[right];
                tab[right] = temp;
                return i + 1;
            }
            Quick_Sort(tablica, 0, tablica.Length - 1);
            return tablica;
        }
        public static int[] SortowanieZKomentarzem(int[] tablica)
        {
            Console.WriteLine("LEGENDA:");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("To jest kolor pivota.");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("To jest kolor elementu zamienianego z pivotem.");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("To jest kolor w momencie kiedy pivot nie jest zamieniany z żadnym elementem.");
            Console.ResetColor();
            void Quick_Sort1(int[] arr, int left, int right)
            {
                if (left < right)
                {
                    int pivot = Partition1(arr, left, right);

                    if (pivot > 1)
                    {
                        Quick_Sort1(arr, left, pivot - 1);
                    }
                    if (pivot + 1 < right)
                    {
                        Quick_Sort1(arr, pivot + 1, right);
                    }
                }
            }

            static int Partition1(int[] tab, int left, int right)
            {
                int temp;
                int pivot = tab[right];
                int i = left - 1;
                Console.WriteLine("\n");
                Console.WriteLine("Pivot jest równy {0}", pivot);
                Console.WriteLine("\n");
                for (int j = left; j <= right - 1; j++)
                {
                    if (tab[j] <= pivot)
                    {
                        i++;
                        temp = tab[i];
                        tab[i] = tab[j];
                        tab[j] = temp;
                    }
                }

                temp = tab[i + 1];
                tab[i + 1] = tab[right];
                tab[right] = temp;
                for (int a = 0; a < tab.Length; a++)
                {
                    if (tab[a] == tab[i + 1] && tab[a] != tab[right])
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(" " + tab[a]);
                        Console.ResetColor();
                    }
                    if (tab[a] == tab[right] && tab[a] != tab[i + 1])
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(" " + tab[a]);
                        Console.ResetColor();
                    }
                    if (tab[a] == tab[right] && tab[a] == tab[i + 1])
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write(" " + tab[a]);
                        Console.ResetColor();
                    }
                    if (tab[a] != tab[i + 1] && tab[a] != tab[right])
                    {
                        Console.Write(" " + tab[a]);
                    }
                }
                return i + 1;
            }
            Quick_Sort1(tablica, 0, tablica.Length - 1);
            return tablica;
        }
    }
}
