using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj rozmiar tablicy: ");
        int rozmiar = int.Parse(Console.ReadLine());

        int[] tablica = GenerujTablice(rozmiar);
        WypiszTablice(tablica);

        int najmniejszyElement = ZnajdzNajmniejszyElement(tablica);
        int najwiekszyElement = ZnajdzNajwiekszyElement(tablica);

        Console.WriteLine($"Najmniejszy element: {najmniejszyElement}");
        Console.WriteLine($"Największy element: {najwiekszyElement}");
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

    static int ZnajdzNajmniejszyElement(int[] tablica)
    {
        int najmniejszyElement = tablica[0];

        for (int i = 1; i < tablica.Length; i++)
        {
            if (tablica[i] < najmniejszyElement)
            {
                najmniejszyElement = tablica[i];
            }
        }

        return najmniejszyElement;
    }

    static int ZnajdzNajwiekszyElement(int[] tablica)
    {
        int najwiekszyElement = tablica[0];

        for (int i = 1; i < tablica.Length; i++)
        {
            if (tablica[i] > najwiekszyElement)
            {
                najwiekszyElement = tablica[i];
            }
        }

        return najwiekszyElement;
    }
}
