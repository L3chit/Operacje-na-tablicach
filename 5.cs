using System;

class Program
{
    static void Main()
    {
        int[] tablica = GenerujTablice(10);

        Console.WriteLine("Tablica przed sortowaniem:");
        WypiszTablice(tablica);

        SortowaniePrzezWybieranie(tablica);

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

    static void SortowaniePrzezWybieranie(int[] tablica)
    {
        int n = tablica.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int indeksMinimum = i;

            for (int j = i + 1; j < n; j++)
            {
                if (tablica[j] < tablica[indeksMinimum])
                {
                    indeksMinimum = j;
                }
            }

            ZamienElementy(tablica, i, indeksMinimum);
        }
    }

    static void ZamienElementy(int[] tablica, int indeks1, int indeks2)
    {
        int temp = tablica[indeks1];
        tablica[indeks1] = tablica[indeks2];
        tablica[indeks2] = temp;
    }
}
