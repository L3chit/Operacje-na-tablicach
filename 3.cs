using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj ilość danych w tablicy: ");
        int iloscDanych = int.Parse(Console.ReadLine());

        int[] tablica = GenerujTablice(iloscDanych);
        WypiszTablice(tablica);

        SortowanieBabelkowe(tablica);

        Console.WriteLine("Tablica po sortowaniu:");
        WypiszTablice(tablica);
    }

    static int[] GenerujTablice(int iloscDanych)
    {
        int[] tablica = new int[iloscDanych];
        Random random = new Random();

        for (int i = 0; i < iloscDanych; i++)
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

    static void SortowanieBabelkowe(int[] tablica)
    {
        int n = tablica.Length;
        bool zamiana;

        do
        {
            zamiana = false;

            for (int i = 0; i < n - 1; i++)
            {
                if (tablica[i] > tablica[i + 1])
                {
                    ZamienElementy(tablica, i, i + 1);
                    zamiana = true;
                }
            }

            n--;
        }
        while (zamiana);
    }

    static void ZamienElementy(int[] tablica, int indeks1, int indeks2)
    {
        int temp = tablica[indeks1];
        tablica[indeks1] = tablica[indeks2];
        tablica[indeks2] = temp;
    }
}
