//Rotire.
//Se da un vector cu n elemente.
//Rotiti elementele vectorului cu o pozitie spre stanga.
//Prin rotire spre stanga primul element devine ultimul, al doilea devine primul etc.

using System;

class Program
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        int[] victor = new int[n];

        Console.WriteLine("Introduceti elementele:");
        for (int i = 0;i < n; i++)
        {
            victor[i] = int.Parse(Console.ReadLine());

        }
     int firstElement = victor[0];
        for (int i = 0; i < n - 1; i++)
        {
            victor[i] = victor[i + 1];
        }
        victor[n - 1] = firstElement;

        Console.WriteLine("Vectorul rotit spre stanga:");

        for (int i = 0; i < n; i++)
        {
            Console.Write(victor[i] + " ");
        }


    }
}