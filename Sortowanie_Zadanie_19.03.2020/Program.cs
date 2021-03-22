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
                        foreach (var a in tab)
                        {
                            Console.Write(" " + a);
                        }
                        Console.WriteLine();
                        czyWybórTabeli = false;
                        break;
                    case 2:
                        Console.WriteLine("Wybrałeś opcję użycie predefiniowanej tabeli.");
                        Console.WriteLine("Oto Twoja tabela:");
                        tab = new int[] { 9, 1, 2, 4, 5, 7, 8, 6, 3 };
                        foreach (var a in tab)
                        {
                            Console.Write(" " + a);
                        }
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
                Console.WriteLine("\nWybierz opcje: \nQuickSort[1] \nQuickSort z komentarzem[2]\nMergeSort[3]");
                int wybórSortowania = 1;
                WeryfikacjaInputu(ref wybórSortowania);
                switch (wybórSortowania)
                {
                    case 1:
                        Console.WriteLine("Wybrałeś opcję QuickSort.");
                        QuickSort.Sortowanie(tab);
                        czyWybórSortowania = false;
                        break;
                    case 2:
                        Console.WriteLine("Wybrałeś opcję QuickSort.");
                        QuickSort.SortowanieZKomentarzem(tab);
                        czyWybórSortowania = false;
                        break;
                    case 3:
                        MergeSorting.Merge(tab, 0, tab.Length - 1);
                        czyWybórSortowania = false;
                        break;
                    default:
                        Console.WriteLine("Błędna wartość. Wybierz ponownie.");
                        break;
                }
                Console.WriteLine("\nPosortowana tabela:");
                foreach (var a in tab)
                {
                    Console.Write(" " + a);
                }
            }
            Console.ReadLine();
        }
    }
}

