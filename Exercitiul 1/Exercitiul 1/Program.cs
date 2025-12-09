//Calculati suma elementelor unui vector de n numere citite de la tastatura.
//Rezultatul se va afisa pe ecran.

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Introduceti numarul de elemente:");
        int n = int.Parse(Console.ReadLine());

        int[] v = new int[n];
        int suma = 0;

        Console.WriteLine("Introduceti cele " + n + " numere:");
        for (int i = 0; i < n; i++)
        {
            v[i] = int.Parse(Console.ReadLine());
            suma += v[i];
        }
        Console.WriteLine("Suma elementelor vectorului este: " + suma);
        
    }
}