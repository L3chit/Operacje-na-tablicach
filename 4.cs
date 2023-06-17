using System;

class Program
{
    static void Main()
    {
        int[] tablica = GenerujTablice(10);

        Console.WriteLine("Tablica przed sortowaniem:");
        WypiszTablice(tablica);

        SortowaniePrzezWstawianie(tablica);

        Console.WriteLine("Tablica po sortowaniu:");
        WypiszTablice(tablica);
    }

    static int[] GenerujTablice(int rozmiar)
    {
        int[] tablica = new int[rozmiar];
        Random random = new Random();

        for (int i = 0; i < rozmiar; i++)
        {
            tablica[i] = random.Next(1, 100);
        }

        return tablica;
    }

    static void WypiszTablice(int[] tablica)
    {
        Console.WriteLine("Tablica:");

        for (int i = 0; i < tablica.Length; i++)
        {
            Console.Write(tablica[i] + " ");
        }

        Console.WriteLine();
    }

    static void SortowaniePrzezWstawianie(int[] tablica)
    {
        int n = tablica.Length;

        for (int i = 1; i < n; i++)
        {
            int klucz = tablica[i];
            int j = i - 1;

            while (j >= 0 && tablica[j] > klucz)
            {
                tablica[j + 1] = tablica[j];
                j = j - 1;
            }

            tablica[j + 1] = klucz;
        }
    }
}
