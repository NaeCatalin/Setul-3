//Se da un vector cu n elemente si o pozitie din vector k.
//Se cere sa se stearga din vector elementul de pe pozitia k.
//Prin stergerea unui element, toate elementele din dreapta lui se muta cu o
//pozitie spre stanga. 

using System;

class Program
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        
        int[] v = new int[n];

        Console.Write("Introdu elementele:\n");
        for (int i = 0; i < n; i++)
        {
            v[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Pozitia \nk = ");
        int k = int.Parse(Console.ReadLine());

        if (k < 0 || k >= n)
        {
            Console.WriteLine("Pozitie invalida!");
            return;
        }

        int[] nou = new int[n - 1];

        // Copiaza elementele inainte k
        for (int i = 0; i < k-1; i++)
        {
            nou[i] = v[i];
        }
        // Copiaza elemente dupa k
        for (int i = k-1; i < n - 1; i++)
        {
            nou[i] = v[i + 1];
        }

        Console.WriteLine("Vectorul dupa stergere");
        for (int i = 0; i < n - 1; i++)
        {
            Console.Write(nou[i] + " ");
        }
        Console.WriteLine();
    }
}