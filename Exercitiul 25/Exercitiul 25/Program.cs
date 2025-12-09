//(Interclasare) Se dau doi vector sortati crescator v1 si v2.
//Construiti un al treilea vector ordonat crescator format din toate elementele
//din  v1 si v2. Sunt permise elemente duplicate. 


using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Citirea primului vector sortat
        Console.Write("Introdu dimensiunea vectorului v1: ");
        int n1 = int.Parse(Console.ReadLine());
        int[] v1 = new int[n1];
        Console.WriteLine("Introdu elementele vectorului v1 (crescator):");
        for (int i = 0; i < n1; i++)
            v1[i] = int.Parse(Console.ReadLine());

        // Citirea celui de-al doilea vector sortat
        Console.Write("Introdu dimensiunea vectorului v2: ");
        int n2 = int.Parse(Console.ReadLine());
        int[] v2 = new int[n2];
        Console.WriteLine("Introdu elementele vectorului v2 (crescator):");
        for (int i = 0; i < n2; i++)
            v2[i] = int.Parse(Console.ReadLine());

        List<int> v3 = new List<int>();
        int p1 = 0, p2 = 0;

        // Interclasarea vectorilor
        while (p1 < n1 && p2 < n2)
        {
            if (v1[p1] <= v2[p2])
            {
                v3.Add(v1[p1]);
                p1++;
            }
            else
            {
                v3.Add(v2[p2]);
                p2++;
            }
        }

        // Adăugăm elementele rămase
        while (p1 < n1)
        {
            v3.Add(v1[p1]);
            p1++;
        }

        while (p2 < n2)
        {
            v3.Add(v2[p2]);
            p2++;
        }

        // Afișarea rezultatului
        Console.WriteLine("Vectorul interclasat v3:");
        Console.WriteLine(string.Join(", ", v3));
    }
}

