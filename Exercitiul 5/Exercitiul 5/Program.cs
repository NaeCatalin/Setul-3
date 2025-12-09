//Se da un vector cu n elemente, o valoare e si o pozitie din vector k.
//Se cere sa se insereze valoarea e in vector pe pozitia k.
//Primul element al vectorului se considera pe pozitia zero. 

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("n =  ");
        int n = int.Parse(Console.ReadLine());

        int[] v = new int[n];

        Console.WriteLine("Introdu elementele: ");
        for (int i = 0; i < n; i++)
        
            v[i] = int.Parse(Console.ReadLine());

            Console.WriteLine("Pozitia e =");
            int e = int.Parse(Console.ReadLine());

            Console.WriteLine("Pozitia k = ");
            int k = int.Parse(Console.ReadLine());

            if (k < 0 || k > n)
            {
                Console.WriteLine("Pozitie invalida ! ");
                return;
            }
            int[] nou = new int[n + 1];

            nou[k] = e;

            for (int i = k; i < n; i++)
                nou[i + 1] = v[i];

            Console.WriteLine("Vectorul dupa inserare");
            for (int i=0; i < n; i++)
                Console.WriteLine(nou[i] + " ");
        
    }
}