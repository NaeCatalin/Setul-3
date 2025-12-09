// Rotire k.
// Se da un vector cu n elemente.
// Rotiti elementele vectorului cu k pozitii spre stanga. 

using System;

class Program
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        int[] vector = new int[n];

        Console.WriteLine("Introduceti elementele:");

        for (int i = 0; i < n; i++) 
        {
            vector[i] = int.Parse(Console.ReadLine()); 
        }
        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());

        k = k % n;

        int[] rezultat = new int[n];
        int idx = 0;

        //Elementele k la n-1
        for (int i = k; i < n; i++)
            rezultat[idx++] = vector[i];
        // Elementele de la o la k - 1

        for (int i = 0; i < k; i++)
            rezultat[idx++] = vector[i];

        Console.WriteLine("Vectorul rotit spre stanga este:");
        for (int i = 0; i < n; i++)
            Console.Write(rezultat[i] + " ");


    }
}
