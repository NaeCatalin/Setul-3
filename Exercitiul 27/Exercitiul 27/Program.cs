// Se da un vector si un index in vectorul respectiv.
// Se cere sa se determine valoarea din vector care va fi pe pozitia index dupa
// ce vectorul este sortat. 


using System;

class Program
{
    static void Main()
    {
        // Citirea dimensiunii vectorului
        Console.Write("Introdu dimensiunea vectorului: ");
        int n = int.Parse(Console.ReadLine());

        int[] v = new int[n];

        Console.WriteLine("Introdu elementele vectorului:");
        for (int i = 0; i < n; i++)
            v[i] = int.Parse(Console.ReadLine());

        // Citirea indexului căutat
        Console.Write("Introdu indexul: ");
        int index = int.Parse(Console.ReadLine());

        if (index < 0 || index >= n)
        {
            Console.WriteLine("Index invalid!");
            return;
        }

        // Sortarea vectorului
        Array.Sort(v);

        // Afișarea elementului aflat pe poziția index după sortare
        Console.WriteLine($"Valoarea de pe pozitia {index} dupa sortare este: {v[index]}");
    }
}
