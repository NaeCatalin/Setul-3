//Interschimbati elementele unui vector in asa fel incat la final toate valorile
//egale cu zero sa ajunga la sfarsit.
//(nu se vor folosi vectori suplimentari - operatia se va realiza inplace cu un
//algoritm eficient - se va face o singura parcugere a vectorului). 

using System;

class Program
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        int[] v = new int[n];

        Console.WriteLine("Introdu elementele");
        for (int i = 0; i < n; i++)
        {
            v[i] = int.Parse(Console.ReadLine());
        }
        int k = 0;

        for (int i = 0; i < n; i++)
        {
            if (v[i] != k)
            {
                int aux = v[i];
                v[i] = v[k];
                v[k] = aux;
            }
            k++;
        }
        Console.WriteLine("Vectorul rezultat este:");
        for (int i = 0;i < n; i++)
        {
            Console.Write(v[i] + " ");
        }
    }

}
