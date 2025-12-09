//Sortare bicriteriala.
//Se dau doi vectori de numere intregi E si W, unde E[i] este un numar iar W[i] este un numar care reprezinta ponderea lui E[i].
//Sortati vectorii astfel incat elementele lui E sa fie in in ordine crescatoare
//iar pentru doua valori egale din E, cea cu pondere mai mare va fi prima. 


using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Citirea vectorului E
        Console.Write("Introdu dimensiunea vectorilor: ");
        int n = int.Parse(Console.ReadLine());

        int[] E = new int[n];
        int[] W = new int[n];

        Console.WriteLine("Introdu elementele vectorului E:");
        for (int i = 0; i < n; i++)
            E[i] = int.Parse(Console.ReadLine());

        Console.WriteLine("Introdu elementele vectorului W (pondere):");
        for (int i = 0; i < n; i++)
            W[i] = int.Parse(Console.ReadLine());

        // Creăm o listă de tuple (E, W)
        List<(int e, int w)> P = new List<(int e, int w)>();
        for (int i = 0; i < n; i++)
            P.Add((E[i], W[i]));

        // Sortarea bicriterială
        P.Sort((a, b) =>
        {
            int cmp = a.e.CompareTo(b.e); // E crescător
            if (cmp != 0)
                return cmp;

            // Dacă E este egal, W descrescător
            return b.w.CompareTo(a.w);
        });

        // Copiem rezultatul sortat în vectorii E și W
        for (int i = 0; i < n; i++)
        {
            E[i] = P[i].e;
            W[i] = P[i].w;
        }

        // Afișarea rezultatelor
        Console.WriteLine("Vectorii sortati:");
        Console.WriteLine("E: " + string.Join(" ", E));
        Console.WriteLine("W: " + string.Join(" ", W));
    }
}
