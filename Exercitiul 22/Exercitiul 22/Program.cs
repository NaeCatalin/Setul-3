//Se dau doi vectori v1 si v2. Se cere sa determine intersectia, reuniunea, si diferentele
//v1-v2 si v2 -v1 (implementarea operatiilor cu multimi).
//Elementele care se repeta vor fi scrise o singura data in rezultat. 


using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Citirea primului vector
        Console.Write("Introdu dimensiunea vectorului v1: ");
        int n1 = int.Parse(Console.ReadLine());
        int[] v1 = new int[n1];
        Console.WriteLine("Introdu elementele vectorului v1:");
        for (int i = 0; i < n1; i++)
            v1[i] = int.Parse(Console.ReadLine());

        // Citirea celui de-al doilea vector
        Console.Write("Introdu dimensiunea vectorului v2: ");
        int n2 = int.Parse(Console.ReadLine());
        int[] v2 = new int[n2];
        Console.WriteLine("Introdu elementele vectorului v2:");
        for (int i = 0; i < n2; i++)
            v2[i] = int.Parse(Console.ReadLine());

        // Transformăm vectorii în mulțimi (HashSet)
        HashSet<int> set1 = new HashSet<int>(v1);
        HashSet<int> set2 = new HashSet<int>(v2);

        // Intersectia
        HashSet<int> intersectie = new HashSet<int>(set1);
        intersectie.IntersectWith(set2);

        // Reuniunea
        HashSet<int> reuniune = new HashSet<int>(set1);
        reuniune.UnionWith(set2);

        // Diferente
        HashSet<int> diferenta1 = new HashSet<int>(set1);
        diferenta1.ExceptWith(set2); // v1 - v2

        HashSet<int> diferenta2 = new HashSet<int>(set2);
        diferenta2.ExceptWith(set1); // v2 - v1

        // Afisarea rezultatelor
        Console.WriteLine("Intersectia: " + string.Join(", ", intersectie));
        Console.WriteLine("Reuniunea: " + string.Join(", ", reuniune));
        Console.WriteLine("Diferenta v1 - v2: " + string.Join(", ", diferenta1));
        Console.WriteLine("Diferenta v2 - v1: " + string.Join(", ", diferenta2));
    }
}
