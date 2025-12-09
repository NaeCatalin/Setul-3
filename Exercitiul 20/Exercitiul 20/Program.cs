// Se dau doua siraguri de margele formate din margele albe si negre, notate s1,
// respectiv s2. Determinati numarul de suprapuneri (margea cu margea) a unui
// sirag peste celalalt astfel incat margelele suprapuse au aceeasi culoare.
// Siragurile de margele se pot roti atunci cand le suprapunem. 


using System;

class Program
{
    static void Main()
    {
        // Citirea siragurilor
        Console.Write("Introdu siragul s1 (ex: BNBWB): ");
        string s1 = Console.ReadLine().ToUpper();

        Console.Write("Introdu siragul s2 (ex: BNBWB): ");
        string s2 = Console.ReadLine().ToUpper();

        if (s1.Length != s2.Length)
        {
            Console.WriteLine("Siragurile trebuie sa aiba aceeasi lungime.");
            return;
        }

        int n = s1.Length;
        int maxSuprapuneri = 0;

        // Rotim s2 și verificăm pentru fiecare decalare
        for (int shift = 0; shift < n; shift++)
        {
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                // Poziția din s2 ținând cont de rotire
                int j = (i + shift) % n;
                if (s1[i] == s2[j])
                    count++;
            }

            if (count > maxSuprapuneri)
                maxSuprapuneri = count;
        }

        Console.WriteLine($"Numarul maxim de margele suprapuse cu aceeasi culoare este: {maxSuprapuneri}");
    }
}
