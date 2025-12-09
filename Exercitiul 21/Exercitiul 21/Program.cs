//Se dau doi vectori. Se cere sa se determine ordinea lor lexicografica
//(care ar trebui sa apara primul in dictionar). 

using System;

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

        // Determinarea ordinii lexicografice
        int minLength = Math.Min(n1, n2);
        int ord = 0; // 0 = egale, -1 = v1 < v2, 1 = v1 > v2

        for (int i = 0; i < minLength; i++)
        {
            if (v1[i] < v2[i])
            {
                ord = -1;
                break;
            }
            else if (v1[i] > v2[i])
            {
                ord = 1;
                break;
            }
        }

        // Dacă toate elementele comparate sunt egale, vectorul mai scurt este mai mic
        if (ord == 0)
        {
            if (n1 < n2)
                ord = -1;
            else if (n1 > n2)
                ord = 1;
            else
                ord = 0; // vectorii sunt identici
        }

        // Afișarea rezultatului
        if (ord == -1)
            Console.WriteLine("Primul vector apare primul in ordine lexicografica.");
        else if (ord == 1)
            Console.WriteLine("Al doilea vector apare primul in ordine lexicografica.");
        else
            Console.WriteLine("Vectorii sunt identici.");
    }
}
