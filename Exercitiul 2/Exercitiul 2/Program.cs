//Se da un vector cu n elemente si o valoare k. Se cere sa se determine prima
//pozitie din vector pe care apare k.
//Daca k nu apare in vector rezultatul va fi -1. 


using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Introduceti numarul de elemente:");
        int n = int.Parse(Console.ReadLine());

        int[] v = new int[n];

        Console.WriteLine("Introduceti cele"  + n +  "elemente");
        for (int i = 0; i < n; i++  )
        {
            v [i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Introduceti valoarea k:");
        int k = int.Parse(Console.ReadLine());

        int pozitie = -1;


        for (int i = 0; i < n; i++)
        {
            if (v[i]==k)
            {
                pozitie = i;
                break;
            }
        }
        Console.WriteLine("Prima pozitie unde apare k este" + pozitie);

        

    }
}