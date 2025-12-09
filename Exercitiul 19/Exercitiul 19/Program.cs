//Se da un vector s (vectorul in care se cauta) si un vector p
//(vectorul care se cauta). Determinati de cate ori apare p in s. De ex.
//Daca s = [1,2,1,2,1,3,1,2,1] si p = [1,2,1] atunci p apare in s de 3 ori.
//(Problema este dificila doar daca o rezolvati cu un algoritm liniar). 
using System;

class Program
{
    static void Main()
    {
        // Citirea dimensiunii vectorului s
        Console.Write("Introdu dimensiunea vectorului s: ");
        int n = int.Parse(Console.ReadLine());
        int[] s = new int[n];

        Console.WriteLine("Introdu elementele vectorului s:");
        for (int i = 0; i < n; i++)
        {
            s[i] = int.Parse(Console.ReadLine());
        }

        // Citirea dimensiunii vectorului p
        Console.Write("Introdu dimensiunea vectorului p: ");
        int m = int.Parse(Console.ReadLine());
        int[] p = new int[m];

        Console.WriteLine("Introdu elementele vectorului p:");
        for (int i = 0; i < m; i++)
        {
            p[i] = int.Parse(Console.ReadLine());
        }

        // Numărarea aparițiilor lui p în s
        int count = 0;

        for (int i = 0; i <= n - m; i++)
        {
            bool gasit = true;
            for (int j = 0; j < m; j++)
            {
                if (s[i + j] != p[j])
                {
                    gasit = false;
                    break;
                }
            }
            if (gasit)
                count++;
        }

        Console.WriteLine($"Vectorul p apare in s de {count} ori.");
    }
}

