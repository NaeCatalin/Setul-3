//Aceleasi cerinte ca si la problema anterioara dar de data asta elementele din v1
//respectiv v2  sunt in ordine strict crescatoare. 

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Citirea primului vector (strict crescator)
        Console.Write("Introdu dimensiunea vectorului v1: ");
        int n1 = int.Parse(Console.ReadLine());
        int[] v1 = new int[n1];
        Console.WriteLine("Introdu elementele vectorului v1 in ordine strict crescatoare:");
        for (int i = 0; i < n1; i++)
            v1[i] = int.Parse(Console.ReadLine());

        // Citirea celui de-al doilea vector (strict crescator)
        Console.Write("Introdu dimensiunea vectorului v2: ");
        int n2 = int.Parse(Console.ReadLine());
        int[] v2 = new int[n2];
        Console.WriteLine("Introdu elementele vectorului v2 in ordine strict crescatoare:");
        for (int i = 0; i < n2; i++)
            v2[i] = int.Parse(Console.ReadLine());

        List<int> intersectie = new List<int>();
        List<int> reuniune = new List<int>();
        List<int> diferenta1 = new List<int>();
        List<int> diferenta2 = new List<int>();

        int p1 = 0, p2 = 0;

        while (p1 < n1 && p2 < n2)
        {
            if (v1[p1] == v2[p2])
            {
                intersectie.Add(v1[p1]);
                reuniune.Add(v1[p1]);
                p1++;
                p2++;
            }
            else if (v1[p1] < v2[p2])
            {
                diferenta1.Add(v1[p1]);
                reuniune.Add(v1[p1]);
                p1++;
            }
            else // v1[p1] > v2[p2]
            {
                diferenta2.Add(v2[p2]);
                reuniune.Add(v2[p2]);
                p2++;
            }
        }

        // Adăugăm eventualele elemente rămase
        while (p1 < n1)
        {
            diferenta1.Add(v1[p1]);
            reuniune.Add(v1[p1]);
            p1++;
        }

        while (p2 < n2)
        {
            diferenta2.Add(v2[p2]);
            reuniune.Add(v2[p2]);
            p2++;
        }

        // Afișarea rezultatelor
        Console.WriteLine("Intersectia: " + string.Join(", ", intersectie));
        Console.WriteLine("Reuniunea: " + string.Join(", ", reuniune));
        Console.WriteLine("Diferenta v1 - v2: " + string.Join(", ", diferenta1));
        Console.WriteLine("Diferenta v2 - v1: " + string.Join(", ", diferenta2));
    }
}
