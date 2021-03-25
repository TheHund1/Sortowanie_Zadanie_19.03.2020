using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Sortowanie_Zadanie_19._03._2020
{
    class HeapSort
    {
        public static int Left(int i)
        {
            return 2 * i;
        }
        public static int Right(int i)
        {
            return 2 * i + 1;
        }
        public static int[] Heapify(int[] arr, int i)
        {
            int max;
            int l = Left(i);
            int r = Right(i);
            if ((l <= arr.Length - 1) && arr[l] > arr[i])
            {
                max = l;
            }
            else max = i;
            if ((r <= arr.Length - 1) && arr[r] > arr[max])
            {
                max = r;
            }
            if (max != i)
            {
                int temp = arr[i];
                arr[i] = arr[max];
                arr[max] = temp;
                Heapify(arr, max);
            }
            return arr;
        }
        public static int[] BuildMaxHeap(int[] arr)
        {
            for (int i = (int)Math.Floor((decimal)(arr.Length - 1) / 2); i >= 0; i--)
            {
                Heapify(arr, i);
            }
            return arr;
        }
        public static int[] DoHeapSort(int[] arr)
        {
            int[] sortedArr = new int[arr.Length];
            arr = BuildMaxHeap(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                sortedArr[i] = arr[0];
                arr[0] = 0;
                arr = Heapify(arr, 0);
                Comment(arr, sortedArr, i+1);
            }
            return sortedArr;
            
        }
        public static void Comment(int[] startArray, int[] sortArray, int i)
        {
            Console.WriteLine("\nIteracja numer {0}:", i);
            Console.Write("\n(A):[ ");
            foreach (int x in startArray)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine("]");
            Console.Write("\n(H):[ ");
            foreach (int x in sortArray)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine("]");
            Console.WriteLine("Na koniec tablica (H) zostaje w całości przekopiowana do tablicy (A)");
        }
        public static void ExplainHeapSort(int[] arr)
        {
            if (arr.Min() >= 0)
            {
                Console.WriteLine("Wytłumaczymy, w jaki sposób przebiega sortowanie przez kopcowanie dla podanej tablicy. \nAlgorytm sortuje wartości klucza większe od zera.");
                Console.WriteLine("Jako pierwszy zostanie utworzony kopiec typu Max, czyli taki, \ndla którego wartość klucza ojca jest zawsze większa niż lewego jak i prawego syna");
                Console.WriteLine("Tablica przed utworzeniem kopca:");
                foreach (int x in arr)
                {
                    Console.Write(x + " ");
                }
                Console.WriteLine("\nTablica po utworzeniu kopca:");
                arr = BuildMaxHeap(arr);
                foreach (int x in arr)
                {
                    Console.Write(x + " ");
                }
                Console.WriteLine("\nW korzeniu (pierwszy element) kopca znajduje się największa wartość klucza. Będziemy ją kopiować do tablicy pomocniczej, następnie zamieniać na wartość 0 i przywracać wartość kopca.");
                arr = DoHeapSort(arr);
                Console.WriteLine("\nTablica A po posortowaniu:");
                Console.Write("\n[ ");
                foreach (int x in arr)
                {
                    Console.Write(x + " ");
                }
                Console.Write("]");
            }
            else
            {
                Console.WriteLine("Algorytm nie sortuje tablicy z elementami mniejszymi od zera");
            }
        }
    }
}
