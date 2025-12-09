//(Element majoritate). Intr-un vector cu n elemente, un element m este element majoritate
//daca mai mult de n/2 din valorile vectorului sunt egale cu m
//(prin urmare, daca un vector are element majoritate acesta este unui singur).
//Sa se determine elementul majoritate al unui vector
//(daca nu exista atunci se va afisa <nu exista>).
//(incercati sa gasiti o solutie liniara). 


using System;

class Program
{
    static void Main()
    {
        // Citire vector
        Console.Write("Introdu dimensiunea vectorului: ");
        int n = int.Parse(Console.ReadLine());

        int[] v = new int[n];
        Console.WriteLine("Introdu elementele:");
        for (int i = 0; i < n; i++)
            v[i] = int.Parse(Console.ReadLine());

        // Boyer–Moore
        int candidate = 0;
        int count = 0;

        for (int i = 0; i < n; i++)
        {
            if (count == 0)
            {
                candidate = v[i];
                count = 1;
            }
            else if (v[i] == candidate)
            {
                count++;
            }
            else
            {
                count--;
            }
        }

        // Verificam daca candidate chiar este majoritate
        int aparitii = 0;
        for (int i = 0; i < n; i++)
            if (v[i] == candidate)
                aparitii++;

        if (aparitii > n / 2)
            Console.WriteLine("Elementul majoritate este: " + candidate);
        else
            Console.WriteLine("nu exista");
    }
}


