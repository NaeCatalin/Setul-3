//Aceleasi cerinte ca si la problema anterioara dar de data asta elementele sunt
//stocate ca vectori cu valori binare
//(v[i] este 1 daca i face parte din multime si este 0 in caz contrar).


using System;

class Program
{
    static void Main()
    {
        // Citirea dimensiunii vectorilor (reprezentarea mulțimii până la maxim n-1)
        Console.Write("Introdu dimensiunea vectorilor: ");
        int n = int.Parse(Console.ReadLine());

        int[] v1 = new int[n];
        int[] v2 = new int[n];

        Console.WriteLine("Introdu vectorul v1 (0 sau 1 pentru fiecare element):");
        for (int i = 0; i < n; i++)
            v1[i] = int.Parse(Console.ReadLine());

        Console.WriteLine("Introdu vectorul v2 (0 sau 1 pentru fiecare element):");
        for (int i = 0; i < n; i++)
            v2[i] = int.Parse(Console.ReadLine());

        int[] intersectie = new int[n];
        int[] reuniune = new int[n];
        int[] diferenta1 = new int[n]; // v1 - v2
        int[] diferenta2 = new int[n]; // v2 - v1

        for (int i = 0; i < n; i++)
        {
            intersectie[i] = v1[i] & v2[i];       // AND → intersecție
            reuniune[i] = v1[i] | v2[i];          // OR  → reuniune
            diferenta1[i] = v1[i] & (1 - v2[i]);  // v1 AND NOT v2
            diferenta2[i] = v2[i] & (1 - v1[i]);  // v2 AND NOT v1
        }

        // Afișarea rezultatelor
        Console.WriteLine("Intersectia: " + string.Join(" ", intersectie));
        Console.WriteLine("Reuniunea: " + string.Join(" ", reuniune));
        Console.WriteLine("Diferenta v1 - v2: " + string.Join(" ", diferenta1));
        Console.WriteLine("Diferenta v2 - v1: " + string.Join(" ", diferenta2));
    }
}

