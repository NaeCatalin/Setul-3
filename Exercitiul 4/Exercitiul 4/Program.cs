//Deteminati printr-o singura parcurgere, cea mai mica si cea mai mare valoare
//dintr-un vector si de cate ori apar acestea. 

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Introdu numerele de elemente n ");
        int n = int.Parse(Console.ReadLine());

        int [] v = new int[n];
       Console.WriteLine("Introdu cele " + n + " elemente"); 
        for (int i = 0; i < n; i++)
            v[i] = int.Parse(Console.ReadLine());

        int ValoareMinima = v[0], ValoareMaxima = v[0];
        int AparitiiMinima = 1, AparitiiMaxima = 1;

        for (int i = 1;i< n; i++)
        {
            if (v[i] < ValoareMinima)
            {
                ValoareMinima = v[i];
                AparitiiMinima = 1;

            }
            else if (v[i] == ValoareMinima)
            {
                AparitiiMinima++;
            }
            if (v[i] > ValoareMaxima)
            {
                ValoareMaxima = v[i];
                AparitiiMaxima = 1;
            }
            else if (v[i] == ValoareMaxima)
            {
                AparitiiMaxima++;
            }
                
            
        }
        Console.WriteLine($"Valoarea minima este {ValoareMinima} si apare de {AparitiiMinima} ori.");
        Console.WriteLine($"Valoarea maxima este {ValoareMaxima} si apare de {AparitiiMaxima} ori.");

    }
}