//Reverse. Se da un vector nu n elemente.
//Se cere sa se inverseze ordinea elementelor din vector.
//Prin inversare se intelege ca primul element devine ultimul,
//al doilea devine penultimul etc.

using System;

class Program
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        int [] vector = new int[n];

        Console.WriteLine("Introdu elementele");
        for (int i = 0;i < n; i++)
        {
            vector[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n / 2; i++)
        {
            int aux = vector[i];
            vector[i] = vector[n - i - 1];
            vector[n - i - 1] = aux;
        }
        Console.WriteLine("Vectorul selectat: ");
        for (int i = 0; i < n; i++)
        {
            Console.Write(vector[i]);
        }

    }
}