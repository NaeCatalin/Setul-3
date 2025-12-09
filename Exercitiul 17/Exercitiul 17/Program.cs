//Se da un numar n in baza 10 si un numar b. 1 < b < 17.
//Sa se converteasca si sa se afiseze numarul n in baza b.   

using System;

class Program
{
    static void Main()
    {
        // Citirea numărului în baza 10
        Console.Write("Introduceti numarul in baza 10: ");
        int n = int.Parse(Console.ReadLine());

        // Citirea bazei de conversie
        Console.Write("Introduceti baza b (2-16): ");
        int b = int.Parse(Console.ReadLine());

        if (b < 2 || b > 16)
        {
            Console.WriteLine("Baza trebuie sa fie intre 2 si 16.");
            return;
        }

        // Conversia numarului in baza b
        string rezultat = "";
        int numar = n;

        if (numar == 0)
        {
            rezultat = "0";
        }
        else
        {
            while (numar > 0)
            {
                int rest = numar % b;
                char cifra;

                if (rest < 10)
                    cifra = (char)('0' + rest);
                else
                    cifra = (char)('A' + (rest - 10)); // pentru baze > 10

                rezultat = cifra + rezultat;
                numar /= b;
            }
        }

        // Afișarea rezultatului
        Console.WriteLine($"Numarul {n} in baza {b} este: {rezultat}");
    }
}

