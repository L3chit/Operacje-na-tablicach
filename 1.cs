using System;

class Program
{
    static void Main()
    {
        int[] tablica = GenerujTablice(10);
        WypiszOdTylu(tablica);
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

    static void WypiszOdTylu(int[] tablica)
    {
        for (int i = tablica.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(tablica[i]);
        }
    }
}
