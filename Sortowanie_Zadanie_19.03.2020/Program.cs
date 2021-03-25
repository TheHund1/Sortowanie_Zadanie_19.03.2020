/*Twórcy: Jakub Kęstowicz 
Rafał Kwiatek
Michał Matuszak
Piotr Matuszak*/
using System;

namespace Sortowanie_Zadanie_19._03._2020
{
    class Program
    {
        static void WeryfikacjaInputu(ref int x)
        {
            bool czyPrawidłowo = true;
            while (czyPrawidłowo)
            {
                try
                {
                    x = Convert.ToInt32(Console.ReadLine());
                    czyPrawidłowo = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Wartość nie może być pusta.");
                    Console.WriteLine("Wprowadź wartość ponownie.");
                }
            }
        }
        static void WyświetlTabele(int []arr)
        {
            foreach (var a in arr)
            {
                Console.Write(" " + a);
            }
        }
        static void Main(string[] args)
        {
            int rozmiar = 8;
            int[] tab = new int[rozmiar];
            bool czyWybórTabeli = true;
            while (czyWybórTabeli)
            {
                Console.WriteLine("Wybierz opcje: \nWprowadzenie tabeli samemu[1] \nUżycie predefiniowanej tabeli[2]");
                int wybórTabeli=1;
                WeryfikacjaInputu(ref wybórTabeli);
                switch (wybórTabeli)
                {
                    case 1:
                        Console.WriteLine("Wybrałeś opcję wprowadzenie tabeli samemu.");
                        Console.Write("Wprowadź rozmiar tabeli: ");
                        WeryfikacjaInputu(ref rozmiar);
                        tab = new int[rozmiar];
                        for (int i = 0; i < tab.Length; i++)
                        {
                            WeryfikacjaInputu(ref tab[i]);
                        }
                        WyświetlTabele(tab);
                        Console.WriteLine();
                        czyWybórTabeli = false;
                        break;
                    case 2:
                        Console.WriteLine("Wybrałeś opcję użycie predefiniowanej tabeli.");
                        Console.WriteLine("Oto Twoja tabela:");
                        tab = new int[] { 93, 19, 2, 4, 51, 7, 81, 6, 3 };
                        WyświetlTabele(tab);
                        Console.WriteLine();
                        czyWybórTabeli = false;
                        break;
                    default:
                        Console.WriteLine("Błędna wartość. Wybierz ponownie.");
                        break;
                }
            }
            bool czyWybórSortowania = true;
            while (czyWybórSortowania)
            {
                Console.WriteLine("\nWybierz opcje: \nQuickSort[1] \nQuickSort z komentarzem[2]\nMergeSort[3]\nBucketSort[4]" +
                    "\nHeapSort[5]\nHeapSort z komentarzem[6]\nkoniec[0]");
                int wybórSortowania = 1;
                WeryfikacjaInputu(ref wybórSortowania);
                switch (wybórSortowania)
                {
                    case 1:
                        Console.WriteLine("Wybrałeś opcję QuickSort.");
                        QuickSort.Sortowanie(tab);
                        WyświetlTabele(tab);
                        Console.WriteLine("\nPosortowana tabela:");
                        break;
                    case 2:
                        Console.WriteLine("Wybrałeś opcję QuickSort.");
                        QuickSort.SortowanieZKomentarzem(tab);
                        WyświetlTabele(tab);
                        Console.WriteLine("\nPosortowana tabela:");
                        break;
                    case 3:
                        Console.WriteLine("Wybrałeś opcję MergeSort.");
                        MergeSorting.Merge(tab, 0, tab.Length - 1);
                        WyświetlTabele(tab);
                        Console.WriteLine("\nPosortowana tabela:");
                        break;
                    case 4:
                        Console.WriteLine("Wybrałeś opcję BucketSort.");
                        Bucket.BucketSort(tab);
                        Console.WriteLine("\nPosortowana tabela:");
                        WyświetlTabele(tab);
                        break;
                    case 5:
                        Console.WriteLine("Wybrałeś opcję HeapSort.");
                        HeapSort.DoHeapSort(tab);
                        Console.WriteLine("\nPosortowana tabela:");
                        WyświetlTabele(tab);
                        break;
                    case 6:
                        Console.WriteLine("Wybrałeś opcję HeapSort z komentarzem.");
                        HeapSort.ExplainHeapSort(tab);
                        Console.WriteLine("\nPosortowana tabela:");
                        WyświetlTabele(tab);
                        break;
                    case 0:
                        czyWybórSortowania = false;
                        break;
                    default:
                        Console.WriteLine("Błędna wartość. Wybierz ponownie.");
                        break;
                }
            }
        }
    }
}

