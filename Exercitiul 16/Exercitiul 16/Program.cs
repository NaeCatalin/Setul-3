//Se da un vector de n numere naturale.
//Determinati cel mai mare divizor comun al elementelor vectorului.

using System;

class Program
{
    // Funcție pentru calcularea CMMD a două numere
    static int CMMDC(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    static void Main()
    {
        // Citim dimensiunea vectorului
        Console.Write("Introdu numarul de elemente ale vectorului: ");
        int n = int.Parse(Console.ReadLine());

        int[] vector = new int[n];

        // Citim elementele vectorului
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Elementul {i + 1}: ");
            vector[i] = int.Parse(Console.ReadLine());
        }

        // Calculăm CMMD pentru întreg vectorul
        int cmmdc = vector[0];
        for (int i = 1; i < n; i++)
        {
            cmmdc = CMMDC(cmmdc, vector[i]);
        }

        // Afișăm rezultatul
        Console.WriteLine("Cel mai mare divizor comun al elementelor vectorului este: " + cmmdc);
    }
}
