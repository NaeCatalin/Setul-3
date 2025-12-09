//Cautare binara. Se da un vector cu n elemente sortat in ordine crescatoare.
//Se cere sa se determine pozitia unui element dat k.
//Daca elementul nu se gaseste in vector rezultatul va fi -1

using System;

class Program
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        int[] v = new int[n];

        Console.WriteLine("Introduceti elementele vectorului sortat in ordine crescatoare:");

        for (int i = 0; i < n; i++)
        {
            v[i] = int.Parse(Console.ReadLine());
            
        }

        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());

        int linie = 0, dreapta = n - 1;
            int pozitie = -1;
        while (linie <= dreapta)
        {
            int mijloc = (linie + dreapta) / 2;
            if (v[mijloc] == k)

            {
                pozitie = mijloc;
                break;

            }
            else if (v[mijloc] < k)
            {
                linie = mijloc + 1;
            }
            else
            {
                dreapta = mijloc - 1;
            }
        }
        Console.WriteLine("Pozitia elementului k este: " + pozitie);

    }
}
